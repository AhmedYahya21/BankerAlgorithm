namespace Banker_Algorithm_Project
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any totalResources being used.
        /// </summary>
        /// <param name="disposing">true if managed totalResources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberOfProcesses_Label = new System.Windows.Forms.Label();
            this.numberOfProcesses_textBox = new System.Windows.Forms.TextBox();
            this.numberOfProcesses_button = new System.Windows.Forms.Button();
            this.resourceName_label = new System.Windows.Forms.Label();
            this.resourceName_textBox = new System.Windows.Forms.TextBox();
            this.addResource_button = new System.Windows.Forms.Button();
            this.totalNumberOfResource_textBox = new System.Windows.Forms.TextBox();
            this.confirm_button = new System.Windows.Forms.Button();
            this.currentAllocatedResources_table = new System.Windows.Forms.DataGridView();
            this.currentAllocatedRescoures_label = new System.Windows.Forms.Label();
            this.totalNumberOfResource_label = new System.Windows.Forms.Label();
            this.confirmTable_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maxNeededResources_table = new System.Windows.Forms.DataGridView();
            this.maxNeededResources_label = new System.Windows.Forms.Label();
            this.totalResources_table = new System.Windows.Forms.DataGridView();
            this.totalResources_label = new System.Windows.Forms.Label();
            this.selectProcess_comboBox = new System.Windows.Forms.ComboBox();
            this.selectResource_comboBox = new System.Windows.Forms.ComboBox();
            this.addNumber_textBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkOrAssume_button = new System.Windows.Forms.Button();
            this.selectProcess_comboboxlabel = new System.Windows.Forms.Label();
            this.selectResource_comboboxlabel = new System.Windows.Forms.Label();
            this.numberOfRequestedResources_label = new System.Windows.Forms.Label();
            this.steps_richTextBox = new System.Windows.Forms.RichTextBox();
            this.steps_label = new System.Windows.Forms.Label();
            this.freeSequence_textBox = new System.Windows.Forms.TextBox();
            this.state_textBox = new System.Windows.Forms.TextBox();
            this.blockedSequence_textBox = new System.Windows.Forms.TextBox();
            this.state_label = new System.Windows.Forms.Label();
            this.freeSequence_label = new System.Windows.Forms.Label();
            this.blockedSequence_label = new System.Windows.Forms.Label();
            this.remainNeededResources_table = new System.Windows.Forms.DataGridView();
            this.remainNeededResources_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.currentAllocatedResources_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNeededResources_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalResources_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainNeededResources_table)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfProcesses_Label
            // 
            this.numberOfProcesses_Label.AutoSize = true;
            this.numberOfProcesses_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfProcesses_Label.Location = new System.Drawing.Point(25, 155);
            this.numberOfProcesses_Label.Name = "numberOfProcesses_Label";
            this.numberOfProcesses_Label.Size = new System.Drawing.Size(255, 25);
            this.numberOfProcesses_Label.TabIndex = 0;
            this.numberOfProcesses_Label.Text = "Enter Number Of Processes";
            // 
            // numberOfProcesses_textBox
            // 
            this.numberOfProcesses_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfProcesses_textBox.Location = new System.Drawing.Point(310, 153);
            this.numberOfProcesses_textBox.Name = "numberOfProcesses_textBox";
            this.numberOfProcesses_textBox.Size = new System.Drawing.Size(174, 27);
            this.numberOfProcesses_textBox.TabIndex = 1;
            // 
            // numberOfProcesses_button
            // 
            this.numberOfProcesses_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfProcesses_button.Location = new System.Drawing.Point(608, 148);
            this.numberOfProcesses_button.Name = "numberOfProcesses_button";
            this.numberOfProcesses_button.Size = new System.Drawing.Size(100, 36);
            this.numberOfProcesses_button.TabIndex = 2;
            this.numberOfProcesses_button.Text = "Next";
            this.numberOfProcesses_button.UseVisualStyleBackColor = true;
            this.numberOfProcesses_button.Click += new System.EventHandler(this.numberOfProcesses_button_Click);
            // 
            // resourceName_label
            // 
            this.resourceName_label.AutoSize = true;
            this.resourceName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceName_label.Location = new System.Drawing.Point(25, 155);
            this.resourceName_label.Name = "resourceName_label";
            this.resourceName_label.Size = new System.Drawing.Size(203, 25);
            this.resourceName_label.TabIndex = 3;
            this.resourceName_label.Text = "Enter Resource Name";
            // 
            // resourceName_textBox
            // 
            this.resourceName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceName_textBox.Location = new System.Drawing.Point(310, 153);
            this.resourceName_textBox.Name = "resourceName_textBox";
            this.resourceName_textBox.Size = new System.Drawing.Size(222, 27);
            this.resourceName_textBox.TabIndex = 4;
            // 
            // addResource_button
            // 
            this.addResource_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addResource_button.Location = new System.Drawing.Point(608, 153);
            this.addResource_button.Name = "addResource_button";
            this.addResource_button.Size = new System.Drawing.Size(100, 88);
            this.addResource_button.TabIndex = 5;
            this.addResource_button.Text = "Add";
            this.addResource_button.UseVisualStyleBackColor = true;
            this.addResource_button.Click += new System.EventHandler(this.addResource_button_Click);
            // 
            // totalNumberOfResource_textBox
            // 
            this.totalNumberOfResource_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNumberOfResource_textBox.Location = new System.Drawing.Point(353, 214);
            this.totalNumberOfResource_textBox.Name = "totalNumberOfResource_textBox";
            this.totalNumberOfResource_textBox.Size = new System.Drawing.Size(179, 27);
            this.totalNumberOfResource_textBox.TabIndex = 9;
            // 
            // confirm_button
            // 
            this.confirm_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_button.Location = new System.Drawing.Point(353, 287);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(355, 53);
            this.confirm_button.TabIndex = 10;
            this.confirm_button.Text = "Confirm All Added Resources";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // currentAllocatedResources_table
            // 
            this.currentAllocatedResources_table.AllowUserToAddRows = false;
            this.currentAllocatedResources_table.AllowUserToDeleteRows = false;
            this.currentAllocatedResources_table.AllowUserToResizeColumns = false;
            this.currentAllocatedResources_table.AllowUserToResizeRows = false;
            this.currentAllocatedResources_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.currentAllocatedResources_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.currentAllocatedResources_table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.currentAllocatedResources_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentAllocatedResources_table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.currentAllocatedResources_table.GridColor = System.Drawing.SystemColors.Control;
            this.currentAllocatedResources_table.Location = new System.Drawing.Point(8, 204);
            this.currentAllocatedResources_table.Name = "currentAllocatedResources_table";
            this.currentAllocatedResources_table.RowHeadersVisible = false;
            this.currentAllocatedResources_table.RowHeadersWidth = 51;
            this.currentAllocatedResources_table.RowTemplate.Height = 24;
            this.currentAllocatedResources_table.ShowEditingIcon = false;
            this.currentAllocatedResources_table.Size = new System.Drawing.Size(700, 375);
            this.currentAllocatedResources_table.TabIndex = 13;
            // 
            // currentAllocatedRescoures_label
            // 
            this.currentAllocatedRescoures_label.AutoSize = true;
            this.currentAllocatedRescoures_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAllocatedRescoures_label.Location = new System.Drawing.Point(234, 179);
            this.currentAllocatedRescoures_label.Name = "currentAllocatedRescoures_label";
            this.currentAllocatedRescoures_label.Size = new System.Drawing.Size(240, 22);
            this.currentAllocatedRescoures_label.TabIndex = 14;
            this.currentAllocatedRescoures_label.Text = "Current Allocated Rescoures";
            // 
            // totalNumberOfResource_label
            // 
            this.totalNumberOfResource_label.AutoSize = true;
            this.totalNumberOfResource_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNumberOfResource_label.Location = new System.Drawing.Point(25, 216);
            this.totalNumberOfResource_label.Name = "totalNumberOfResource_label";
            this.totalNumberOfResource_label.Size = new System.Drawing.Size(290, 25);
            this.totalNumberOfResource_label.TabIndex = 15;
            this.totalNumberOfResource_label.Text = "Enter Total Number of Resource";
            // 
            // confirmTable_button
            // 
            this.confirmTable_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmTable_button.Location = new System.Drawing.Point(373, 589);
            this.confirmTable_button.Name = "confirmTable_button";
            this.confirmTable_button.Size = new System.Drawing.Size(665, 44);
            this.confirmTable_button.TabIndex = 16;
            this.confirmTable_button.Text = "Confirm";
            this.confirmTable_button.UseVisualStyleBackColor = true;
            this.confirmTable_button.Click += new System.EventHandler(this.confirmTable_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Banker Algorithm Project";
            // 
            // maxNeededResources_table
            // 
            this.maxNeededResources_table.AllowUserToAddRows = false;
            this.maxNeededResources_table.AllowUserToDeleteRows = false;
            this.maxNeededResources_table.AllowUserToResizeColumns = false;
            this.maxNeededResources_table.AllowUserToResizeRows = false;
            this.maxNeededResources_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.maxNeededResources_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.maxNeededResources_table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.maxNeededResources_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maxNeededResources_table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.maxNeededResources_table.GridColor = System.Drawing.SystemColors.Control;
            this.maxNeededResources_table.Location = new System.Drawing.Point(716, 204);
            this.maxNeededResources_table.Name = "maxNeededResources_table";
            this.maxNeededResources_table.RowHeadersVisible = false;
            this.maxNeededResources_table.RowHeadersWidth = 51;
            this.maxNeededResources_table.RowTemplate.Height = 24;
            this.maxNeededResources_table.ShowEditingIcon = false;
            this.maxNeededResources_table.Size = new System.Drawing.Size(700, 375);
            this.maxNeededResources_table.TabIndex = 18;
            // 
            // maxNeededResources_label
            // 
            this.maxNeededResources_label.AutoSize = true;
            this.maxNeededResources_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxNeededResources_label.Location = new System.Drawing.Point(918, 179);
            this.maxNeededResources_label.Name = "maxNeededResources_label";
            this.maxNeededResources_label.Size = new System.Drawing.Size(244, 22);
            this.maxNeededResources_label.TabIndex = 19;
            this.maxNeededResources_label.Text = "Maximum Needed Resources";
            // 
            // totalResources_table
            // 
            this.totalResources_table.AllowUserToAddRows = false;
            this.totalResources_table.AllowUserToDeleteRows = false;
            this.totalResources_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.totalResources_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.totalResources_table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.totalResources_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalResources_table.GridColor = System.Drawing.SystemColors.Control;
            this.totalResources_table.Location = new System.Drawing.Point(398, 86);
            this.totalResources_table.Name = "totalResources_table";
            this.totalResources_table.ReadOnly = true;
            this.totalResources_table.RowHeadersVisible = false;
            this.totalResources_table.RowHeadersWidth = 51;
            this.totalResources_table.RowTemplate.Height = 24;
            this.totalResources_table.ShowEditingIcon = false;
            this.totalResources_table.Size = new System.Drawing.Size(608, 61);
            this.totalResources_table.TabIndex = 20;
            // 
            // totalResources_label
            // 
            this.totalResources_label.AutoSize = true;
            this.totalResources_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalResources_label.Location = new System.Drawing.Point(615, 61);
            this.totalResources_label.Name = "totalResources_label";
            this.totalResources_label.Size = new System.Drawing.Size(142, 22);
            this.totalResources_label.TabIndex = 21;
            this.totalResources_label.Text = "Total Resources";
            // 
            // selectProcess_comboBox
            // 
            this.selectProcess_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectProcess_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectProcess_comboBox.FormattingEnabled = true;
            this.selectProcess_comboBox.Location = new System.Drawing.Point(238, 258);
            this.selectProcess_comboBox.Name = "selectProcess_comboBox";
            this.selectProcess_comboBox.Size = new System.Drawing.Size(192, 28);
            this.selectProcess_comboBox.TabIndex = 22;
            // 
            // selectResource_comboBox
            // 
            this.selectResource_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectResource_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectResource_comboBox.FormattingEnabled = true;
            this.selectResource_comboBox.Location = new System.Drawing.Point(238, 302);
            this.selectResource_comboBox.Name = "selectResource_comboBox";
            this.selectResource_comboBox.Size = new System.Drawing.Size(192, 28);
            this.selectResource_comboBox.TabIndex = 23;
            // 
            // addNumber_textBox
            // 
            this.addNumber_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNumber_textBox.Location = new System.Drawing.Point(373, 350);
            this.addNumber_textBox.Name = "addNumber_textBox";
            this.addNumber_textBox.Size = new System.Drawing.Size(57, 27);
            this.addNumber_textBox.TabIndex = 24;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(8, 162);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(450, 29);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Run Banker Algorithm on the Current Conditions";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(8, 212);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(543, 29);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.Text = "Assume a Certain Process Requests a Particular Resource";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkOrAssume_button
            // 
            this.checkOrAssume_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOrAssume_button.Location = new System.Drawing.Point(765, 162);
            this.checkOrAssume_button.Name = "checkOrAssume_button";
            this.checkOrAssume_button.Size = new System.Drawing.Size(158, 79);
            this.checkOrAssume_button.TabIndex = 27;
            this.checkOrAssume_button.Text = "Confirm";
            this.checkOrAssume_button.UseVisualStyleBackColor = true;
            this.checkOrAssume_button.Click += new System.EventHandler(this.checkOrAssume_button_Click);
            // 
            // selectProcess_comboboxlabel
            // 
            this.selectProcess_comboboxlabel.AutoSize = true;
            this.selectProcess_comboboxlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectProcess_comboboxlabel.Location = new System.Drawing.Point(59, 266);
            this.selectProcess_comboboxlabel.Name = "selectProcess_comboboxlabel";
            this.selectProcess_comboboxlabel.Size = new System.Drawing.Size(137, 20);
            this.selectProcess_comboboxlabel.TabIndex = 28;
            this.selectProcess_comboboxlabel.Text = "Select a Process";
            // 
            // selectResource_comboboxlabel
            // 
            this.selectResource_comboboxlabel.AutoSize = true;
            this.selectResource_comboboxlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectResource_comboboxlabel.Location = new System.Drawing.Point(59, 310);
            this.selectResource_comboboxlabel.Name = "selectResource_comboboxlabel";
            this.selectResource_comboboxlabel.Size = new System.Drawing.Size(147, 20);
            this.selectResource_comboboxlabel.TabIndex = 29;
            this.selectResource_comboboxlabel.Text = "Select a Resource";
            // 
            // numberOfRequestedResources_label
            // 
            this.numberOfRequestedResources_label.AutoSize = true;
            this.numberOfRequestedResources_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfRequestedResources_label.Location = new System.Drawing.Point(59, 357);
            this.numberOfRequestedResources_label.Name = "numberOfRequestedResources_label";
            this.numberOfRequestedResources_label.Size = new System.Drawing.Size(262, 20);
            this.numberOfRequestedResources_label.TabIndex = 30;
            this.numberOfRequestedResources_label.Text = "Number Of Requested Resources";
            // 
            // steps_richTextBox
            // 
            this.steps_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steps_richTextBox.Location = new System.Drawing.Point(8, 190);
            this.steps_richTextBox.Name = "steps_richTextBox";
            this.steps_richTextBox.ReadOnly = true;
            this.steps_richTextBox.Size = new System.Drawing.Size(1023, 447);
            this.steps_richTextBox.TabIndex = 31;
            this.steps_richTextBox.Text = "";
            // 
            // steps_label
            // 
            this.steps_label.AutoSize = true;
            this.steps_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steps_label.Location = new System.Drawing.Point(3, 162);
            this.steps_label.Name = "steps_label";
            this.steps_label.Size = new System.Drawing.Size(63, 25);
            this.steps_label.TabIndex = 32;
            this.steps_label.Text = "Steps";
            // 
            // freeSequence_textBox
            // 
            this.freeSequence_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeSequence_textBox.Location = new System.Drawing.Point(298, 73);
            this.freeSequence_textBox.Name = "freeSequence_textBox";
            this.freeSequence_textBox.ReadOnly = true;
            this.freeSequence_textBox.Size = new System.Drawing.Size(297, 28);
            this.freeSequence_textBox.TabIndex = 33;
            // 
            // state_textBox
            // 
            this.state_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state_textBox.Location = new System.Drawing.Point(79, 41);
            this.state_textBox.Name = "state_textBox";
            this.state_textBox.ReadOnly = true;
            this.state_textBox.Size = new System.Drawing.Size(179, 28);
            this.state_textBox.TabIndex = 34;
            // 
            // blockedSequence_textBox
            // 
            this.blockedSequence_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockedSequence_textBox.Location = new System.Drawing.Point(298, 113);
            this.blockedSequence_textBox.Name = "blockedSequence_textBox";
            this.blockedSequence_textBox.ReadOnly = true;
            this.blockedSequence_textBox.Size = new System.Drawing.Size(297, 28);
            this.blockedSequence_textBox.TabIndex = 35;
            // 
            // state_label
            // 
            this.state_label.AutoSize = true;
            this.state_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state_label.Location = new System.Drawing.Point(3, 44);
            this.state_label.Name = "state_label";
            this.state_label.Size = new System.Drawing.Size(58, 25);
            this.state_label.TabIndex = 36;
            this.state_label.Text = "State";
            // 
            // freeSequence_label
            // 
            this.freeSequence_label.AutoSize = true;
            this.freeSequence_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeSequence_label.Location = new System.Drawing.Point(3, 76);
            this.freeSequence_label.Name = "freeSequence_label";
            this.freeSequence_label.Size = new System.Drawing.Size(255, 25);
            this.freeSequence_label.TabIndex = 37;
            this.freeSequence_label.Text = "Freed Processes Sequence";
            // 
            // blockedSequence_label
            // 
            this.blockedSequence_label.AutoSize = true;
            this.blockedSequence_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockedSequence_label.Location = new System.Drawing.Point(3, 116);
            this.blockedSequence_label.Name = "blockedSequence_label";
            this.blockedSequence_label.Size = new System.Drawing.Size(274, 25);
            this.blockedSequence_label.TabIndex = 38;
            this.blockedSequence_label.Text = "Blocked Processes Sequence";
            // 
            // remainNeededResources_table
            // 
            this.remainNeededResources_table.AllowUserToAddRows = false;
            this.remainNeededResources_table.AllowUserToDeleteRows = false;
            this.remainNeededResources_table.AllowUserToResizeColumns = false;
            this.remainNeededResources_table.AllowUserToResizeRows = false;
            this.remainNeededResources_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.remainNeededResources_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.remainNeededResources_table.BackgroundColor = System.Drawing.SystemColors.Control;
            this.remainNeededResources_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.remainNeededResources_table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.remainNeededResources_table.GridColor = System.Drawing.SystemColors.Control;
            this.remainNeededResources_table.Location = new System.Drawing.Point(1047, 190);
            this.remainNeededResources_table.Name = "remainNeededResources_table";
            this.remainNeededResources_table.ReadOnly = true;
            this.remainNeededResources_table.RowHeadersVisible = false;
            this.remainNeededResources_table.RowHeadersWidth = 51;
            this.remainNeededResources_table.RowTemplate.Height = 24;
            this.remainNeededResources_table.ShowEditingIcon = false;
            this.remainNeededResources_table.Size = new System.Drawing.Size(369, 194);
            this.remainNeededResources_table.TabIndex = 39;
            // 
            // remainNeededResources_label
            // 
            this.remainNeededResources_label.AutoSize = true;
            this.remainNeededResources_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainNeededResources_label.Location = new System.Drawing.Point(1112, 164);
            this.remainNeededResources_label.Name = "remainNeededResources_label";
            this.remainNeededResources_label.Size = new System.Drawing.Size(230, 22);
            this.remainNeededResources_label.TabIndex = 40;
            this.remainNeededResources_label.Text = "Remain Needed Resources";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 645);
            this.Controls.Add(this.remainNeededResources_label);
            this.Controls.Add(this.remainNeededResources_table);
            this.Controls.Add(this.blockedSequence_label);
            this.Controls.Add(this.freeSequence_label);
            this.Controls.Add(this.state_label);
            this.Controls.Add(this.blockedSequence_textBox);
            this.Controls.Add(this.state_textBox);
            this.Controls.Add(this.freeSequence_textBox);
            this.Controls.Add(this.steps_label);
            this.Controls.Add(this.steps_richTextBox);
            this.Controls.Add(this.numberOfRequestedResources_label);
            this.Controls.Add(this.selectResource_comboboxlabel);
            this.Controls.Add(this.selectProcess_comboboxlabel);
            this.Controls.Add(this.checkOrAssume_button);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.addNumber_textBox);
            this.Controls.Add(this.selectResource_comboBox);
            this.Controls.Add(this.selectProcess_comboBox);
            this.Controls.Add(this.totalResources_label);
            this.Controls.Add(this.totalResources_table);
            this.Controls.Add(this.maxNeededResources_label);
            this.Controls.Add(this.maxNeededResources_table);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmTable_button);
            this.Controls.Add(this.totalNumberOfResource_label);
            this.Controls.Add(this.currentAllocatedRescoures_label);
            this.Controls.Add(this.currentAllocatedResources_table);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.totalNumberOfResource_textBox);
            this.Controls.Add(this.addResource_button);
            this.Controls.Add(this.resourceName_textBox);
            this.Controls.Add(this.resourceName_label);
            this.Controls.Add(this.numberOfProcesses_button);
            this.Controls.Add(this.numberOfProcesses_textBox);
            this.Controls.Add(this.numberOfProcesses_Label);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.currentAllocatedResources_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNeededResources_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalResources_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainNeededResources_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberOfProcesses_Label;
        private System.Windows.Forms.TextBox numberOfProcesses_textBox;
        private System.Windows.Forms.Button numberOfProcesses_button;
        private System.Windows.Forms.Label resourceName_label;
        private System.Windows.Forms.TextBox resourceName_textBox;
        private System.Windows.Forms.Button addResource_button;
        private System.Windows.Forms.TextBox totalNumberOfResource_textBox;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.DataGridView currentAllocatedResources_table;
        private System.Windows.Forms.Label currentAllocatedRescoures_label;
        private System.Windows.Forms.Label totalNumberOfResource_label;
        private System.Windows.Forms.Button confirmTable_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView maxNeededResources_table;
        private System.Windows.Forms.Label maxNeededResources_label;
        private System.Windows.Forms.DataGridView totalResources_table;
        private System.Windows.Forms.Label totalResources_label;
        private System.Windows.Forms.ComboBox selectProcess_comboBox;
        private System.Windows.Forms.ComboBox selectResource_comboBox;
        private System.Windows.Forms.TextBox addNumber_textBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button checkOrAssume_button;
        private System.Windows.Forms.Label selectProcess_comboboxlabel;
        private System.Windows.Forms.Label selectResource_comboboxlabel;
        private System.Windows.Forms.Label numberOfRequestedResources_label;
        private System.Windows.Forms.RichTextBox steps_richTextBox;
        private System.Windows.Forms.Label steps_label;
        private System.Windows.Forms.TextBox freeSequence_textBox;
        private System.Windows.Forms.TextBox state_textBox;
        private System.Windows.Forms.TextBox blockedSequence_textBox;
        private System.Windows.Forms.Label state_label;
        private System.Windows.Forms.Label freeSequence_label;
        private System.Windows.Forms.Label blockedSequence_label;
        private System.Windows.Forms.DataGridView remainNeededResources_table;
        private System.Windows.Forms.Label remainNeededResources_label;
    }
}

