namespace WinFormUI
{
    partial class FormAddEmployee
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMinShifts = new System.Windows.Forms.Label();
            this.labelMaxShifts = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labeProficiency = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxMinShifts = new System.Windows.Forms.ComboBox();
            this.comboBoxMaxShifts = new System.Windows.Forms.ComboBox();
            this.comboBoxProficiency = new System.Windows.Forms.ComboBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.labelAddEmployee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Location = new System.Drawing.Point(271, 258);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(107, 31);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(15, 82);
            this.labelName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 18);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelMinShifts
            // 
            this.labelMinShifts.AutoSize = true;
            this.labelMinShifts.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinShifts.Location = new System.Drawing.Point(15, 154);
            this.labelMinShifts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMinShifts.Name = "labelMinShifts";
            this.labelMinShifts.Size = new System.Drawing.Size(72, 18);
            this.labelMinShifts.TabIndex = 2;
            this.labelMinShifts.Text = "Min Shifts";
            // 
            // labelMaxShifts
            // 
            this.labelMaxShifts.AutoSize = true;
            this.labelMaxShifts.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxShifts.Location = new System.Drawing.Point(15, 118);
            this.labelMaxShifts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMaxShifts.Name = "labelMaxShifts";
            this.labelMaxShifts.Size = new System.Drawing.Size(74, 18);
            this.labelMaxShifts.TabIndex = 3;
            this.labelMaxShifts.Text = "Max Shifts";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(15, 46);
            this.labelID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 18);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 5;
            // 
            // labeProficiency
            // 
            this.labeProficiency.AutoSize = true;
            this.labeProficiency.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeProficiency.Location = new System.Drawing.Point(15, 190);
            this.labeProficiency.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labeProficiency.Name = "labeProficiency";
            this.labeProficiency.Size = new System.Drawing.Size(79, 18);
            this.labeProficiency.TabIndex = 6;
            this.labeProficiency.Text = "Proficiency";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(15, 226);
            this.labelSalary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(47, 18);
            this.labelSalary.TabIndex = 7;
            this.labelSalary.Text = "Salary";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(139, 46);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(178, 26);
            this.textBoxID.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(139, 79);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(178, 26);
            this.textBoxName.TabIndex = 11;
            // 
            // comboBoxMinShifts
            // 
            this.comboBoxMinShifts.DisplayMember = "1";
            this.comboBoxMinShifts.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMinShifts.FormattingEnabled = true;
            this.comboBoxMinShifts.Items.AddRange(new object[] {
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
            this.comboBoxMinShifts.Location = new System.Drawing.Point(139, 151);
            this.comboBoxMinShifts.Name = "comboBoxMinShifts";
            this.comboBoxMinShifts.Size = new System.Drawing.Size(48, 26);
            this.comboBoxMinShifts.TabIndex = 12;
            this.comboBoxMinShifts.Text = "3";
            // 
            // comboBoxMaxShifts
            // 
            this.comboBoxMaxShifts.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.comboBoxMaxShifts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxMaxShifts.DisplayMember = "1";
            this.comboBoxMaxShifts.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMaxShifts.FormattingEnabled = true;
            this.comboBoxMaxShifts.Items.AddRange(new object[] {
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
            this.comboBoxMaxShifts.Location = new System.Drawing.Point(139, 115);
            this.comboBoxMaxShifts.Name = "comboBoxMaxShifts";
            this.comboBoxMaxShifts.Size = new System.Drawing.Size(48, 26);
            this.comboBoxMaxShifts.TabIndex = 13;
            this.comboBoxMaxShifts.Text = "12";
            // 
            // comboBoxProficiency
            // 
            this.comboBoxProficiency.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProficiency.FormattingEnabled = true;
            this.comboBoxProficiency.Items.AddRange(new object[] {
            "Manager",
            "Chef",
            "Waiter"});
            this.comboBoxProficiency.Location = new System.Drawing.Point(139, 187);
            this.comboBoxProficiency.Name = "comboBoxProficiency";
            this.comboBoxProficiency.Size = new System.Drawing.Size(178, 26);
            this.comboBoxProficiency.TabIndex = 14;
            this.comboBoxProficiency.Text = "Chef";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalary.Location = new System.Drawing.Point(139, 223);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(178, 26);
            this.textBoxSalary.TabIndex = 15;
            this.textBoxSalary.Text = "27";
            // 
            // labelAddEmployee
            // 
            this.labelAddEmployee.AutoSize = true;
            this.labelAddEmployee.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddEmployee.Location = new System.Drawing.Point(110, 9);
            this.labelAddEmployee.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAddEmployee.Name = "labelAddEmployee";
            this.labelAddEmployee.Size = new System.Drawing.Size(138, 22);
            this.labelAddEmployee.TabIndex = 16;
            this.labelAddEmployee.Text = "Add Employee";
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(391, 297);
            this.Controls.Add(this.labelAddEmployee);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.comboBoxProficiency);
            this.Controls.Add(this.comboBoxMaxShifts);
            this.Controls.Add(this.comboBoxMinShifts);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labeProficiency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelMaxShifts);
            this.Controls.Add(this.labelMinShifts);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Employee";
            this.Load += new System.EventHandler(this.FormAddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMinShifts;
        private System.Windows.Forms.Label labelMaxShifts;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeProficiency;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxMinShifts;
        private System.Windows.Forms.ComboBox comboBoxMaxShifts;
        private System.Windows.Forms.ComboBox comboBoxProficiency;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label labelAddEmployee;
    }
}