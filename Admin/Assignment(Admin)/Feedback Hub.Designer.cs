﻿namespace Assignment_Admin_
{
    partial class Feedback_HUB
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbTrainerID = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstFeedback = new System.Windows.Forms.ListBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trainer ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(331, 89);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbTrainerID
            // 
            this.cmbTrainerID.FormattingEnabled = true;
            this.cmbTrainerID.Location = new System.Drawing.Point(87, 89);
            this.cmbTrainerID.Name = "cmbTrainerID";
            this.cmbTrainerID.Size = new System.Drawing.Size(212, 24);
            this.cmbTrainerID.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(429, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lstFeedback
            // 
            this.lstFeedback.FormattingEnabled = true;
            this.lstFeedback.ItemHeight = 16;
            this.lstFeedback.Location = new System.Drawing.Point(179, 183);
            this.lstFeedback.Name = "lstFeedback";
            this.lstFeedback.Size = new System.Drawing.Size(120, 132);
            this.lstFeedback.TabIndex = 5;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(331, 243);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(-1, 1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(52, 23);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // Feedback_HUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lstFeedback);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbTrainerID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Name = "Feedback_HUB";
            this.Text = "Feedback Hub";
            this.Load += new System.EventHandler(this.Feedback_HUB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbTrainerID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstFeedback;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnHome;
    }
}