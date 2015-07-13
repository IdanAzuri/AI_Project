namespace WinFormUI
{
    partial class FormResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResult));
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.dataGridViewEmployeesPerShift = new System.Windows.Forms.DataGridView();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelShifts = new System.Windows.Forms.Label();
            this.labelRunTime = new System.Windows.Forms.Label();
            this.labelEmployees = new System.Windows.Forms.Label();
            this.textBoxRunTime = new System.Windows.Forms.TextBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.checkBoxGoal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeesPerShift)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(3, 100);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.Size = new System.Drawing.Size(396, 562);
            this.dataGridViewSchedule.TabIndex = 0;
            this.dataGridViewSchedule.Visible = false;
            this.dataGridViewSchedule.Click += new System.EventHandler(this.dataGridViewSchedule_Click);
            // 
            // dataGridViewEmployeesPerShift
            // 
            this.dataGridViewEmployeesPerShift.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmployeesPerShift.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployeesPerShift.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewEmployeesPerShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeesPerShift.Location = new System.Drawing.Point(405, 100);
            this.dataGridViewEmployeesPerShift.Name = "dataGridViewEmployeesPerShift";
            this.dataGridViewEmployeesPerShift.Size = new System.Drawing.Size(498, 197);
            this.dataGridViewEmployeesPerShift.TabIndex = 1;
            this.dataGridViewEmployeesPerShift.Visible = false;
            this.dataGridViewEmployeesPerShift.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployeesPerShift_CellContentClick);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGenerate.BackgroundImage")));
            this.buttonGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGenerate.Location = new System.Drawing.Point(744, 521);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(100, 88);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelShifts
            // 
            this.labelShifts.AutoSize = true;
            this.labelShifts.Font = new System.Drawing.Font("Miriam Fixed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShifts.Location = new System.Drawing.Point(21, 77);
            this.labelShifts.Name = "labelShifts";
            this.labelShifts.Size = new System.Drawing.Size(93, 20);
            this.labelShifts.TabIndex = 3;
            this.labelShifts.Text = "Shifts";
            this.labelShifts.Visible = false;
            // 
            // labelRunTime
            // 
            this.labelRunTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRunTime.AutoSize = true;
            this.labelRunTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelRunTime.Location = new System.Drawing.Point(689, 344);
            this.labelRunTime.Name = "labelRunTime";
            this.labelRunTime.Size = new System.Drawing.Size(78, 16);
            this.labelRunTime.TabIndex = 5;
            this.labelRunTime.Text = "Run Time:";
            this.labelRunTime.Visible = false;
            // 
            // labelEmployees
            // 
            this.labelEmployees.AutoSize = true;
            this.labelEmployees.Font = new System.Drawing.Font("Miriam Fixed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployees.Location = new System.Drawing.Point(412, 77);
            this.labelEmployees.Name = "labelEmployees";
            this.labelEmployees.Size = new System.Drawing.Size(177, 20);
            this.labelEmployees.TabIndex = 6;
            this.labelEmployees.Text = "Employees at";
            this.labelEmployees.Visible = false;
            // 
            // textBoxRunTime
            // 
            this.textBoxRunTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxRunTime.Location = new System.Drawing.Point(773, 337);
            this.textBoxRunTime.Name = "textBoxRunTime";
            this.textBoxRunTime.Size = new System.Drawing.Size(97, 26);
            this.textBoxRunTime.TabIndex = 7;
            this.textBoxRunTime.Visible = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSettings.BackgroundImage")));
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSettings.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Location = new System.Drawing.Point(868, 521);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(100, 88);
            this.buttonSettings.TabIndex = 25;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // checkBoxGoal
            // 
            this.checkBoxGoal.AutoSize = true;
            this.checkBoxGoal.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGoal.Location = new System.Drawing.Point(744, 615);
            this.checkBoxGoal.Name = "checkBoxGoal";
            this.checkBoxGoal.Size = new System.Drawing.Size(134, 22);
            this.checkBoxGoal.TabIndex = 26;
            this.checkBoxGoal.Text = "Minimize cost ";
            this.checkBoxGoal.UseVisualStyleBackColor = true;
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(979, 674);
            this.Controls.Add(this.checkBoxGoal);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.textBoxRunTime);
            this.Controls.Add(this.labelEmployees);
            this.Controls.Add(this.labelRunTime);
            this.Controls.Add(this.labelShifts);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.dataGridViewEmployeesPerShift);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResult";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.FormResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeesPerShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.DataGridView dataGridViewEmployeesPerShift;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelShifts;
        private System.Windows.Forms.Label labelRunTime;
        private System.Windows.Forms.Label labelEmployees;
        private System.Windows.Forms.TextBox textBoxRunTime;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.CheckBox checkBoxGoal;
    }
}