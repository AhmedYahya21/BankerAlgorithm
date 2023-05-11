using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Banker_Algorithm_Project
{
    public partial class MainForm : Form
    {
        // fields
        public static LinkedList<string> listOfProcesses = new LinkedList<string>();
        public static LinkedList<Resource> listOfResources = new LinkedList<Resource>();
        public static Resource[,] currentAllocated;
        public static Resource[,] maximumNeeded;
        public static Resource[,] remainNeeded;

        public MainForm()
        {
            InitializeComponent();
            // hide unneeded controls for first input
            {
                resourceName_label.Visible = false;
                resourceName_textBox.Visible = false;
                totalNumberOfResource_label.Visible = false;
                totalNumberOfResource_textBox.Visible = false;
                addResource_button.Visible = false;
                confirm_button.Visible = false;
                //
                currentAllocatedRescoures_label.Visible = false;
                currentAllocatedResources_table.Visible = false;
                confirmTable_button.Visible = false;
                //
                maxNeededResources_label.Visible = false;
                maxNeededResources_table.Visible = false;
                //
                totalResources_label.Visible = false;
                totalResources_table.Visible = false;
                //
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkOrAssume_button.Visible = false;
                selectProcess_comboBox.Visible = false;
                selectResource_comboBox.Visible = false;
                addNumber_textBox.Visible = false;
                selectProcess_comboboxlabel.Visible = false;
                selectResource_comboboxlabel.Visible = false;
                numberOfRequestedResources_label.Visible = false;
                //
                steps_label.Visible = false;
                steps_richTextBox.Visible = false;
                state_label.Visible = false;
                state_textBox.Visible = false;
                freeSequence_label.Visible = false;
                freeSequence_textBox.Visible = false;
                blockedSequence_label.Visible = false;
                blockedSequence_textBox.Visible = false;
                remainNeededResources_label.Visible = false;
                remainNeededResources_table.Visible = false;
            }
        }

        private void numberOfProcesses_button_Click(object sender, EventArgs e)
        {
            intializeListOfProcesses();
            // hide unneeded controls for second input
            {
                numberOfProcesses_Label.Visible = false;
                numberOfProcesses_textBox.Visible = false;
                numberOfProcesses_button.Visible = false;
            }
            // show needed controls for third input
            {
                resourceName_label.Visible = true;
                resourceName_textBox.Visible = true;
                totalNumberOfResource_label.Visible = true;
                totalNumberOfResource_textBox.Visible = true;
                addResource_button.Visible = true;
                confirm_button.Visible = true;
            }
        }

        private void addResource_button_Click(object sender, EventArgs e)
        {
            addResourceToListOfResources();
            // clear to take another input
            resourceName_textBox.Clear();
            totalNumberOfResource_textBox.Clear();
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            constructTables();
            //hide unneeded controls for third input
            {
                resourceName_label.Visible = false;
                resourceName_textBox.Visible = false;
                totalNumberOfResource_label.Visible = false;
                totalNumberOfResource_textBox.Visible = false;
                addResource_button.Visible = false;
                confirm_button.Visible = false;
            }
            //show needed controls for third input
            {
                currentAllocatedRescoures_label.Visible = true;
                currentAllocatedResources_table.Visible = true;
                confirmTable_button.Visible = true;
                //show needed controls for third input
                maxNeededResources_label.Visible = true;
                maxNeededResources_table.Visible = true;
                //show needed controls for third input
                totalResources_label.Visible = true;
                totalResources_table.Visible = true;
            }
            
        }

        private void confirmTable_button_Click(object sender, EventArgs e)
        {
            checkTableCellsNonEmptyAndValid();
            intializeArraysFromTables();
            checkcurrentNotExceedsTotal();
            checkcurrentNotExceedsMaximumNeeded();

            // hide unneeded controls for fourth input
            {
                currentAllocatedRescoures_label.Visible = false;
                currentAllocatedResources_table.Visible = false;
                confirmTable_button.Visible = false;
                //hide unneeded controls for fourth input
                maxNeededResources_label.Visible = false;
                maxNeededResources_table.Visible = false;
                //hide unneeded controls for fourth input
                totalResources_label.Visible = false;
                totalResources_table.Visible = false;
            }
            //show needed controls for fourth input
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkOrAssume_button.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                //hide unneeded controls and clear combobox to prevent duplicates
                {
                    selectProcess_comboBox.Visible = false;
                    selectProcess_comboBox.Items.Clear();
                    selectResource_comboBox.Visible = false;
                    selectResource_comboBox.Items.Clear();
                    addNumber_textBox.Visible = false;
                    addNumber_textBox.Clear();
                    selectProcess_comboboxlabel.Visible = false;
                    selectResource_comboboxlabel.Visible = false;
                    numberOfRequestedResources_label.Visible = false;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                intializeComboBox();
                //show needed controls
                {
                    selectProcess_comboBox.Visible = true;
                    selectProcess_comboboxlabel.Visible = true;
                    selectResource_comboboxlabel.Visible = true;
                    numberOfRequestedResources_label.Visible = true;
                    selectResource_comboBox.Visible = true;
                    addNumber_textBox.Visible = true;
                }
            }
            else
            {
                //hide unneeded controls and clear combobox to prevent duplicates
                {
                    selectProcess_comboBox.Visible = false;
                    selectProcess_comboBox.Items.Clear();
                    selectResource_comboBox.Visible = false;
                    selectResource_comboBox.Items.Clear();
                    addNumber_textBox.Visible = false;
                    addNumber_textBox.Clear();
                    selectProcess_comboboxlabel.Visible = false;
                    selectResource_comboboxlabel.Visible = false;
                    numberOfRequestedResources_label.Visible = false;
                }
            }
        }

        private void checkOrAssume_button_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked) 
            {
                BankerAlgorithm.runAlgorithmOnCurrentConditions();
            }
            else if(checkBox2.Checked)
            {
                string p = "";
                string r = "";
                int n = 0;

                checkUserAssumptionIsValid(ref p ,ref r ,ref n);
                BankerAlgorithm.assumeProcessRequestedResource(p , r, n);
            }
            else
            {
                MessageBox.Show("Please, Select an Option");
                return;
            }

            //hide unneeded controls
            {
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkOrAssume_button.Visible = false;

                selectProcess_comboBox.Visible = false;
                selectProcess_comboBox.Items.Clear();
                selectResource_comboBox.Visible = false;
                selectResource_comboBox.Items.Clear();
                addNumber_textBox.Visible = false;
                addNumber_textBox.Clear();
                selectProcess_comboboxlabel.Visible = false;
                selectResource_comboboxlabel.Visible = false;
                numberOfRequestedResources_label.Visible = false;
            }

            showSteps();
        }

        // helper functions 
        // these functions used to read user input and to validate user input

        void intializeListOfProcesses()
        {
            //check number of processes is a Number and Valid  (int && size > 0), if not return error message to user
            int size = 0;
            try
            {
                size = int.Parse(numberOfProcesses_textBox.Text);
                if (size <= 0)
                {
                    MessageBox.Show("Please, Enter a Valid Number");
                    numberOfProcesses_textBox.Clear();
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please, Enter a Number");
                numberOfProcesses_textBox.Clear();
                return;
            }

            // make list of processes from p1 to pn
            for (int i = 0; i < size; i++)
            {
                listOfProcesses.AddLast("P" + (i + 1));
            }
        }

        void addResourceToListOfResources()
        {
            string name = null;
            int totalNumber = 0;

            //check if resource name is valid name (not a number && not an empty string), if not return error message to user
            if (string.IsNullOrEmpty(resourceName_textBox.Text) || string.IsNullOrWhiteSpace(resourceName_textBox.Text) || Double.TryParse(resourceName_textBox.Text, out _))
            {
                MessageBox.Show("Please, Enter a Valid Resource Name");
                resourceName_textBox.Clear();
                return;
            }
            else
                name = resourceName_textBox.Text;

            //check if the total number of a resource is a Number and Valid  (int && size > 0), if not return error message to user
            try
            {
                totalNumber = int.Parse(totalNumberOfResource_textBox.Text);
                if (totalNumber < 0)
                {
                    MessageBox.Show("Please, Enter a Valid Number");
                    totalNumberOfResource_textBox.Clear();
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please, Enter a Number");
                totalNumberOfResource_textBox.Clear();
                return;
            }

            //check if there is a resource with the same name (duplicate), if not return error message to user
            foreach (Resource item in listOfResources)
            {
                if (item.Name.Equals(name))
                {
                    MessageBox.Show("You Have Already Added a Resource With The Same Name!");
                    resourceName_textBox.Clear();
                    totalNumberOfResource_textBox.Clear();
                    return;
                }
            }

            // add the resource to the list of resources
            listOfResources.AddLast(new Resource(name, totalNumber));
        }

        void constructTables()
        {
            // check if there is at least one resource added, if not return error message to user
            if (listOfResources.Count == 0)
            {
                MessageBox.Show("Please, Add at Least One Resource");
                resourceName_textBox.Clear();
                totalNumberOfResource_textBox.Clear();
                return;
            }

            //construct tables needed for third input (total resources , current allocated resources , maximum needed resources)

            //construct the current Allocated Resources table 
            {
                currentAllocatedResources_table.Columns.Add("newColumnName", "    ");
                currentAllocatedResources_table.Columns[0].ReadOnly = true;

                foreach (Resource item in listOfResources)
                    currentAllocatedResources_table.Columns.Add("newColumnName", item.Name);
                foreach (string str in listOfProcesses)
                    currentAllocatedResources_table.Rows.Add(str);
            }
            //construct the maximum Needed Resources table
            {
                maxNeededResources_table.Columns.Add("newColumnName", "    ");
                maxNeededResources_table.Columns[0].ReadOnly = true;

                foreach (Resource item in listOfResources)
                    maxNeededResources_table.Columns.Add("newColumnName", item.Name);
                foreach (string str in listOfProcesses)
                    maxNeededResources_table.Rows.Add(str);
            }
            //construct the total Resources table
            {
                totalResources_table.Columns.Add("newColumnName", "Name");
                totalResources_table.Rows.Add("Total Number");
                totalResources_table.Columns[0].ReadOnly = true;

                foreach (Resource item in listOfResources)
                    totalResources_table.Columns.Add("newColumnName", item.Name);
                for (int i = 0; i < listOfResources.Count; i++)
                    totalResources_table.Rows[0].Cells[i + 1].Value = listOfResources.ElementAt(i).Number;
            }
        }

        void checkTableCellsNonEmptyAndValid()
        {
            // check cells are not empty and contain valid numbers in both tables (current allocated resources , maximum needed resources)
            for (int i = 1; i < currentAllocatedResources_table.Columns.Count; i++)
            {
                for (int j = 0; j < currentAllocatedResources_table.Rows.Count; j++)
                {
                    try
                    {
                        if (currentAllocatedResources_table.Rows[j].Cells[i].Value == null || int.Parse(currentAllocatedResources_table.Rows[j].Cells[i].Value.ToString()) < 0)
                        {
                            MessageBox.Show("Please, Fill All Cells in The Current Allocated Table With Valid Numbers");
                            return;
                        }

                        if (maxNeededResources_table.Rows[j].Cells[i].Value == null || int.Parse(maxNeededResources_table.Rows[j].Cells[i].Value.ToString()) < 0)
                        {
                            MessageBox.Show("Please, Fill All Cells in The Maximum Needed Resources Table With Valid Numbers");
                            return;
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Please, Be Sure That All Cells Holds Valid Numbers");
                        return;
                    }
                }
            }
        }

        void intializeArraysFromTables()
        {
            // define 2d arrays size
            currentAllocated = new Resource[currentAllocatedResources_table.RowCount, currentAllocatedResources_table.ColumnCount];
            maximumNeeded = new Resource[maxNeededResources_table.RowCount, maxNeededResources_table.ColumnCount];
            remainNeeded = new Resource[currentAllocatedResources_table.RowCount, currentAllocatedResources_table.ColumnCount]; // needed later in showSteps()

            // copy process cloumn from table to column[0] in the both arrays (p1,p2,...,pn)
            for (int i = 0; i < currentAllocatedResources_table.Rows.Count; i++)
            {
                currentAllocated[i, 0] = new Resource(currentAllocatedResources_table.Rows[i].Cells[0].Value.ToString(), 0);
                maximumNeeded[i, 0] = new Resource(maxNeededResources_table.Rows[i].Cells[0].Value.ToString(), 0);
            }

            // copy cells data from tables to the both arrays 
            for (int i = 1; i < currentAllocatedResources_table.Columns.Count; i++)
            {
                for (int j = 0; j < currentAllocatedResources_table.Rows.Count; j++)
                {
                    currentAllocated[j, i] = new Resource(currentAllocatedResources_table.Columns[i].HeaderText,
                                        int.Parse(currentAllocatedResources_table.Rows[j].Cells[i].Value.ToString()));

                    maximumNeeded[j, i] = new Resource(maxNeededResources_table.Columns[i].HeaderText,
                                              int.Parse(maxNeededResources_table.Rows[j].Cells[i].Value.ToString()));
                }
            }
        }

        void checkcurrentNotExceedsTotal()
        {
            // check if current allocated table doesn't exceed total number of resources, if not return error message to user
            //  total - current allocation must be >= 0
            int currentRequiredResources = 0;

            for (int i = 1; i < currentAllocatedResources_table.Columns.Count; i++)
            {
                for (int j = 0; j < currentAllocatedResources_table.Rows.Count; j++)
                {
                    currentRequiredResources += currentAllocated[j, i].Number;
                }

                if (listOfResources.ElementAt(i - 1).Number - currentRequiredResources < 0)
                {
                    MessageBox.Show("Resource " + listOfResources.ElementAt(i - 1).Name + " in The Current Allocated Resources Exceeded It's Total Number Of Resources");
                    return;
                }
                currentRequiredResources = 0;
            }
        }

        void checkcurrentNotExceedsMaximumNeeded()
        {
            // check if current allocated resources table doesn't exceed maximum needed resources table, if not return error message to user
            //maximumNeeded - currentAllocated >= 0

            int currentRequiredResources = 0;
            int maxRequiredResources = 0;

            for (int i = 1; i < currentAllocatedResources_table.Columns.Count; i++)
            {
                for (int j = 0; j < currentAllocatedResources_table.Rows.Count; j++)
                {
                    currentRequiredResources += currentAllocated[j, i].Number;
                    maxRequiredResources += maximumNeeded[j, i].Number;
                }
                if (maxRequiredResources - currentRequiredResources < 0)
                {
                    MessageBox.Show("Resource " + listOfResources.ElementAt(i - 1).Name + " in The Current Allocated Resources Exceeded The Maximum Needed Of Resources");
                    return;
                }
                currentRequiredResources = 0;
                maxRequiredResources = 0;
            }
        }

        void intializeComboBox()
        {
            // check that the added process is not in the ComboBox to prevent duplicates, then add process to comboBox
            int flag;
            foreach (string p in listOfProcesses)
            {
                flag = 0;
                foreach (var item in selectProcess_comboBox.Items)
                {
                    if (item.ToString().Equals(p))
                        flag = 1;
                }

                if (flag == 0)
                    selectProcess_comboBox.Items.Add(p);
            }

            // check that the added resource is not in the ComboBox to prevent duplicates, then add resource to comboBox
            foreach (Resource r in listOfResources)
            {
                flag = 0;
                foreach (var item in selectResource_comboBox.Items)
                {
                    if (item.ToString().Equals(r))
                        flag = 1;
                }
                if (flag == 0)
                    selectResource_comboBox.Items.Add(r.Name);
            }
        }

        void checkUserAssumptionIsValid(ref string p, ref string r, ref int n)
        {
            p = selectProcess_comboBox.Text.ToString();
            r = selectResource_comboBox.Text.ToString();

            // check if user has selected a process and a resource from combobox, if not return error message to user
            if (string.IsNullOrEmpty(p) || string.IsNullOrWhiteSpace(p))
            {
                MessageBox.Show("Please, Select a Process");
                return;
            }
            if (string.IsNullOrEmpty(r) || string.IsNullOrWhiteSpace(r))
            {
                MessageBox.Show("Please, Select a Resource");
                return;
            }
            try
            {
                // check if number of requested resources is a Number and Valid  (int && size >= 0), if not return error message to user
                n = int.Parse(addNumber_textBox.Text);
                if (n < 0)
                {
                    MessageBox.Show("Please, Enter a Valid Number");
                    addNumber_textBox.Clear();
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please, Enter a Number");
                addNumber_textBox.Clear();
                return;
            }

            // check if current > total listOfResources ?
            int current = 0;
            int max = 0;
            for (int i = 1; i < currentAllocatedResources_table.Columns.Count; i++)
            {
                for (int j = 0; j < currentAllocatedResources_table.Rows.Count; j++)
                {
                    if (currentAllocated[j, i].Name.Equals(r))
                    {
                        current += currentAllocated[j, i].Number;
                        max += maximumNeeded[j, i].Number;
                    }

                }
            }
            foreach (Resource item in listOfResources)
            {
                if (item.Name.Equals(r))
                {
                    if (current + n > item.Number)
                    {
                        MessageBox.Show("Can't Apply The Requested Resources as Current Allocated Resources Will Be Greater Than The Total Number of Resources");
                        addNumber_textBox.Clear();
                        return;
                    }
                    if (current + n > max)
                    {
                        MessageBox.Show("Can't Apply The Requested Resources as Current Allocated Resources Will Be Greater Than The Maximum Needed Resources");
                        addNumber_textBox.Clear();
                        return;
                    }
                }
            }
        }

        void showSteps()
        {
            if (BankerAlgorithm.state == "Safe")
            {
                state_label.Visible = true;
                state_textBox.Visible = true;
                freeSequence_label.Visible = true;
                freeSequence_textBox.Visible = true;
                state_textBox.Text = BankerAlgorithm.state;
                freeSequence_textBox.Text = BankerAlgorithm.freedSequence;
            }
            else
            {
                state_label.Visible = true;
                state_textBox.Visible = true;
                freeSequence_label.Visible = true;
                freeSequence_textBox.Visible = true;
                blockedSequence_label.Visible = true;
                blockedSequence_textBox.Visible = true;
                state_textBox.Text = BankerAlgorithm.state;
                if (BankerAlgorithm.freedSequence != "")
                    freeSequence_textBox.Text = BankerAlgorithm.freedSequence;

                blockedSequence_textBox.Text = BankerAlgorithm.blockedSequence;
            }

            //construct remain needed Resources table 
            {
                remainNeededResources_table.Columns.Add("newColumnName", "    ");
                remainNeededResources_table.Columns[0].ReadOnly = true;

                foreach (Resource item in listOfResources)
                    remainNeededResources_table.Columns.Add("newColumnName", item.Name);

                foreach (string str in listOfProcesses)
                    remainNeededResources_table.Rows.Add(str);
            }

            for (int i = 1; i < remainNeededResources_table.Columns.Count; i++)
            {
                for (int j = 0; j < remainNeededResources_table.Rows.Count; j++)
                {
                    remainNeededResources_table.Rows[j].Cells[i].Value = remainNeeded[j, i].Number;
                }
            }

            remainNeededResources_label.Visible = true;
            remainNeededResources_table.Visible = true;
            steps_label.Visible = true;
            steps_richTextBox.Visible = true;
            steps_richTextBox.Text = BankerAlgorithm.steps;
        }
    }
}
