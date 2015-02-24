namespace MovieDb.Forms.BookForms
{
    partial class AddBookForm
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
            this.authorsLabel = new System.Windows.Forms.Label();
            this.removeAuthorButton = new System.Windows.Forms.Button();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.authorsListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // authorsLabel
            // 
            this.authorsLabel.AutoSize = true;
            this.authorsLabel.Location = new System.Drawing.Point(12, 158);
            this.authorsLabel.Name = "authorsLabel";
            this.authorsLabel.Size = new System.Drawing.Size(43, 13);
            this.authorsLabel.TabIndex = 16;
            this.authorsLabel.Text = "Authors";
            // 
            // removeAuthorButton
            // 
            this.removeAuthorButton.Location = new System.Drawing.Point(199, 203);
            this.removeAuthorButton.Name = "removeAuthorButton";
            this.removeAuthorButton.Size = new System.Drawing.Size(75, 23);
            this.removeAuthorButton.TabIndex = 19;
            this.removeAuthorButton.Text = "Remove";
            this.removeAuthorButton.UseVisualStyleBackColor = true;
            this.removeAuthorButton.Click += new System.EventHandler(this.removeAuthorButton_Click);
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.Location = new System.Drawing.Point(199, 174);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(75, 23);
            this.addAuthorButton.TabIndex = 18;
            this.addAuthorButton.Text = "Add";
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // authorsListbox
            // 
            this.authorsListbox.Location = new System.Drawing.Point(15, 174);
            this.authorsListbox.Name = "authorsListbox";
            this.authorsListbox.Size = new System.Drawing.Size(177, 69);
            this.authorsListbox.TabIndex = 17;
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 516);
            this.Controls.Add(this.removeAuthorButton);
            this.Controls.Add(this.addAuthorButton);
            this.Controls.Add(this.authorsListbox);
            this.Controls.Add(this.authorsLabel);
            this.Name = "AddBookForm";
            this.Text = "Add Book";
            this.Controls.SetChildIndex(this.nameTextbox, 0);
            this.Controls.SetChildIndex(this.yearTextbox, 0);
            this.Controls.SetChildIndex(this.typeCombo, 0);
            this.Controls.SetChildIndex(this.authorsLabel, 0);
            this.Controls.SetChildIndex(this.authorsListbox, 0);
            this.Controls.SetChildIndex(this.addAuthorButton, 0);
            this.Controls.SetChildIndex(this.removeAuthorButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authorsLabel;
        private System.Windows.Forms.Button removeAuthorButton;
        private System.Windows.Forms.Button addAuthorButton;
        protected System.Windows.Forms.ListBox authorsListbox;
    }
}