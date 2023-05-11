using Microsoft.Win32.SafeHandles;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Banker_Algorithm_Project
{
    public struct Resource
    {
        string name;
        int number;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public Resource(string name, int number)
        {
            this.name = name;
            this.number = number;
        }
        public Resource(Resource r)
        {
            this = new Resource(r.Name , r.number);
        }
    }

    enum Flag
    {
        NoChange,
        ProcessFreed,
        ProcessBlocked
    }

    internal class BankerAlgorithm
    {
        // fields
        public static string state;
        public static string steps;
        public static string freedSequence = "";
        public static string blockedSequence = "";
        private static int resourcesCount = MainForm.listOfResources.Count;
        private static int rowCount = MainForm.currentAllocated.GetLength(0);
        private static int columnCount = MainForm.currentAllocated.GetLength(1);

        private Resource[] totalResources = new Resource[resourcesCount];
        private Resource[] availableResources = new Resource[resourcesCount];
        private Resource[,] currentAllocatedResources = new Resource[rowCount, columnCount];
        private Resource[,] maximumNeededResources = new Resource[rowCount, columnCount];
        private Resource[,] remainingNeededResources = new Resource[rowCount, columnCount];
        private List<string> listOfFreedProcesses = new List<string>();
        private List<string> listOfBlockeddProcesses = new List<string>();


        // methods
        public static void runAlgorithmOnCurrentConditions() 
        {
            BankerAlgorithm bankerAlg = new BankerAlgorithm();
            bankerAlg.intializeFields();
            bankerAlg.calculateAvailableResources(); 
            bankerAlg.calculateRemainingResources();
            bankerAlg.printResult("",bankerAlg.checkAlgorithm());
        }
        
        public static void assumeProcessRequestedResource(string p , string r , int n)
        {
            BankerAlgorithm bankerAlg = new BankerAlgorithm();
            bankerAlg.intializeFields();
            bankerAlg.prepareForAssumption(p,r,n);
            bankerAlg.calculateAvailableResources();
            bankerAlg.calculateRemainingResources();
            bankerAlg.printResult("Process "+p+" is ",bankerAlg.checkAlgorithm());
        }

        private void prepareForAssumption(string p, string r, int n)
        {
            // add the number of resource requested by process to the current allocated resources
            for(int i = 1; i < columnCount; i++) 
            {
                for(int j = 0; j < rowCount; j++) 
                {
                    if (currentAllocatedResources[j,0].Name.Equals(p) && currentAllocatedResources[j, i].Name.Equals(r))
                    {
                        currentAllocatedResources[j, i].Number += n;
                    }
                }
            }
        }

        private void intializeFields()
        {
            // intialize needed fields with user input from the main form
            for (int i = 0; i < resourcesCount; i++)
            {
                totalResources[i] = new Resource(MainForm.listOfResources.ElementAt(i));
                availableResources[i] = new Resource(MainForm.listOfResources.ElementAt(i));
            }

            for (int i = 0; i < rowCount; i++)
            {
                for(int j=0; j < columnCount; j++)
                {
                    maximumNeededResources[i, j] = new Resource(MainForm.maximumNeeded[i, j].Name, MainForm.maximumNeeded[i, j].Number);
                    currentAllocatedResources[i, j] = new Resource(MainForm.currentAllocated[i, j].Name, MainForm.currentAllocated[i, j].Number);
                }
            }
        }

        private void calculateAvailableResources()
        {
            // calculate the available resources (total resources - current allocated resources)
            int currentRequiredResources = 0;

            for(int i=1; i<columnCount;i++)
            {
                for(int j=0; j<rowCount;j++)
                {
                    currentRequiredResources += currentAllocatedResources[j, i].Number;
                }
                availableResources[i-1].Number = totalResources[i-1].Number - currentRequiredResources;
                currentRequiredResources = 0;
            }
        }

        private void calculateRemainingResources()
        {
            // calculate the remain needed resources (maximum needed resources - current allocated resources)
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    remainingNeededResources[i,j] = new Resource(maximumNeededResources[i,j].Name ,
                                                 maximumNeededResources[i,j].Number - currentAllocatedResources[i,j].Number);

                    MainForm.remainNeeded[i, j] = remainingNeededResources[i, j]; // to show table in the MainForm GUI
                }
            }
        }

        private bool checkAlgorithm()
        {
            Flag flag;
            int counter = 1;
            while (true) // loop through each process
            {
                steps += counter + " iteration:\n\n";
                if (counter == 1)
                    printAvailableResources();

                counter++;
                flag = Flag.NoChange;

                // check if process is already freed ,if so then don't check on it again
                for (int i = 0; i < rowCount; i++)
                {
                    if(listOfFreedProcesses.Contains(remainingNeededResources[i, 0].Name) == true)
                    {
                        if (i < rowCount - 1)
                            continue; //care of use
                        else
                            break;
                    }
                    printProcessState(i, 0, 2);
                    //check if the availble resources greater than remaining resources
                    for (int j = 1; j < columnCount; j++)
                    {
                        if (remainingNeededResources[i, j].Name.Equals(availableResources[j - 1].Name)) // for saftey
                        {
                            if (remainingNeededResources[i, j].Number > availableResources[j - 1].Number) // if not block process
                            {
                               flag = block(i,j);
                               break;
                            }
                            else // else process flag.freed
                                flag = Flag.ProcessFreed;
                        }
                    }
               
                    // if all requested resources by a process is safe (flag.freed) ,then free process
                    if (flag == Flag.ProcessFreed)
                    {
                        free(i);
                        printProcessState(i,0,0);
                        printAvailableResources();
                    }
                }


                if(flag == Flag.NoChange && listOfFreedProcesses.Count == rowCount)
                {
                    foreach (string p in listOfFreedProcesses) // to print the sequence in the gui
                        freedSequence += p+"   ";
                    blockedSequence = "";
                    return true;
                }
                else if (flag == Flag.NoChange && listOfBlockeddProcesses.Count != 0)
                {
                    foreach (string p in listOfFreedProcesses) // to print the sequence in the gui
                        freedSequence += p + "   ";
                    foreach (string p in listOfBlockeddProcesses)
                        blockedSequence += p + "   ";
                    return false;
                }   
            }
        }

        private void free(int i)
        {
            // add resources held by the freed process to avalible resources
            for (int j = 1; j < columnCount; j++)
            {
                if(availableResources[j - 1].Name.Equals(currentAllocatedResources[i, j].Name)) // for saftey
                    availableResources[j-1].Number += currentAllocatedResources[i, j].Number;
            }

            // add freed process to list of freed processes to not check on it again in upcoming iterations
            listOfFreedProcesses.Add(currentAllocatedResources[i,0].Name);

            // check if the freed process is in the list of blocked processes ,then remove it
            if (listOfBlockeddProcesses.Contains(currentAllocatedResources[i, 0].Name))
                listOfBlockeddProcesses.Remove(currentAllocatedResources[i, 0].Name);
        }

        private Flag block(int i , int j)
        {
            // if blocked process is not in the list of blocked processes, then add it
            if (!listOfBlockeddProcesses.Contains(currentAllocatedResources[i, 0].Name))
            {
                listOfBlockeddProcesses.Add(currentAllocatedResources[i, 0].Name);
                printProcessState(i, j, 1);
                return Flag.ProcessBlocked;
            }
            else // if the process is already blocked then no change will happen
            { 
                printProcessState(i, j, 3);
                return Flag.NoChange;
            }
        }

        // functions to show steps only
        private void printAvailableResources()
        {
            steps += "\t\t\tCurrently Available Resources\n";
            foreach (Resource item in availableResources)
                steps += "\t\t\t" + item.Name+"\t";
            steps += "\n";
            foreach (Resource item in availableResources)
                steps += "\t\t\t" + item.Number + "\t";

            steps += "\n\n";
        }

        private void printProcessState(int r , int c , int state)
        {
            if (state == 0)
                steps += "  •   " + remainingNeededResources[r, 0].Name + " is Safe and Freed";
            else if (state == 1)
                steps += "  •   " + remainingNeededResources[r, 0].Name + " Blocked on Resource " + remainingNeededResources[r, c].Name;
            else if (state == 2)
                steps += "  •   " + "Checking " +remainingNeededResources[r, 0].Name +" ...";
            else if(state == 3)
                steps += "  •   " + remainingNeededResources[r, 0].Name + " is Still Blocked on Resource " + remainingNeededResources[r, c].Name;

            steps += "\n\n";
        }

        private void printResult(string str ,bool result)
        {
            if (result)
            {
                steps += "  •   " + str + "Safe";
                state = "Safe";
            }
            else
            {
                steps += "  •   " + str + "Not Safe";
                state = "Not Safe";
            }
            steps += "\n\n";
        }
    }
}
