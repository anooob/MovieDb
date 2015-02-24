namespace MovieDb.Forms
{
    partial class AddAuthorForm
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
            this.authorsListbox = new System.Windows.Forms.ListBox();
            this.newAuthorButton = new System.Windows.Forms.Button();
            this.removeAuthorButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authorsListbox
            // 
            this.authorsListbox.FormattingEnabled = true;
            this.authorsListbox.Location = new System.Drawing.Point(15, 54);
            this.authorsListbox.Name = "authorsListbox";
            this.authorsListbox.Size = new System.Drawing.Size(235, 342);
            this.authorsListbox.TabIndex = 1;
            // 
            // newAuthorButton
            // 
            this.newAuthorButton.Location = new System.Drawing.Point(256, 54);
            this.newAuthorButton.Name = "newAuthorButton";
            this.newAuthorButton.Size = new System.Drawing.Size(75, 23);
            this.newAuthorButton.TabIndex = 2;
            this.newAuthorButton.Text = "New";
            this.newAuthorButton.UseVisualStyleBackColor = true;
            this.newAuthorButton.Click += new System.EventHandler(this.newAuthorButton_Click);
            // 
            // removeAuthorButton
            // 
            this.removeAuthorButton.Location = new System.Drawing.Point(256, 83);
            this.removeAuthorButton.Name = "removeAuthorButton";
            this.removeAuthorButton.Size = new System.Drawing.Size(75, 23);
            this.removeAuthorButton.TabIndex = 3;
            this.removeAuthorButton.Text = "Remove";
            this.removeAuthorButton.UseVisualStyleBackColor = true;
            this.removeAuthorButton.Click += new System.EventHandler(this.removeAuthorButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(256, 396);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(337, 396);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(15, 25);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(235, 20);
            this.searchTextbox.TabIndex = 6;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 9);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(41, 13);
            this.searchLabel.TabIndex = 7;
            this.searchLabel.Text = "Search";
            // 
            // AddAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 431);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.removeAuthorButton);
            this.Controls.Add(this.newAuthorButton);
            this.Controls.Add(this.authorsListbox);
            this.Name = "AddAuthorForm";
            this.Text = "Select Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox authorsListbox;
        private System.Windows.Forms.Button newAuthorButton;
        private System.Windows.Forms.Button removeAuthorButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Label searchLabel;
    }
}