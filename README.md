# Banker Algorithm Project

The solution has a single windows form and a single class:
- MainForm
- BankerAlgorithm

### MainForm

The MainForm contains all the GUI controls needed to take user input. First it takes the number of processes, followed by the resource name and its total number (until the user adds all the needed resources), and then the current allocated resources and maximum needed resources.
 
Note: that the available resources are calculated from total resources minus current allocated resources. Also note that the current allocated resources must be smaller than or equal to the total resources and the maximum needed resources.

After taking user input, the MainForm prompts the user to either check all of the current processes or a certain process that has requested a particular resource. Depending on the user input, it calls one of the two functions:

- `runAlgorithmOnCurrentConditions()`
- `assumeProcessRequestedResource(string p, string r, int n)`

After that, the MainForm shows the state and the steps.
Note: the MainForm contains functions that check if user input is valid or not. For example, it checks for negative numbers, duplicate resource names, empty cells, or cells with invalid data. It also checks that current allocated resources must be smaller or equal to the total resources and the maximum needed resources.

### BankerAlgorithm class

If the user chooses to run the algorithm on current conditions, `runAlgorithmOnCurrentConditions()` is called, which in turn calls the following five functions:

- `intializeFields()`: Used to initialize the declared fields with user input from the MainForm. The result is a 1D array of total resources and a 2D array of current allocated resources and maximum needed resources.

- `calculateAvailableResources()`: Used to calculate the available resources (total resources minus current allocated resources) and store it in a 1D array (available resources).

- `calculateRemainingResources()`: Used to calculate the remaining needed resources (maximum needed resources minus current allocated resources) and store it in a 2D array (remaining needed resources).

- `checkAlgorithm()`: Used to run the algorithm after all needed fields have been defined. It has an enum flag {noChange, freedProcess, blockedProcess}. The flag is initially set to `noChange`, and then a while loop iterates through each process and does the following:
	- Check if the available resources are greater than the remaining resources. 
	    - If true , call function `free()` to free the process.
	    - Otherwise, call function `block()` to block the process.
	
	- Check if `(flag == flag.noChange && listOfFreedProcesses.count == numberOfInputProcesses.count)`, return true.
	- Otherwise, if `(flag == flag.noChange && listoFBlockedProcesses.count != 0)`, return false.
	- Otherwise, loop again.
	     
- `printResult()`: Used to print the result.

#### Helper Functions
- `free() :` 
    - Add the resources held by the freed process to available resources.
    - If the process is in the list of blocked processes, it is removed. Then, it is added to the list of freed processes.
     - The flag is set to `freedProcess`.

- `block():` 
    - Checks if the process is blocked before. If so, the flag is set to `noChange`.
    - Otherwise, the process is added to the list of blocked processes.
    - The flag is set to `blockedProcess`.
---
If the user chooses to run the algorithm on a certain process that has requested a particular resource, `assumeProcessRequestedResource()` is called. This function calls an intermediate function then it calls runAlgorithmOnCurrentConditions() :

- `prepareForAssumption(string p, string r, int n)`: is the intermediate function, that is used to add the number of resources requested by the selected process to the current allocated resources. It takes process name, resource name, and number as inputs.
