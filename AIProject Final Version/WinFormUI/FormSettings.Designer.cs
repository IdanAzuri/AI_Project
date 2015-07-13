namespace WinFormUI
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.labelHeuristics = new System.Windows.Forms.Label();
            this.labelConstraints = new System.Windows.Forms.Label();
            this.comboBox2DaysInARow = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOneDayWeekend = new System.Windows.Forms.ComboBox();
            this.comboBoxConflictWorker1 = new System.Windows.Forms.ComboBox();
            this.comboBoxConflictWorker2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelConflictConstraint = new System.Windows.Forms.Label();
            this.labelMinShifts = new System.Windows.Forms.Label();
            this.panelConstraints = new System.Windows.Forms.Panel();
            this.checkBox2DaysInRow = new System.Windows.Forms.CheckBox();
            this.checkBoxWeekendConstraint = new System.Windows.Forms.CheckBox();
            this.checkBoxConflictConstraint = new System.Windows.Forms.CheckBox();
            this.checkBoxProficiency = new System.Windows.Forms.CheckBox();
            this.checkBoxNightOrFriday = new System.Windows.Forms.CheckBox();
            this.checkBoxNightAndDay = new System.Windows.Forms.CheckBox();
            this.checkBoxOneManager = new System.Windows.Forms.CheckBox();
            this.labelProfecincyConstraint = new System.Windows.Forms.Label();
            this.labelNightOrFriday = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelNightAndDay = new System.Windows.Forms.Label();
            this.labelOneManagerConstraint = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonMoreConstraints = new System.Windows.Forms.Button();
            this.panelHeuristics = new System.Windows.Forms.Panel();
            this.labelMoveSelectionHeuristic = new System.Windows.Forms.Label();
            this.labelVariableHeuristic = new System.Windows.Forms.Label();
            this.comboBoxVariableHeuristic = new System.Windows.Forms.ComboBox();
            this.labelChooseValueHeuristic = new System.Windows.Forms.Label();
            this.comboBoxValueHeuristic = new System.Windows.Forms.ComboBox();
            this.labelChooseAlgorithm = new System.Windows.Forms.Label();
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxMoveSelection = new System.Windows.Forms.ComboBox();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.labelSettings = new System.Windows.Forms.Label();
            this.panelShifts = new System.Windows.Forms.Panel();
            this.buttonSaveShiftChanges = new System.Windows.Forms.Button();
            this.textBoxMaxCapacitiy = new System.Windows.Forms.TextBox();
            this.labelMinCapacitiy = new System.Windows.Forms.Label();
            this.textBoxMinCapacitiy = new System.Windows.Forms.TextBox();
            this.labelShifts = new System.Windows.Forms.Label();
            this.labelMaxCapacitiy = new System.Windows.Forms.Label();
            this.labelChooseShift = new System.Windows.Forms.Label();
            this.comboBoxShifts = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSaveEmployeeChanges = new System.Windows.Forms.Button();
            this.textBoxEmpMinAvailability = new System.Windows.Forms.TextBox();
            this.textBoxEmpMaxAvailability = new System.Windows.Forms.TextBox();
            this.labelMinAvailability = new System.Windows.Forms.Label();
            this.labelEmployees = new System.Windows.Forms.Label();
            this.labelMaxAvailability = new System.Windows.Forms.Label();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.comboBoxEmployeeName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLimitTime = new System.Windows.Forms.TextBox();
            this.labelLimitTime = new System.Windows.Forms.Label();
            this.labelProbability = new System.Windows.Forms.Label();
            this.comboBoxProbability = new System.Windows.Forms.ComboBox();
            this.panelConstraints.SuspendLayout();
            this.panelHeuristics.SuspendLayout();
            this.panelShifts.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeuristics
            // 
            this.labelHeuristics.AutoSize = true;
            this.labelHeuristics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHeuristics.Location = new System.Drawing.Point(1, 0);
            this.labelHeuristics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeuristics.Name = "labelHeuristics";
            this.labelHeuristics.Size = new System.Drawing.Size(92, 24);
            this.labelHeuristics.TabIndex = 0;
            this.labelHeuristics.Text = "Heuristics";
            // 
            // labelConstraints
            // 
            this.labelConstraints.AutoSize = true;
            this.labelConstraints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelConstraints.Location = new System.Drawing.Point(3, 0);
            this.labelConstraints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConstraints.Name = "labelConstraints";
            this.labelConstraints.Size = new System.Drawing.Size(102, 24);
            this.labelConstraints.TabIndex = 1;
            this.labelConstraints.Text = "Constraints";
            // 
            // comboBox2DaysInARow
            // 
            this.comboBox2DaysInARow.DisplayMember = "1";
            this.comboBox2DaysInARow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox2DaysInARow.FormattingEnabled = true;
            this.comboBox2DaysInARow.Location = new System.Drawing.Point(316, 150);
            this.comboBox2DaysInARow.Name = "comboBox2DaysInARow";
            this.comboBox2DaysInARow.Size = new System.Drawing.Size(182, 28);
            this.comboBox2DaysInARow.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(3, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Can\'t work 2 days in a row";
            // 
            // comboBoxOneDayWeekend
            // 
            this.comboBoxOneDayWeekend.DisplayMember = "1";
            this.comboBoxOneDayWeekend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxOneDayWeekend.FormattingEnabled = true;
            this.comboBoxOneDayWeekend.Location = new System.Drawing.Point(316, 101);
            this.comboBoxOneDayWeekend.Name = "comboBoxOneDayWeekend";
            this.comboBoxOneDayWeekend.Size = new System.Drawing.Size(182, 28);
            this.comboBoxOneDayWeekend.TabIndex = 27;
            // 
            // comboBoxConflictWorker1
            // 
            this.comboBoxConflictWorker1.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.comboBoxConflictWorker1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxConflictWorker1.DisplayMember = "1";
            this.comboBoxConflictWorker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxConflictWorker1.FormattingEnabled = true;
            this.comboBoxConflictWorker1.Location = new System.Drawing.Point(316, 29);
            this.comboBoxConflictWorker1.Name = "comboBoxConflictWorker1";
            this.comboBoxConflictWorker1.Size = new System.Drawing.Size(182, 28);
            this.comboBoxConflictWorker1.TabIndex = 26;
            this.comboBoxConflictWorker1.SelectedIndexChanged += new System.EventHandler(this.comboBoxConflictWorker1_SelectedIndexChanged);
            // 
            // comboBoxConflictWorker2
            // 
            this.comboBoxConflictWorker2.DisplayMember = "1";
            this.comboBoxConflictWorker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxConflictWorker2.FormattingEnabled = true;
            this.comboBoxConflictWorker2.Location = new System.Drawing.Point(316, 57);
            this.comboBoxConflictWorker2.Name = "comboBoxConflictWorker2";
            this.comboBoxConflictWorker2.Size = new System.Drawing.Size(182, 28);
            this.comboBoxConflictWorker2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(81, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 24;
            // 
            // labelConflictConstraint
            // 
            this.labelConflictConstraint.AutoSize = true;
            this.labelConflictConstraint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelConflictConstraint.Location = new System.Drawing.Point(3, 39);
            this.labelConflictConstraint.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelConflictConstraint.Name = "labelConflictConstraint";
            this.labelConflictConstraint.Size = new System.Drawing.Size(195, 40);
            this.labelConflictConstraint.TabIndex = 23;
            this.labelConflictConstraint.Text = "Conflict workers constraint\r\n(can\'t work together)";
            // 
            // labelMinShifts
            // 
            this.labelMinShifts.AutoSize = true;
            this.labelMinShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMinShifts.Location = new System.Drawing.Point(3, 104);
            this.labelMinShifts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMinShifts.Name = "labelMinShifts";
            this.labelMinShifts.Size = new System.Drawing.Size(251, 20);
            this.labelMinShifts.TabIndex = 22;
            this.labelMinShifts.Text = "Can work only one day in weekend";
            // 
            // panelConstraints
            // 
            this.panelConstraints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelConstraints.Controls.Add(this.checkBox2DaysInRow);
            this.panelConstraints.Controls.Add(this.checkBoxWeekendConstraint);
            this.panelConstraints.Controls.Add(this.checkBoxConflictConstraint);
            this.panelConstraints.Controls.Add(this.checkBoxProficiency);
            this.panelConstraints.Controls.Add(this.checkBoxNightOrFriday);
            this.panelConstraints.Controls.Add(this.checkBoxNightAndDay);
            this.panelConstraints.Controls.Add(this.checkBoxOneManager);
            this.panelConstraints.Controls.Add(this.labelProfecincyConstraint);
            this.panelConstraints.Controls.Add(this.labelNightOrFriday);
            this.panelConstraints.Controls.Add(this.label11);
            this.panelConstraints.Controls.Add(this.labelNightAndDay);
            this.panelConstraints.Controls.Add(this.labelOneManagerConstraint);
            this.panelConstraints.Controls.Add(this.label5);
            this.panelConstraints.Controls.Add(this.buttonMoreConstraints);
            this.panelConstraints.Controls.Add(this.label4);
            this.panelConstraints.Controls.Add(this.comboBox2DaysInARow);
            this.panelConstraints.Controls.Add(this.labelConstraints);
            this.panelConstraints.Controls.Add(this.labelMinShifts);
            this.panelConstraints.Controls.Add(this.comboBoxOneDayWeekend);
            this.panelConstraints.Controls.Add(this.labelConflictConstraint);
            this.panelConstraints.Controls.Add(this.comboBoxConflictWorker1);
            this.panelConstraints.Controls.Add(this.label2);
            this.panelConstraints.Controls.Add(this.comboBoxConflictWorker2);
            this.panelConstraints.Location = new System.Drawing.Point(24, 52);
            this.panelConstraints.Name = "panelConstraints";
            this.panelConstraints.Size = new System.Drawing.Size(517, 234);
            this.panelConstraints.TabIndex = 30;
            // 
            // checkBox2DaysInRow
            // 
            this.checkBox2DaysInRow.AutoSize = true;
            this.checkBox2DaysInRow.Checked = true;
            this.checkBox2DaysInRow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2DaysInRow.Location = new System.Drawing.Point(262, 154);
            this.checkBox2DaysInRow.Name = "checkBox2DaysInRow";
            this.checkBox2DaysInRow.Size = new System.Drawing.Size(51, 22);
            this.checkBox2DaysInRow.TabIndex = 53;
            this.checkBox2DaysInRow.Text = "Yes";
            this.checkBox2DaysInRow.UseVisualStyleBackColor = true;
            // 
            // checkBoxWeekendConstraint
            // 
            this.checkBoxWeekendConstraint.AutoSize = true;
            this.checkBoxWeekendConstraint.Checked = true;
            this.checkBoxWeekendConstraint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWeekendConstraint.Location = new System.Drawing.Point(262, 101);
            this.checkBoxWeekendConstraint.Name = "checkBoxWeekendConstraint";
            this.checkBoxWeekendConstraint.Size = new System.Drawing.Size(51, 22);
            this.checkBoxWeekendConstraint.TabIndex = 52;
            this.checkBoxWeekendConstraint.Text = "Yes";
            this.checkBoxWeekendConstraint.UseVisualStyleBackColor = true;
            // 
            // checkBoxConflictConstraint
            // 
            this.checkBoxConflictConstraint.AutoSize = true;
            this.checkBoxConflictConstraint.Checked = true;
            this.checkBoxConflictConstraint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxConflictConstraint.Location = new System.Drawing.Point(262, 37);
            this.checkBoxConflictConstraint.Name = "checkBoxConflictConstraint";
            this.checkBoxConflictConstraint.Size = new System.Drawing.Size(51, 22);
            this.checkBoxConflictConstraint.TabIndex = 51;
            this.checkBoxConflictConstraint.Text = "Yes";
            this.checkBoxConflictConstraint.UseVisualStyleBackColor = true;
            // 
            // checkBoxProficiency
            // 
            this.checkBoxProficiency.AutoSize = true;
            this.checkBoxProficiency.Checked = true;
            this.checkBoxProficiency.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxProficiency.Location = new System.Drawing.Point(368, 377);
            this.checkBoxProficiency.Name = "checkBoxProficiency";
            this.checkBoxProficiency.Size = new System.Drawing.Size(51, 22);
            this.checkBoxProficiency.TabIndex = 50;
            this.checkBoxProficiency.Text = "Yes";
            this.checkBoxProficiency.UseVisualStyleBackColor = true;
            // 
            // checkBoxNightOrFriday
            // 
            this.checkBoxNightOrFriday.AutoSize = true;
            this.checkBoxNightOrFriday.Checked = true;
            this.checkBoxNightOrFriday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNightOrFriday.Location = new System.Drawing.Point(368, 329);
            this.checkBoxNightOrFriday.Name = "checkBoxNightOrFriday";
            this.checkBoxNightOrFriday.Size = new System.Drawing.Size(51, 22);
            this.checkBoxNightOrFriday.TabIndex = 49;
            this.checkBoxNightOrFriday.Text = "Yes";
            this.checkBoxNightOrFriday.UseVisualStyleBackColor = true;
            // 
            // checkBoxNightAndDay
            // 
            this.checkBoxNightAndDay.AutoSize = true;
            this.checkBoxNightAndDay.Checked = true;
            this.checkBoxNightAndDay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNightAndDay.Location = new System.Drawing.Point(368, 281);
            this.checkBoxNightAndDay.Name = "checkBoxNightAndDay";
            this.checkBoxNightAndDay.Size = new System.Drawing.Size(51, 22);
            this.checkBoxNightAndDay.TabIndex = 48;
            this.checkBoxNightAndDay.Text = "Yes";
            this.checkBoxNightAndDay.UseVisualStyleBackColor = true;
            // 
            // checkBoxOneManager
            // 
            this.checkBoxOneManager.AutoSize = true;
            this.checkBoxOneManager.Checked = true;
            this.checkBoxOneManager.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOneManager.Location = new System.Drawing.Point(368, 233);
            this.checkBoxOneManager.Name = "checkBoxOneManager";
            this.checkBoxOneManager.Size = new System.Drawing.Size(51, 22);
            this.checkBoxOneManager.TabIndex = 46;
            this.checkBoxOneManager.Text = "Yes";
            this.checkBoxOneManager.UseVisualStyleBackColor = true;
            // 
            // labelProfecincyConstraint
            // 
            this.labelProfecincyConstraint.AutoSize = true;
            this.labelProfecincyConstraint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelProfecincyConstraint.Location = new System.Drawing.Point(3, 377);
            this.labelProfecincyConstraint.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelProfecincyConstraint.Name = "labelProfecincyConstraint";
            this.labelProfecincyConstraint.Size = new System.Drawing.Size(345, 20);
            this.labelProfecincyConstraint.TabIndex = 45;
            this.labelProfecincyConstraint.Text = "All shifts include at least one of each proficiency";
            // 
            // labelNightOrFriday
            // 
            this.labelNightOrFriday.AutoSize = true;
            this.labelNightOrFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNightOrFriday.Location = new System.Drawing.Point(3, 329);
            this.labelNightOrFriday.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNightOrFriday.Name = "labelNightOrFriday";
            this.labelNightOrFriday.Size = new System.Drawing.Size(338, 20);
            this.labelNightOrFriday.TabIndex = 42;
            this.labelNightOrFriday.Text = "If worked more than 2 night won\'t work in friday";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(81, 354);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 43;
            // 
            // labelNightAndDay
            // 
            this.labelNightAndDay.AutoSize = true;
            this.labelNightAndDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNightAndDay.Location = new System.Drawing.Point(3, 281);
            this.labelNightAndDay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNightAndDay.Name = "labelNightAndDay";
            this.labelNightAndDay.Size = new System.Drawing.Size(354, 20);
            this.labelNightAndDay.TabIndex = 40;
            this.labelNightAndDay.Text = "If worked night shift won\'t work next morning shift";
            // 
            // labelOneManagerConstraint
            // 
            this.labelOneManagerConstraint.AutoSize = true;
            this.labelOneManagerConstraint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelOneManagerConstraint.Location = new System.Drawing.Point(3, 233);
            this.labelOneManagerConstraint.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelOneManagerConstraint.Name = "labelOneManagerConstraint";
            this.labelOneManagerConstraint.Size = new System.Drawing.Size(201, 20);
            this.labelOneManagerConstraint.TabIndex = 37;
            this.labelOneManagerConstraint.Text = "Only one manager in a shift";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(81, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 38;
            // 
            // buttonMoreConstraints
            // 
            this.buttonMoreConstraints.Location = new System.Drawing.Point(337, 196);
            this.buttonMoreConstraints.Name = "buttonMoreConstraints";
            this.buttonMoreConstraints.Size = new System.Drawing.Size(173, 31);
            this.buttonMoreConstraints.TabIndex = 36;
            this.buttonMoreConstraints.Text = "MoreConsrtraints";
            this.buttonMoreConstraints.UseVisualStyleBackColor = true;
            this.buttonMoreConstraints.Click += new System.EventHandler(this.buttonMoreConstraints_Click);
            // 
            // panelHeuristics
            // 
            this.panelHeuristics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHeuristics.Controls.Add(this.labelMoveSelectionHeuristic);
            this.panelHeuristics.Controls.Add(this.labelVariableHeuristic);
            this.panelHeuristics.Controls.Add(this.comboBoxVariableHeuristic);
            this.panelHeuristics.Controls.Add(this.labelHeuristics);
            this.panelHeuristics.Controls.Add(this.labelChooseValueHeuristic);
            this.panelHeuristics.Controls.Add(this.comboBoxValueHeuristic);
            this.panelHeuristics.Controls.Add(this.labelChooseAlgorithm);
            this.panelHeuristics.Controls.Add(this.comboBoxAlgorithm);
            this.panelHeuristics.Controls.Add(this.label7);
            this.panelHeuristics.Controls.Add(this.comboBoxMoveSelection);
            this.panelHeuristics.Location = new System.Drawing.Point(24, 294);
            this.panelHeuristics.Name = "panelHeuristics";
            this.panelHeuristics.Size = new System.Drawing.Size(517, 234);
            this.panelHeuristics.TabIndex = 31;
            // 
            // labelMoveSelectionHeuristic
            // 
            this.labelMoveSelectionHeuristic.AutoSize = true;
            this.labelMoveSelectionHeuristic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMoveSelectionHeuristic.Location = new System.Drawing.Point(3, 181);
            this.labelMoveSelectionHeuristic.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMoveSelectionHeuristic.Name = "labelMoveSelectionHeuristic";
            this.labelMoveSelectionHeuristic.Size = new System.Drawing.Size(236, 20);
            this.labelMoveSelectionHeuristic.TabIndex = 30;
            this.labelMoveSelectionHeuristic.Text = "Choose move selection heuristic";
            // 
            // labelVariableHeuristic
            // 
            this.labelVariableHeuristic.AutoSize = true;
            this.labelVariableHeuristic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelVariableHeuristic.Location = new System.Drawing.Point(3, 134);
            this.labelVariableHeuristic.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelVariableHeuristic.Name = "labelVariableHeuristic";
            this.labelVariableHeuristic.Size = new System.Drawing.Size(185, 20);
            this.labelVariableHeuristic.TabIndex = 28;
            this.labelVariableHeuristic.Text = "Choose variable heuristic";
            // 
            // comboBoxVariableHeuristic
            // 
            this.comboBoxVariableHeuristic.DisplayMember = "1";
            this.comboBoxVariableHeuristic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxVariableHeuristic.FormattingEnabled = true;
            this.comboBoxVariableHeuristic.Location = new System.Drawing.Point(280, 131);
            this.comboBoxVariableHeuristic.Name = "comboBoxVariableHeuristic";
            this.comboBoxVariableHeuristic.Size = new System.Drawing.Size(224, 28);
            this.comboBoxVariableHeuristic.TabIndex = 29;
            // 
            // labelChooseValueHeuristic
            // 
            this.labelChooseValueHeuristic.AutoSize = true;
            this.labelChooseValueHeuristic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChooseValueHeuristic.Location = new System.Drawing.Point(3, 87);
            this.labelChooseValueHeuristic.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelChooseValueHeuristic.Name = "labelChooseValueHeuristic";
            this.labelChooseValueHeuristic.Size = new System.Drawing.Size(168, 20);
            this.labelChooseValueHeuristic.TabIndex = 22;
            this.labelChooseValueHeuristic.Text = "Choose value heuristic";
            // 
            // comboBoxValueHeuristic
            // 
            this.comboBoxValueHeuristic.DisplayMember = "1";
            this.comboBoxValueHeuristic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxValueHeuristic.FormattingEnabled = true;
            this.comboBoxValueHeuristic.Location = new System.Drawing.Point(280, 84);
            this.comboBoxValueHeuristic.Name = "comboBoxValueHeuristic";
            this.comboBoxValueHeuristic.Size = new System.Drawing.Size(224, 28);
            this.comboBoxValueHeuristic.TabIndex = 27;
            // 
            // labelChooseAlgorithm
            // 
            this.labelChooseAlgorithm.AutoSize = true;
            this.labelChooseAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChooseAlgorithm.Location = new System.Drawing.Point(6, 40);
            this.labelChooseAlgorithm.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelChooseAlgorithm.Name = "labelChooseAlgorithm";
            this.labelChooseAlgorithm.Size = new System.Drawing.Size(133, 20);
            this.labelChooseAlgorithm.TabIndex = 23;
            this.labelChooseAlgorithm.Text = "Choose algorithm";
            // 
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.comboBoxAlgorithm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxAlgorithm.DisplayMember = "1";
            this.comboBoxAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxAlgorithm.FormattingEnabled = true;
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(280, 37);
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(224, 28);
            this.comboBoxAlgorithm.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(84, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 24;
            // 
            // comboBoxMoveSelection
            // 
            this.comboBoxMoveSelection.DisplayMember = "1";
            this.comboBoxMoveSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxMoveSelection.FormattingEnabled = true;
            this.comboBoxMoveSelection.Location = new System.Drawing.Point(280, 178);
            this.comboBoxMoveSelection.Name = "comboBoxMoveSelection";
            this.comboBoxMoveSelection.Size = new System.Drawing.Size(224, 28);
            this.comboBoxMoveSelection.TabIndex = 25;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(939, 567);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(173, 31);
            this.buttonSaveChanges.TabIndex = 32;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Font = new System.Drawing.Font("Baskerville Old Face", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettings.Location = new System.Drawing.Point(453, 9);
            this.labelSettings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(129, 40);
            this.labelSettings.TabIndex = 30;
            this.labelSettings.Text = "Settings";
            // 
            // panelShifts
            // 
            this.panelShifts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelShifts.Controls.Add(this.buttonSaveShiftChanges);
            this.panelShifts.Controls.Add(this.textBoxMaxCapacitiy);
            this.panelShifts.Controls.Add(this.labelMinCapacitiy);
            this.panelShifts.Controls.Add(this.textBoxMinCapacitiy);
            this.panelShifts.Controls.Add(this.labelShifts);
            this.panelShifts.Controls.Add(this.labelMaxCapacitiy);
            this.panelShifts.Controls.Add(this.labelChooseShift);
            this.panelShifts.Controls.Add(this.comboBoxShifts);
            this.panelShifts.Controls.Add(this.label9);
            this.panelShifts.Location = new System.Drawing.Point(575, 52);
            this.panelShifts.Name = "panelShifts";
            this.panelShifts.Size = new System.Drawing.Size(517, 234);
            this.panelShifts.TabIndex = 32;
            // 
            // buttonSaveShiftChanges
            // 
            this.buttonSaveShiftChanges.Location = new System.Drawing.Point(337, 196);
            this.buttonSaveShiftChanges.Name = "buttonSaveShiftChanges";
            this.buttonSaveShiftChanges.Size = new System.Drawing.Size(173, 31);
            this.buttonSaveShiftChanges.TabIndex = 34;
            this.buttonSaveShiftChanges.Text = "Save Shift Changes";
            this.buttonSaveShiftChanges.UseVisualStyleBackColor = true;
            this.buttonSaveShiftChanges.Click += new System.EventHandler(this.buttonSaveShiftChanges_Click);
            // 
            // textBoxMaxCapacitiy
            // 
            this.textBoxMaxCapacitiy.Location = new System.Drawing.Point(281, 87);
            this.textBoxMaxCapacitiy.Name = "textBoxMaxCapacitiy";
            this.textBoxMaxCapacitiy.Size = new System.Drawing.Size(224, 26);
            this.textBoxMaxCapacitiy.TabIndex = 35;
            // 
            // labelMinCapacitiy
            // 
            this.labelMinCapacitiy.AutoSize = true;
            this.labelMinCapacitiy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMinCapacitiy.Location = new System.Drawing.Point(3, 134);
            this.labelMinCapacitiy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMinCapacitiy.Name = "labelMinCapacitiy";
            this.labelMinCapacitiy.Size = new System.Drawing.Size(99, 20);
            this.labelMinCapacitiy.TabIndex = 28;
            this.labelMinCapacitiy.Text = "Min capacitiy";
            // 
            // textBoxMinCapacitiy
            // 
            this.textBoxMinCapacitiy.Location = new System.Drawing.Point(281, 134);
            this.textBoxMinCapacitiy.Name = "textBoxMinCapacitiy";
            this.textBoxMinCapacitiy.Size = new System.Drawing.Size(224, 26);
            this.textBoxMinCapacitiy.TabIndex = 34;
            // 
            // labelShifts
            // 
            this.labelShifts.AutoSize = true;
            this.labelShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelShifts.Location = new System.Drawing.Point(4, 0);
            this.labelShifts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShifts.Name = "labelShifts";
            this.labelShifts.Size = new System.Drawing.Size(54, 24);
            this.labelShifts.TabIndex = 0;
            this.labelShifts.Text = "Shifts";
            // 
            // labelMaxCapacitiy
            // 
            this.labelMaxCapacitiy.AutoSize = true;
            this.labelMaxCapacitiy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMaxCapacitiy.Location = new System.Drawing.Point(3, 87);
            this.labelMaxCapacitiy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMaxCapacitiy.Name = "labelMaxCapacitiy";
            this.labelMaxCapacitiy.Size = new System.Drawing.Size(103, 20);
            this.labelMaxCapacitiy.TabIndex = 22;
            this.labelMaxCapacitiy.Text = "Max capacitiy";
            // 
            // labelChooseShift
            // 
            this.labelChooseShift.AutoSize = true;
            this.labelChooseShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelChooseShift.Location = new System.Drawing.Point(6, 40);
            this.labelChooseShift.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelChooseShift.Name = "labelChooseShift";
            this.labelChooseShift.Size = new System.Drawing.Size(101, 20);
            this.labelChooseShift.TabIndex = 23;
            this.labelChooseShift.Text = "Choose Shift";
            // 
            // comboBoxShifts
            // 
            this.comboBoxShifts.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.comboBoxShifts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxShifts.DisplayMember = "1";
            this.comboBoxShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxShifts.FormattingEnabled = true;
            this.comboBoxShifts.Location = new System.Drawing.Point(280, 37);
            this.comboBoxShifts.Name = "comboBoxShifts";
            this.comboBoxShifts.Size = new System.Drawing.Size(224, 28);
            this.comboBoxShifts.TabIndex = 26;
            this.comboBoxShifts.SelectedIndexChanged += new System.EventHandler(this.comboBoxShifts_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(84, 120);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonSaveEmployeeChanges);
            this.panel1.Controls.Add(this.textBoxEmpMinAvailability);
            this.panel1.Controls.Add(this.textBoxEmpMaxAvailability);
            this.panel1.Controls.Add(this.labelMinAvailability);
            this.panel1.Controls.Add(this.labelEmployees);
            this.panel1.Controls.Add(this.labelMaxAvailability);
            this.panel1.Controls.Add(this.labelEmployeeName);
            this.panel1.Controls.Add(this.comboBoxEmployeeName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(575, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 234);
            this.panel1.TabIndex = 33;
            // 
            // buttonSaveEmployeeChanges
            // 
            this.buttonSaveEmployeeChanges.Location = new System.Drawing.Point(337, 196);
            this.buttonSaveEmployeeChanges.Name = "buttonSaveEmployeeChanges";
            this.buttonSaveEmployeeChanges.Size = new System.Drawing.Size(173, 31);
            this.buttonSaveEmployeeChanges.TabIndex = 34;
            this.buttonSaveEmployeeChanges.Text = "Save Employee Changes";
            this.buttonSaveEmployeeChanges.UseVisualStyleBackColor = true;
            this.buttonSaveEmployeeChanges.Click += new System.EventHandler(this.buttonSaveEmployeeChanges_Click);
            // 
            // textBoxEmpMinAvailability
            // 
            this.textBoxEmpMinAvailability.Location = new System.Drawing.Point(281, 134);
            this.textBoxEmpMinAvailability.Name = "textBoxEmpMinAvailability";
            this.textBoxEmpMinAvailability.Size = new System.Drawing.Size(224, 26);
            this.textBoxEmpMinAvailability.TabIndex = 37;
            this.textBoxEmpMinAvailability.Text = "2";
            // 
            // textBoxEmpMaxAvailability
            // 
            this.textBoxEmpMaxAvailability.Location = new System.Drawing.Point(280, 87);
            this.textBoxEmpMaxAvailability.Name = "textBoxEmpMaxAvailability";
            this.textBoxEmpMaxAvailability.Size = new System.Drawing.Size(224, 26);
            this.textBoxEmpMaxAvailability.TabIndex = 36;
            this.textBoxEmpMaxAvailability.Text = "9";
            // 
            // labelMinAvailability
            // 
            this.labelMinAvailability.AutoSize = true;
            this.labelMinAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMinAvailability.Location = new System.Drawing.Point(3, 134);
            this.labelMinAvailability.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMinAvailability.Name = "labelMinAvailability";
            this.labelMinAvailability.Size = new System.Drawing.Size(76, 20);
            this.labelMinAvailability.TabIndex = 28;
            this.labelMinAvailability.Text = "Min shifts";
            // 
            // labelEmployees
            // 
            this.labelEmployees.AutoSize = true;
            this.labelEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEmployees.Location = new System.Drawing.Point(4, 0);
            this.labelEmployees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployees.Name = "labelEmployees";
            this.labelEmployees.Size = new System.Drawing.Size(105, 24);
            this.labelEmployees.TabIndex = 0;
            this.labelEmployees.Text = "Employees";
            // 
            // labelMaxAvailability
            // 
            this.labelMaxAvailability.AutoSize = true;
            this.labelMaxAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMaxAvailability.Location = new System.Drawing.Point(3, 87);
            this.labelMaxAvailability.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMaxAvailability.Name = "labelMaxAvailability";
            this.labelMaxAvailability.Size = new System.Drawing.Size(80, 20);
            this.labelMaxAvailability.TabIndex = 22;
            this.labelMaxAvailability.Text = "Max shifts";
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEmployeeName.Location = new System.Drawing.Point(3, 37);
            this.labelEmployeeName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(136, 20);
            this.labelEmployeeName.TabIndex = 23;
            this.labelEmployeeName.Text = "Choose employee";
            // 
            // comboBoxEmployeeName
            // 
            this.comboBoxEmployeeName.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.comboBoxEmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxEmployeeName.DisplayMember = "1";
            this.comboBoxEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxEmployeeName.FormattingEnabled = true;
            this.comboBoxEmployeeName.Location = new System.Drawing.Point(280, 37);
            this.comboBoxEmployeeName.Name = "comboBoxEmployeeName";
            this.comboBoxEmployeeName.Size = new System.Drawing.Size(224, 28);
            this.comboBoxEmployeeName.TabIndex = 26;
            this.comboBoxEmployeeName.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployeeName_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(84, 120);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 24;
            // 
            // textBoxLimitTime
            // 
            this.textBoxLimitTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxLimitTime.Location = new System.Drawing.Point(784, 573);
            this.textBoxLimitTime.Name = "textBoxLimitTime";
            this.textBoxLimitTime.Size = new System.Drawing.Size(97, 26);
            this.textBoxLimitTime.TabIndex = 35;
            this.textBoxLimitTime.Text = "120000";
            // 
            // labelLimitTime
            // 
            this.labelLimitTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLimitTime.AutoSize = true;
            this.labelLimitTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLimitTime.Location = new System.Drawing.Point(664, 582);
            this.labelLimitTime.Name = "labelLimitTime";
            this.labelLimitTime.Size = new System.Drawing.Size(114, 16);
            this.labelLimitTime.TabIndex = 34;
            this.labelLimitTime.Text = "Limit Run Time:";
            // 
            // labelProbability
            // 
            this.labelProbability.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProbability.AutoSize = true;
            this.labelProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelProbability.Location = new System.Drawing.Point(428, 582);
            this.labelProbability.Name = "labelProbability";
            this.labelProbability.Size = new System.Drawing.Size(91, 16);
            this.labelProbability.TabIndex = 36;
            this.labelProbability.Text = "Probability :";
            // 
            // comboBoxProbability
            // 
            this.comboBoxProbability.DisplayMember = "1";
            this.comboBoxProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxProbability.FormattingEnabled = true;
            this.comboBoxProbability.Items.AddRange(new object[] {
            "100",
            "85",
            "66"});
            this.comboBoxProbability.Location = new System.Drawing.Point(521, 576);
            this.comboBoxProbability.Name = "comboBoxProbability";
            this.comboBoxProbability.Size = new System.Drawing.Size(79, 28);
            this.comboBoxProbability.TabIndex = 31;
            this.comboBoxProbability.Text = "85";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1141, 610);
            this.Controls.Add(this.comboBoxProbability);
            this.Controls.Add(this.labelProbability);
            this.Controls.Add(this.textBoxLimitTime);
            this.Controls.Add(this.labelLimitTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelShifts);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.panelHeuristics);
            this.Controls.Add(this.panelConstraints);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formSettings_MouseMove);
            this.panelConstraints.ResumeLayout(false);
            this.panelConstraints.PerformLayout();
            this.panelHeuristics.ResumeLayout(false);
            this.panelHeuristics.PerformLayout();
            this.panelShifts.ResumeLayout(false);
            this.panelShifts.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeuristics;
        private System.Windows.Forms.Label labelConstraints;
        private System.Windows.Forms.ComboBox comboBox2DaysInARow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxOneDayWeekend;
        private System.Windows.Forms.ComboBox comboBoxConflictWorker1;
        private System.Windows.Forms.ComboBox comboBoxConflictWorker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelConflictConstraint;
        private System.Windows.Forms.Label labelMinShifts;
        private System.Windows.Forms.Panel panelConstraints;
        private System.Windows.Forms.Panel panelHeuristics;
        private System.Windows.Forms.Label labelVariableHeuristic;
        private System.Windows.Forms.ComboBox comboBoxVariableHeuristic;
        private System.Windows.Forms.Label labelChooseValueHeuristic;
        private System.Windows.Forms.ComboBox comboBoxValueHeuristic;
        private System.Windows.Forms.Label labelChooseAlgorithm;
        private System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxMoveSelection;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Label labelMoveSelectionHeuristic;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Panel panelShifts;
        private System.Windows.Forms.Label labelMinCapacitiy;
        private System.Windows.Forms.Label labelShifts;
        private System.Windows.Forms.Label labelMaxCapacitiy;
        private System.Windows.Forms.Label labelChooseShift;
        private System.Windows.Forms.ComboBox comboBoxShifts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMinAvailability;
        private System.Windows.Forms.Label labelEmployees;
        private System.Windows.Forms.Label labelMaxAvailability;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.ComboBox comboBoxEmployeeName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMaxCapacitiy;
        private System.Windows.Forms.TextBox textBoxMinCapacitiy;
        private System.Windows.Forms.TextBox textBoxEmpMinAvailability;
        private System.Windows.Forms.TextBox textBoxEmpMaxAvailability;
        private System.Windows.Forms.Button buttonSaveShiftChanges;
        private System.Windows.Forms.Button buttonSaveEmployeeChanges;
        private System.Windows.Forms.Button buttonMoreConstraints;
        private System.Windows.Forms.Label labelProfecincyConstraint;
        private System.Windows.Forms.Label labelNightOrFriday;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelNightAndDay;
        private System.Windows.Forms.Label labelOneManagerConstraint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxNightAndDay;
        private System.Windows.Forms.CheckBox checkBoxOneManager;
        private System.Windows.Forms.CheckBox checkBoxProficiency;
        private System.Windows.Forms.CheckBox checkBoxNightOrFriday;
        private System.Windows.Forms.CheckBox checkBox2DaysInRow;
        private System.Windows.Forms.CheckBox checkBoxWeekendConstraint;
        private System.Windows.Forms.CheckBox checkBoxConflictConstraint;
        private System.Windows.Forms.TextBox textBoxLimitTime;
        private System.Windows.Forms.Label labelLimitTime;
        private System.Windows.Forms.Label labelProbability;
        private System.Windows.Forms.ComboBox comboBoxProbability;
    }
}