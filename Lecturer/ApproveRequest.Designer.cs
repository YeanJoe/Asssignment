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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.listRequest = new System.Windows.Forms.ListBox();
            this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataBaseDataSet = new Asssignment.myDataBaseDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.lblTP = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.requestTableAdapter = new Asssignment.myDataBaseDataSetTableAdapters.RequestTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkApprove = new System.Windows.Forms.CheckBox();
            this.checkReject = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // 
            // listRequest
            // 
            this.listRequest.DataSource = this.requestBindingSource;
            this.listRequest.DisplayMember = "Username";
            this.listRequest.FormattingEnabled = true;
            this.listRequest.ItemHeight = 16;
            this.listRequest.Location = new System.Drawing.Point(34, 57);
            this.listRequest.Name = "listRequest";
            this.listRequest.Size = new System.Drawing.Size(120, 84);
            this.listRequest.TabIndex = 1;
            this.listRequest.ValueMember = "Username";
            this.listRequest.SelectedIndexChanged += new System.EventHandler(this.listRequest_SelectedIndexChanged);
            // 
            // requestBindingSource
            // 
            this.requestBindingSource.DataMember = "Request";
            this.requestBindingSource.DataSource = this.myDataBaseDataSet;
            // 
            // myDataBaseDataSet
            // 
            this.myDataBaseDataSet.DataSetName = "myDataBaseDataSet";
            this.myDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tp Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student\'s Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Module";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Level";
            // 
            // lblLevel
            // 
            this.lblLevel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblLevel.Location = new System.Drawing.Point(176, 85);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(102, 16);
            this.lblLevel.TabIndex = 11;
            // 
            // lblModule
            // 
            this.lblModule.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblModule.Location = new System.Drawing.Point(318, 85);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(102, 16);
            this.lblModule.TabIndex = 12;
            // 
            // lblTP
            // 
            this.lblTP.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTP.Location = new System.Drawing.Point(318, 38);
            this.lblTP.Name = "lblTP";
            this.lblTP.Size = new System.Drawing.Size(102, 16);
            this.lblTP.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblName.Location = new System.Drawing.Point(176, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 16);
            this.lblName.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 163);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(57, 28);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(404, 163);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(66, 28);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // requestTableAdapter
            // 
            this.requestTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkApprove);
            this.groupBox1.Controls.Add(this.checkReject);
            this.groupBox1.Location = new System.Drawing.Point(179, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 63);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // checkApprove
            // 
            this.checkApprove.AutoSize = true;
            this.checkApprove.Location = new System.Drawing.Point(6, 12);
            this.checkApprove.Name = "checkApprove";
            this.checkApprove.Size = new System.Drawing.Size(81, 20);
            this.checkApprove.TabIndex = 19;
            this.checkApprove.Text = "Approve";
            this.checkApprove.UseVisualStyleBackColor = true;
            this.checkApprove.CheckedChanged += new System.EventHandler(this.checkApprove_CheckedChanged);
            // 
            // checkReject
            // 
            this.checkReject.AutoSize = true;
            this.checkReject.Location = new System.Drawing.Point(6, 36);
            this.checkReject.Name = "checkReject";
            this.checkReject.Size = new System.Drawing.Size(68, 20);
            this.checkReject.TabIndex = 20;
            this.checkReject.Text = "Reject";
            this.checkReject.UseVisualStyleBackColor = true;
            this.checkReject.CheckedChanged += new System.EventHandler(this.checkApprove_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblStatus.Location = new System.Drawing.Point(318, 132);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(102, 16);
            this.lblStatus.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Status";
            // 
            // ApproveRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 203);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
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
            this.Load += new System.EventHandler(this.ApproveRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private myDataBaseDataSet myDataBaseDataSet;
        private System.Windows.Forms.BindingSource requestBindingSource;
        private myDataBaseDataSetTableAdapters.RequestTableAdapter requestTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkApprove;
        private System.Windows.Forms.CheckBox checkReject;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label7;
    }
}