﻿namespace MovieDb.Forms.BookForms
{
    partial class EditBookForm
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
            this.SuspendLayout();
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 516);
            this.Name = "EditBookForm";
            this.Text = "Edit Book";
            this.Controls.SetChildIndex(this.nameTextbox, 0);
            this.Controls.SetChildIndex(this.yearTextbox, 0);
            this.Controls.SetChildIndex(this.typeCombo, 0);
            this.Controls.SetChildIndex(this.authorsListbox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}