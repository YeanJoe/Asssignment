namespace APU_Programming_Cafe_Management_System
{
    partial class TrainerDashboardPage
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.BtnViewStudent = new System.Windows.Forms.Button();
            this.BtnAddClass = new System.Windows.Forms.Button();
            this.BtnFeedback = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(73, 51);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.Location = new System.Drawing.Point(168, 131);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(146, 78);
            this.btnUpdateClass.TabIndex = 1;
            this.btnUpdateClass.Text = "Update Coaching Class Info";
            this.btnUpdateClass.UseVisualStyleBackColor = true;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // BtnViewStudent
            // 
            this.BtnViewStudent.Location = new System.Drawing.Point(168, 241);
            this.BtnViewStudent.Name = "BtnViewStudent";
            this.BtnViewStudent.Size = new System.Drawing.Size(146, 78);
            this.BtnViewStudent.TabIndex = 2;
            this.BtnViewStudent.Text = "View Students";
            this.BtnViewStudent.UseVisualStyleBackColor = true;
            this.BtnViewStudent.Click += new System.EventHandler(this.BtnViewStudent_Click);
            // 
            // BtnAddClass
            // 
            this.BtnAddClass.Location = new System.Drawing.Point(419, 131);
            this.BtnAddClass.Name = "BtnAddClass";
            this.BtnAddClass.Size = new System.Drawing.Size(146, 78);
            this.BtnAddClass.TabIndex = 3;
            this.BtnAddClass.Text = "Add Coaching Class Info";
            this.BtnAddClass.UseVisualStyleBackColor = true;
            this.BtnAddClass.Click += new System.EventHandler(this.BtnAddClass_Click);
            // 
            // BtnFeedback
            // 
            this.BtnFeedback.Location = new System.Drawing.Point(419, 241);
            this.BtnFeedback.Name = "BtnFeedback";
            this.BtnFeedback.Size = new System.Drawing.Size(146, 78);
            this.BtnFeedback.TabIndex = 4;
            this.BtnFeedback.Text = "Send Feedback to Admin";
            this.BtnFeedback.UseVisualStyleBackColor = true;
            this.BtnFeedback.Click += new System.EventHandler(this.BtnFeedback_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(666, 12);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(122, 51);
            this.btnUpdateProfile.TabIndex = 5;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // TrainerDashboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.BtnFeedback);
            this.Controls.Add(this.BtnAddClass);
            this.Controls.Add(this.BtnViewStudent);
            this.Controls.Add(this.btnUpdateClass);
            this.Controls.Add(this.btnLogout);
            this.Name = "TrainerDashboardPage";
            this.Text = "Trainer";
            this.Load += new System.EventHandler(this.TrainerDashboardPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.Button BtnViewStudent;
        private System.Windows.Forms.Button BtnAddClass;
        private System.Windows.Forms.Button BtnFeedback;
        private System.Windows.Forms.Button btnUpdateProfile;
    }
}