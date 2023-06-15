namespace Assignment_Admin_
{
    partial class AdminHomePage
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
            this.lblHomeTitle = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnTrainerRaD = new System.Windows.Forms.Button();
            this.btnTrainerModule = new System.Windows.Forms.Button();
            this.btnTrainerIncome = new System.Windows.Forms.Button();
            this.btnFeedbackHub = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHomeTitle
            // 
            this.lblHomeTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHomeTitle.Location = new System.Drawing.Point(0, 0);
            this.lblHomeTitle.Name = "lblHomeTitle";
            this.lblHomeTitle.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.lblHomeTitle.Size = new System.Drawing.Size(800, 450);
            this.lblHomeTitle.TabIndex = 0;
            this.lblHomeTitle.Text = "Welcome, ";
            this.lblHomeTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(279, 311);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(222, 23);
            this.btnSignOut.TabIndex = 1;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnTrainerRaD
            // 
            this.btnTrainerRaD.Location = new System.Drawing.Point(279, 117);
            this.btnTrainerRaD.Name = "btnTrainerRaD";
            this.btnTrainerRaD.Size = new System.Drawing.Size(222, 23);
            this.btnTrainerRaD.TabIndex = 2;
            this.btnTrainerRaD.Text = "Trainer Register and Delete";
            this.btnTrainerRaD.UseVisualStyleBackColor = true;
            this.btnTrainerRaD.Click += new System.EventHandler(this.btnTrainerRaD_Click);
            // 
            // btnTrainerModule
            // 
            this.btnTrainerModule.Location = new System.Drawing.Point(279, 156);
            this.btnTrainerModule.Name = "btnTrainerModule";
            this.btnTrainerModule.Size = new System.Drawing.Size(222, 23);
            this.btnTrainerModule.TabIndex = 3;
            this.btnTrainerModule.Text = "Trainer\'s Module Assignment";
            this.btnTrainerModule.UseVisualStyleBackColor = true;
            this.btnTrainerModule.Click += new System.EventHandler(this.btnTrainerModule_Click);
            // 
            // btnTrainerIncome
            // 
            this.btnTrainerIncome.Location = new System.Drawing.Point(279, 195);
            this.btnTrainerIncome.Name = "btnTrainerIncome";
            this.btnTrainerIncome.Size = new System.Drawing.Size(222, 23);
            this.btnTrainerIncome.TabIndex = 4;
            this.btnTrainerIncome.Text = "Trainer\'s Monthly Income Report";
            this.btnTrainerIncome.UseVisualStyleBackColor = true;
            this.btnTrainerIncome.Click += new System.EventHandler(this.btnTrainerIncome_Click);
            // 
            // btnFeedbackHub
            // 
            this.btnFeedbackHub.Location = new System.Drawing.Point(279, 234);
            this.btnFeedbackHub.Name = "btnFeedbackHub";
            this.btnFeedbackHub.Size = new System.Drawing.Size(222, 23);
            this.btnFeedbackHub.TabIndex = 5;
            this.btnFeedbackHub.Text = "Feedback Hub";
            this.btnFeedbackHub.UseVisualStyleBackColor = true;
            this.btnFeedbackHub.Click += new System.EventHandler(this.btnFeedbackHub_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(279, 273);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(222, 23);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnFeedbackHub);
            this.Controls.Add(this.btnTrainerIncome);
            this.Controls.Add(this.btnTrainerModule);
            this.Controls.Add(this.btnTrainerRaD);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.lblHomeTitle);
            this.Name = "AdminHomePage";
            this.Text = "AdminHomePage";
            this.Load += new System.EventHandler(this.AdminHomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHomeTitle;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnTrainerRaD;
        private System.Windows.Forms.Button btnTrainerModule;
        private System.Windows.Forms.Button btnTrainerIncome;
        private System.Windows.Forms.Button btnFeedbackHub;
        private System.Windows.Forms.Button btnProfile;
    }
}