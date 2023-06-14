namespace Asssignment.Lecturer
{
    partial class DeleteCompletedStudent
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblTP = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listCompleted = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblName.Location = new System.Drawing.Point(186, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 16);
            this.lblName.TabIndex = 24;
            // 
            // lblTP
            // 
            this.lblTP.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTP.Location = new System.Drawing.Point(341, 50);
            this.lblTP.Name = "lblTP";
            this.lblTP.Size = new System.Drawing.Size(102, 16);
            this.lblTP.TabIndex = 23;
            // 
            // lblModule
            // 
            this.lblModule.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblModule.Location = new System.Drawing.Point(341, 103);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(102, 16);
            this.lblModule.TabIndex = 22;
            // 
            // lblLevel
            // 
            this.lblLevel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblLevel.Location = new System.Drawing.Point(186, 103);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(102, 16);
            this.lblLevel.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Module";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tp Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Student\'s Name";
            // 
            // listCompleted
            // 
            this.listCompleted.FormattingEnabled = true;
            this.listCompleted.ItemHeight = 16;
            this.listCompleted.Items.AddRange(new object[] {
            "name"});
            this.listCompleted.Location = new System.Drawing.Point(28, 59);
            this.listCompleted.Name = "listCompleted";
            this.listCompleted.Size = new System.Drawing.Size(120, 84);
            this.listCompleted.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Completed Student";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 160);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(57, 28);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(400, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 28);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // DeleteCompletedStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 200);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTP);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listCompleted);
            this.Controls.Add(this.label1);
            this.Name = "DeleteCompletedStudent";
            this.Text = "DeleteCompletedStudent";
            this.Load += new System.EventHandler(this.DeleteCompletedStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTP;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listCompleted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
    }
}