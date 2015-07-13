namespace WinFormUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonShowEmployees = new System.Windows.Forms.Button();
            this.buttonAddEmployees = new System.Windows.Forms.Button();
            this.buttonGenerateRoster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIdanOdelia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonShowEmployees
            // 
            this.buttonShowEmployees.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonShowEmployees.Location = new System.Drawing.Point(36, 87);
            this.buttonShowEmployees.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.buttonShowEmployees.Name = "buttonShowEmployees";
            this.buttonShowEmployees.Size = new System.Drawing.Size(159, 70);
            this.buttonShowEmployees.TabIndex = 0;
            this.buttonShowEmployees.Text = "Show Employees";
            this.buttonShowEmployees.UseVisualStyleBackColor = false;
            this.buttonShowEmployees.Click += new System.EventHandler(this.buttonShowEmployees_Click);
            // 
            // buttonAddEmployees
            // 
            this.buttonAddEmployees.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddEmployees.Location = new System.Drawing.Point(219, 87);
            this.buttonAddEmployees.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.buttonAddEmployees.Name = "buttonAddEmployees";
            this.buttonAddEmployees.Size = new System.Drawing.Size(159, 70);
            this.buttonAddEmployees.TabIndex = 2;
            this.buttonAddEmployees.Text = "Add Employee";
            this.buttonAddEmployees.UseVisualStyleBackColor = false;
            this.buttonAddEmployees.Click += new System.EventHandler(this.buttonAddEmployees_Click);
            // 
            // buttonGenerateRoster
            // 
            this.buttonGenerateRoster.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGenerateRoster.Location = new System.Drawing.Point(407, 87);
            this.buttonGenerateRoster.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.buttonGenerateRoster.Name = "buttonGenerateRoster";
            this.buttonGenerateRoster.Size = new System.Drawing.Size(159, 70);
            this.buttonGenerateRoster.TabIndex = 3;
            this.buttonGenerateRoster.Text = "Generate Roster";
            this.buttonGenerateRoster.UseVisualStyleBackColor = false;
            this.buttonGenerateRoster.Click += new System.EventHandler(this.buttonGenerateRoster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employees Roster";
            // 
            // labelIdanOdelia
            // 
            this.labelIdanOdelia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIdanOdelia.AutoSize = true;
            this.labelIdanOdelia.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdanOdelia.Location = new System.Drawing.Point(12, 190);
            this.labelIdanOdelia.Name = "labelIdanOdelia";
            this.labelIdanOdelia.Size = new System.Drawing.Size(242, 18);
            this.labelIdanOdelia.TabIndex = 5;
            this.labelIdanOdelia.Text = "Odelia Zablianov      Idan Azuri\r\n";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(602, 207);
            this.Controls.Add(this.labelIdanOdelia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGenerateRoster);
            this.Controls.Add(this.buttonAddEmployees);
            this.Controls.Add(this.buttonShowEmployees);
            this.Font = new System.Drawing.Font("Miriam Fixed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowEmployees;
        private System.Windows.Forms.Button buttonAddEmployees;
        private System.Windows.Forms.Button buttonGenerateRoster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIdanOdelia;
    }
}

