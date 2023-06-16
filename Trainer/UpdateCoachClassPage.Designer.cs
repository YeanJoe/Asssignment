namespace APU_Programming_Cafe_Management_System
{
    partial class UpdateCoachClassPage
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnSaveChanges = new System.Windows.Forms.Button();
            this.lblClassName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxCharge = new System.Windows.Forms.TextBox();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.cboDay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoxClass = new System.Windows.Forms.ComboBox();
            this.txtBoxModule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(12, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(55, 52);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnSaveChanges
            // 
            this.BtnSaveChanges.Location = new System.Drawing.Point(356, 354);
            this.BtnSaveChanges.Name = "BtnSaveChanges";
            this.BtnSaveChanges.Size = new System.Drawing.Size(119, 31);
            this.BtnSaveChanges.TabIndex = 1;
            this.BtnSaveChanges.Text = "Save Changes";
            this.BtnSaveChanges.UseVisualStyleBackColor = true;
            this.BtnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(287, 97);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(63, 16);
            this.lblClassName.TabIndex = 2;
            this.lblClassName.Text = "Class ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ModuleName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Charge (RM)";
            // 
            // txtBoxCharge
            // 
            this.txtBoxCharge.Location = new System.Drawing.Point(356, 224);
            this.txtBoxCharge.Name = "txtBoxCharge";
            this.txtBoxCharge.Size = new System.Drawing.Size(221, 22);
            this.txtBoxCharge.TabIndex = 6;
            // 
            // cboTime
            // 
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Items.AddRange(new object[] {
            "08:00 - 10:00",
            "10:00 - 12:00",
            "13:00 - 15:00",
            "15:00 - 17:00"});
            this.cboTime.Location = new System.Drawing.Point(499, 276);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(121, 24);
            this.cboTime.TabIndex = 7;
            // 
            // cboDay
            // 
            this.cboDay.FormattingEnabled = true;
            this.cboDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.cboDay.Location = new System.Drawing.Point(356, 276);
            this.cboDay.Name = "cboDay";
            this.cboDay.Size = new System.Drawing.Size(121, 24);
            this.cboDay.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Schedule";
            // 
            // cmbBoxClass
            // 
            this.cmbBoxClass.FormattingEnabled = true;
            this.cmbBoxClass.Location = new System.Drawing.Point(356, 94);
            this.cmbBoxClass.Name = "cmbBoxClass";
            this.cmbBoxClass.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxClass.TabIndex = 10;
            this.cmbBoxClass.SelectedIndexChanged += new System.EventHandler(this.cmbBoxClass_SelectedIndexChanged);
            // 
            // txtBoxModule
            // 
            this.txtBoxModule.Location = new System.Drawing.Point(356, 147);
            this.txtBoxModule.Name = "txtBoxModule";
            this.txtBoxModule.Size = new System.Drawing.Size(221, 22);
            this.txtBoxModule.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Level";
            // 
            // cboLevel
            // 
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.cboLevel.Location = new System.Drawing.Point(356, 187);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(121, 24);
            this.cboLevel.TabIndex = 12;
            // 
            // UpdateCoachClassPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboDay);
            this.Controls.Add(this.cboTime);
            this.Controls.Add(this.txtBoxCharge);
            this.Controls.Add(this.txtBoxModule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.BtnSaveChanges);
            this.Controls.Add(this.BtnBack);
            this.Name = "UpdateCoachClassPage";
            this.Text = "Update Coaching Class Info";
            this.Load += new System.EventHandler(this.UpdateCoachClassPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnSaveChanges;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxCharge;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.ComboBox cboDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBoxClass;
        private System.Windows.Forms.TextBox txtBoxModule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLevel;
    }
}