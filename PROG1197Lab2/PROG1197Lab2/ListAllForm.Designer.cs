﻿namespace PROG1197Lab2
{
    partial class ListAllForm
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
            this.lstForms = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstForms
            // 
            this.lstForms.BackColor = System.Drawing.SystemColors.Control;
            this.lstForms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstForms.FormattingEnabled = true;
            this.lstForms.Location = new System.Drawing.Point(12, 12);
            this.lstForms.Name = "lstForms";
            this.lstForms.Size = new System.Drawing.Size(271, 156);
            this.lstForms.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(13, 179);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ListAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 211);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstForms);
            this.Name = "ListAllForm";
            this.Text = "All Forms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstForms;
        private System.Windows.Forms.Button btnClose;
    }
}