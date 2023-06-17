namespace Assignment_Admin_
{
    partial class Trainer_s_Module_Assignment
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
            this.txtLevel = new System.Windows.Forms.Label();
            this.cmbTrainerID = new System.Windows.Forms.ComboBox();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.cmbClassID = new System.Windows.Forms.ComboBox();
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trainer ID";
            // 
            // txtLevel
            // 
            this.txtLevel.AutoSize = true;
            this.txtLevel.Location = new System.Drawing.Point(58, 136);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(40, 16);
            this.txtLevel.TabIndex = 2;
            this.txtLevel.Text = "Level";
            // 
            // cmbTrainerID
            // 
            this.cmbTrainerID.FormattingEnabled = true;
            this.cmbTrainerID.Location = new System.Drawing.Point(61, 68);
            this.cmbTrainerID.Name = "cmbTrainerID";
            this.cmbTrainerID.Size = new System.Drawing.Size(195, 24);
            this.cmbTrainerID.TabIndex = 5;
            this.cmbTrainerID.SelectedIndexChanged += new System.EventHandler(this.cmbTrainerID_SelectedIndexChanged);
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advance"});
            this.cmbLevel.Location = new System.Drawing.Point(61, 156);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(195, 24);
            this.cmbLevel.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(272, 263);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(3, 1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(64, 23);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // cmbClassID
            // 
            this.cmbClassID.FormattingEnabled = true;
            this.cmbClassID.Location = new System.Drawing.Point(359, 68);
            this.cmbClassID.Name = "cmbClassID";
            this.cmbClassID.Size = new System.Drawing.Size(195, 24);
            this.cmbClassID.TabIndex = 10;
            this.cmbClassID.SelectedIndexChanged += new System.EventHandler(this.cmbClassID_SelectedIndexChanged);
            // 
            // cmbModule
            // 
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Items.AddRange(new object[] {
            "C#",
            "Database",
            "Java",
            "Python"});
            this.cmbModule.Location = new System.Drawing.Point(359, 156);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(195, 24);
            this.cmbModule.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "ClassID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Module";
            // 
            // Trainer_s_Module_Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 355);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbModule);
            this.Controls.Add(this.cmbClassID);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.cmbTrainerID);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.label1);
            this.Name = "Trainer_s_Module_Assignment";
            this.Text = "Trainer\'s Module Assignment";
            this.Load += new System.EventHandler(this.Trainer_s_Module_Assignment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtLevel;
        private System.Windows.Forms.ComboBox cmbTrainerID;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox cmbClassID;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}