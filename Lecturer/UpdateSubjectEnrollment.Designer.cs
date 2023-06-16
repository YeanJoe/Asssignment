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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboNewLevel = new System.Windows.Forms.ComboBox();
            this.comboNewModule = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboStudent = new System.Windows.Forms.ComboBox();
            this.myDataBaseDataSet = new Asssignment.myDataBaseDataSet();
            this.studentTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableTableAdapter = new Asssignment.myDataBaseDataSetTableAdapters.StudentTableTableAdapter();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.moduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moduleTableAdapter = new Asssignment.myDataBaseDataSetTableAdapters.ModuleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Current Module";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Current Level";
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
            // comboNewLevel
            // 
            this.comboNewLevel.FormattingEnabled = true;
            this.comboNewLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.comboNewLevel.Location = new System.Drawing.Point(12, 213);
            this.comboNewLevel.Name = "comboNewLevel";
            this.comboNewLevel.Size = new System.Drawing.Size(100, 24);
            this.comboNewLevel.TabIndex = 13;
            // 
            // comboNewModule
            // 
            this.comboNewModule.DataSource = this.moduleBindingSource;
            this.comboNewModule.DisplayMember = "ModuleName";
            this.comboNewModule.FormattingEnabled = true;
            this.comboNewModule.Location = new System.Drawing.Point(211, 213);
            this.comboNewModule.Name = "comboNewModule";
            this.comboNewModule.Size = new System.Drawing.Size(100, 24);
            this.comboNewModule.TabIndex = 14;
            this.comboNewModule.ValueMember = "ModuleName";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 286);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(57, 28);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(240, 289);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboStudent
            // 
            this.comboStudent.DataSource = this.studentTableBindingSource;
            this.comboStudent.DisplayMember = "FullName";
            this.comboStudent.FormattingEnabled = true;
            this.comboStudent.Location = new System.Drawing.Point(15, 40);
            this.comboStudent.Name = "comboStudent";
            this.comboStudent.Size = new System.Drawing.Size(100, 24);
            this.comboStudent.TabIndex = 20;
            this.comboStudent.ValueMember = "FullName";
            this.comboStudent.SelectedIndexChanged += new System.EventHandler(this.comboStudent_SelectedIndexChanged);
            // 
            // myDataBaseDataSet
            // 
            this.myDataBaseDataSet.DataSetName = "myDataBaseDataSet";
            this.myDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableBindingSource
            // 
            this.studentTableBindingSource.DataMember = "StudentTable";
            this.studentTableBindingSource.DataSource = this.myDataBaseDataSet;
            // 
            // studentTableTableAdapter
            // 
            this.studentTableTableAdapter.ClearBeforeFill = true;
            // 
            // comboClass
            // 
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Location = new System.Drawing.Point(206, 40);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(100, 24);
            this.comboClass.TabIndex = 21;
            this.comboClass.SelectedIndexChanged += new System.EventHandler(this.comboClass_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Class";
            // 
            // lblModule
            // 
            this.lblModule.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblModule.Location = new System.Drawing.Point(209, 151);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(102, 16);
            this.lblModule.TabIndex = 24;
            // 
            // lblLevel
            // 
            this.lblLevel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblLevel.Location = new System.Drawing.Point(12, 151);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(102, 16);
            this.lblLevel.TabIndex = 23;
            // 
            // moduleBindingSource
            // 
            this.moduleBindingSource.DataMember = "Module";
            this.moduleBindingSource.DataSource = this.myDataBaseDataSet;
            // 
            // moduleTableAdapter
            // 
            this.moduleTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateSubjectEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 344);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboClass);
            this.Controls.Add(this.comboStudent);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.comboNewModule);
            this.Controls.Add(this.comboNewLevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateSubjectEnrollment";
            this.Text = "UpdateSubjectEnrollment";
            this.Load += new System.EventHandler(this.UpdateSubjectEnrollment_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.myDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboNewLevel;
        private System.Windows.Forms.ComboBox comboNewModule;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboStudent;
        private myDataBaseDataSet myDataBaseDataSet;
        private System.Windows.Forms.BindingSource studentTableBindingSource;
        private myDataBaseDataSetTableAdapters.StudentTableTableAdapter studentTableTableAdapter;
        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.BindingSource moduleBindingSource;
        private myDataBaseDataSetTableAdapters.ModuleTableAdapter moduleTableAdapter;
    }
}