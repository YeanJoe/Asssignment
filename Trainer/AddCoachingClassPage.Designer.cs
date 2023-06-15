namespace APU_Programming_Cafe_Management_System
{
    partial class AddCoachingClassPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDay = new System.Windows.Forms.ComboBox();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(12, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(56, 52);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Module Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Charge (RM)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Schedule";
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
            this.cboDay.Location = new System.Drawing.Point(277, 275);
            this.cboDay.Name = "cboDay";
            this.cboDay.Size = new System.Drawing.Size(121, 24);
            this.cboDay.TabIndex = 4;
            // 
            // cboTime
            // 
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Items.AddRange(new object[] {
            "08:00 - 10:00",
            "10:00 - 12:00",
            "13:00 - 15:00",
            "15:00 - 17:00"});
            this.cboTime.Location = new System.Drawing.Point(439, 275);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(121, 24);
            this.cboTime.TabIndex = 5;
            // 
            // txtModule
            // 
            this.txtModule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModule.Location = new System.Drawing.Point(277, 178);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(154, 22);
            this.txtModule.TabIndex = 6;
            // 
            // txtCharge
            // 
            this.txtCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCharge.Location = new System.Drawing.Point(277, 223);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(154, 22);
            this.txtCharge.TabIndex = 7;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(356, 373);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // AddCoachingClassPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.txtModule);
            this.Controls.Add(this.cboTime);
            this.Controls.Add(this.cboDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBack);
            this.Name = "AddCoachingClassPage";
            this.Text = "Add Coaching Class Info";
            this.Load += new System.EventHandler(this.AddCoachingClassPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDay;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Button BtnAdd;
    }
}