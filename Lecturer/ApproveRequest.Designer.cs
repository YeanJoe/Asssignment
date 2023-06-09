namespace Asssignment.Lecturer
{
    partial class ApproveRequest
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
            this.listRequest = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.lblTP = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.checkApprove = new System.Windows.Forms.CheckBox();
            this.checkReject = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listRequest
            // 
            this.listRequest.FormattingEnabled = true;
            this.listRequest.ItemHeight = 16;
            this.listRequest.Items.AddRange(new object[] {
            "name"});
            this.listRequest.Location = new System.Drawing.Point(34, 57);
            this.listRequest.Name = "listRequest";
            this.listRequest.Size = new System.Drawing.Size(120, 84);
            this.listRequest.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tp Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student\'s Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Module";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Level";
            // 
            // lblLevel
            // 
            this.lblLevel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblLevel.Location = new System.Drawing.Point(192, 101);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(102, 16);
            this.lblLevel.TabIndex = 11;
            // 
            // lblModule
            // 
            this.lblModule.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblModule.Location = new System.Drawing.Point(347, 101);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(102, 16);
            this.lblModule.TabIndex = 12;
            // 
            // lblTP
            // 
            this.lblTP.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTP.Location = new System.Drawing.Point(347, 48);
            this.lblTP.Name = "lblTP";
            this.lblTP.Size = new System.Drawing.Size(102, 16);
            this.lblTP.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblName.Location = new System.Drawing.Point(192, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 16);
            this.lblName.TabIndex = 14;
            // 
            // checkApprove
            // 
            this.checkApprove.AutoSize = true;
            this.checkApprove.Location = new System.Drawing.Point(195, 144);
            this.checkApprove.Name = "checkApprove";
            this.checkApprove.Size = new System.Drawing.Size(81, 20);
            this.checkApprove.TabIndex = 17;
            this.checkApprove.Text = "Approve";
            this.checkApprove.UseVisualStyleBackColor = true;
            // 
            // checkReject
            // 
            this.checkReject.AutoSize = true;
            this.checkReject.Location = new System.Drawing.Point(195, 170);
            this.checkReject.Name = "checkReject";
            this.checkReject.Size = new System.Drawing.Size(68, 20);
            this.checkReject.TabIndex = 18;
            this.checkReject.Text = "Reject";
            this.checkReject.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 163);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(57, 28);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(404, 163);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(66, 28);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // ApproveRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 203);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.checkReject);
            this.Controls.Add(this.checkApprove);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTP);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listRequest);
            this.Controls.Add(this.label1);
            this.Name = "ApproveRequest";
            this.Text = "ApproveRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listRequest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label lblTP;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox checkApprove;
        private System.Windows.Forms.CheckBox checkReject;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
    }
}