namespace Asssignment.Lecturer
{
    partial class UpdateSubjectEnrollment
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboLevel = new System.Windows.Forms.ComboBox();
            this.comboModule = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student\'s Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 22);
            this.txtName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Current Module";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Current Level";
            // 
            // lblLevel
            // 
            this.lblLevel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblLevel.Location = new System.Drawing.Point(12, 120);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(102, 16);
            this.lblLevel.TabIndex = 10;
            // 
            // lblModule
            // 
            this.lblModule.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblModule.Location = new System.Drawing.Point(209, 120);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(102, 16);
            this.lblModule.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Change Into";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboLevel
            // 
            this.comboLevel.FormattingEnabled = true;
            this.comboLevel.Items.AddRange(new object[] {
            "Level"});
            this.comboLevel.Location = new System.Drawing.Point(12, 213);
            this.comboLevel.Name = "comboLevel";
            this.comboLevel.Size = new System.Drawing.Size(100, 24);
            this.comboLevel.TabIndex = 13;
            // 
            // comboModule
            // 
            this.comboModule.FormattingEnabled = true;
            this.comboModule.Location = new System.Drawing.Point(211, 213);
            this.comboModule.Name = "comboModule";
            this.comboModule.Size = new System.Drawing.Size(100, 24);
            this.comboModule.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 286);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(57, 28);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(240, 289);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // UpdateSubjectEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 344);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.comboModule);
            this.Controls.Add(this.comboLevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "UpdateSubjectEnrollment";
            this.Text = "UpdateSubjectEnrollment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboLevel;
        private System.Windows.Forms.ComboBox comboModule;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
    }
}