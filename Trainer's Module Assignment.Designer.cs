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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTrainerID = new System.Windows.Forms.ComboBox();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.chkBoxPython = new System.Windows.Forms.CheckBox();
            this.chkBoxCPlusPlus = new System.Windows.Forms.CheckBox();
            this.chkBoxCSharp = new System.Windows.Forms.CheckBox();
            this.chkBoxHTML = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBoxHTML);
            this.groupBox1.Controls.Add(this.chkBoxCSharp);
            this.groupBox1.Controls.Add(this.chkBoxCPlusPlus);
            this.groupBox1.Controls.Add(this.chkBoxPython);
            this.groupBox1.Location = new System.Drawing.Point(362, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 149);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modules";
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
            this.btnUpdate.Location = new System.Drawing.Point(110, 218);
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
            // 
            // chkBoxPython
            // 
            this.chkBoxPython.AutoSize = true;
            this.chkBoxPython.Location = new System.Drawing.Point(7, 23);
            this.chkBoxPython.Name = "chkBoxPython";
            this.chkBoxPython.Size = new System.Drawing.Size(70, 20);
            this.chkBoxPython.TabIndex = 0;
            this.chkBoxPython.Text = "Python";
            this.chkBoxPython.UseVisualStyleBackColor = true;
            // 
            // chkBoxCPlusPlus
            // 
            this.chkBoxCPlusPlus.AutoSize = true;
            this.chkBoxCPlusPlus.Location = new System.Drawing.Point(7, 50);
            this.chkBoxCPlusPlus.Name = "chkBoxCPlusPlus";
            this.chkBoxCPlusPlus.Size = new System.Drawing.Size(52, 20);
            this.chkBoxCPlusPlus.TabIndex = 1;
            this.chkBoxCPlusPlus.Text = "C++";
            this.chkBoxCPlusPlus.UseVisualStyleBackColor = true;
            // 
            // chkBoxCSharp
            // 
            this.chkBoxCSharp.AutoSize = true;
            this.chkBoxCSharp.Location = new System.Drawing.Point(7, 77);
            this.chkBoxCSharp.Name = "chkBoxCSharp";
            this.chkBoxCSharp.Size = new System.Drawing.Size(45, 20);
            this.chkBoxCSharp.TabIndex = 2;
            this.chkBoxCSharp.Text = "C#";
            this.chkBoxCSharp.UseVisualStyleBackColor = true;
            // 
            // chkBoxHTML
            // 
            this.chkBoxHTML.AutoSize = true;
            this.chkBoxHTML.Location = new System.Drawing.Point(7, 104);
            this.chkBoxHTML.Name = "chkBoxHTML";
            this.chkBoxHTML.Size = new System.Drawing.Size(66, 20);
            this.chkBoxHTML.TabIndex = 3;
            this.chkBoxHTML.Text = "HTML";
            this.chkBoxHTML.UseVisualStyleBackColor = true;
            // 
            // Trainer_s_Module_Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 355);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.cmbTrainerID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.label1);
            this.Name = "Trainer_s_Module_Assignment";
            this.Text = "Trainer\'s Module Assignment";
            this.Load += new System.EventHandler(this.Trainer_s_Module_Assignment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtLevel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTrainerID;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.CheckBox chkBoxHTML;
        private System.Windows.Forms.CheckBox chkBoxCSharp;
        private System.Windows.Forms.CheckBox chkBoxCPlusPlus;
        private System.Windows.Forms.CheckBox chkBoxPython;
    }
}