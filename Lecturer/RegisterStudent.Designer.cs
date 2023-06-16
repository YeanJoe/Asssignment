namespace Asssignment.Lecturer
{
    partial class RegisterStudent
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtTP = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.comboLevel = new System.Windows.Forms.ComboBox();
            this.comboModule = new System.Windows.Forms.ComboBox();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.myDataBaseDataSet = new Asssignment.myDataBaseDataSet();
            this.myDataBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moduleTableAdapter = new Asssignment.myDataBaseDataSetTableAdapters.ModuleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Addess";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tp Number";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(206, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(206, 229);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(183, 22);
            this.txtNumber.TabIndex = 7;
            // 
            // txtTP
            // 
            this.txtTP.Location = new System.Drawing.Point(206, 148);
            this.txtTP.Name = "txtTP";
            this.txtTP.Size = new System.Drawing.Size(183, 22);
            this.txtTP.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(206, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(206, 269);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(183, 22);
            this.txtAddress.TabIndex = 11;
            // 
            // comboLevel
            // 
            this.comboLevel.FormattingEnabled = true;
            this.comboLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.comboLevel.Location = new System.Drawing.Point(52, 337);
            this.comboLevel.Name = "comboLevel";
            this.comboLevel.Size = new System.Drawing.Size(100, 24);
            this.comboLevel.TabIndex = 12;
            this.comboLevel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboModule
            // 
            this.comboModule.DataSource = this.moduleBindingSource;
            this.comboModule.DisplayMember = "ModuleName";
            this.comboModule.FormattingEnabled = true;
            this.comboModule.Location = new System.Drawing.Point(272, 337);
            this.comboModule.Name = "comboModule";
            this.comboModule.Size = new System.Drawing.Size(100, 24);
            this.comboModule.TabIndex = 13;
            this.comboModule.ValueMember = "ModuleName";
            // 
            // comboMonth
            // 
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboMonth.Location = new System.Drawing.Point(138, 383);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(147, 24);
            this.comboMonth.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 383);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(57, 28);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(335, 383);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(74, 28);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Month";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Module";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(31, 41);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(121, 22);
            this.txtUsername.TabIndex = 21;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(206, 41);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(121, 22);
            this.txtPassword.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Password";
            // 
            // myDataBaseDataSet
            // 
            this.myDataBaseDataSet.DataSetName = "myDataBaseDataSet";
            this.myDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myDataBaseDataSetBindingSource
            // 
            this.myDataBaseDataSetBindingSource.DataSource = this.myDataBaseDataSet;
            this.myDataBaseDataSetBindingSource.Position = 0;
            // 
            // moduleBindingSource
            // 
            this.moduleBindingSource.DataMember = "Module";
            this.moduleBindingSource.DataSource = this.myDataBaseDataSetBindingSource;
            // 
            // moduleTableAdapter
            // 
            this.moduleTableAdapter.ClearBeforeFill = true;
            // 
            // RegisterStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 433);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.comboMonth);
            this.Controls.Add(this.comboModule);
            this.Controls.Add(this.comboLevel);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTP);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterStudent";
            this.Text = "RegisterStudent";
            this.Load += new System.EventHandler(this.RegisterStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtTP;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox comboLevel;
        private System.Windows.Forms.ComboBox comboModule;
        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource myDataBaseDataSetBindingSource;
        private myDataBaseDataSet myDataBaseDataSet;
        private System.Windows.Forms.BindingSource moduleBindingSource;
        private myDataBaseDataSetTableAdapters.ModuleTableAdapter moduleTableAdapter;
    }
}