namespace MovieDb.Forms
{
    partial class AddMovieForm
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
            this.directorsLabel = new System.Windows.Forms.Label();
            this.directorsListbox = new System.Windows.Forms.ListBox();
            this.addDirectorButton = new System.Windows.Forms.Button();
            this.removeDirectorButton = new System.Windows.Forms.Button();
            this.removeActorButton = new System.Windows.Forms.Button();
            this.addActorButton = new System.Windows.Forms.Button();
            this.actorsListbox = new System.Windows.Forms.ListBox();
            this.actorsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // directorsLabel
            // 
            this.directorsLabel.AutoSize = true;
            this.directorsLabel.Location = new System.Drawing.Point(12, 159);
            this.directorsLabel.Name = "directorsLabel";
            this.directorsLabel.Size = new System.Drawing.Size(49, 13);
            this.directorsLabel.TabIndex = 13;
            this.directorsLabel.Text = "Directors";
            // 
            // directorsListbox
            // 
            this.directorsListbox.FormattingEnabled = true;
            this.directorsListbox.Location = new System.Drawing.Point(15, 175);
            this.directorsListbox.Name = "directorsListbox";
            this.directorsListbox.Size = new System.Drawing.Size(177, 69);
            this.directorsListbox.TabIndex = 14;
            // 
            // addDirectorButton
            // 
            this.addDirectorButton.Location = new System.Drawing.Point(199, 175);
            this.addDirectorButton.Name = "addDirectorButton";
            this.addDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.addDirectorButton.TabIndex = 15;
            this.addDirectorButton.Text = "Add";
            this.addDirectorButton.UseVisualStyleBackColor = true;
            this.addDirectorButton.Click += new System.EventHandler(this.addDirectorButton_Click);
            // 
            // removeDirectorButton
            // 
            this.removeDirectorButton.Location = new System.Drawing.Point(199, 204);
            this.removeDirectorButton.Name = "removeDirectorButton";
            this.removeDirectorButton.Size = new System.Drawing.Size(75, 23);
            this.removeDirectorButton.TabIndex = 16;
            this.removeDirectorButton.Text = "Remove";
            this.removeDirectorButton.UseVisualStyleBackColor = true;
            this.removeDirectorButton.Click += new System.EventHandler(this.removeDirectorButton_Click);
            // 
            // removeActorButton
            // 
            this.removeActorButton.Location = new System.Drawing.Point(199, 292);
            this.removeActorButton.Name = "removeActorButton";
            this.removeActorButton.Size = new System.Drawing.Size(75, 23);
            this.removeActorButton.TabIndex = 20;
            this.removeActorButton.Text = "Remove";
            this.removeActorButton.UseVisualStyleBackColor = true;
            this.removeActorButton.Click += new System.EventHandler(this.removeActorButton_Click);
            // 
            // addActorButton
            // 
            this.addActorButton.Location = new System.Drawing.Point(199, 263);
            this.addActorButton.Name = "addActorButton";
            this.addActorButton.Size = new System.Drawing.Size(75, 23);
            this.addActorButton.TabIndex = 19;
            this.addActorButton.Text = "Add";
            this.addActorButton.UseVisualStyleBackColor = true;
            this.addActorButton.Click += new System.EventHandler(this.addActorButton_Click);
            // 
            // actorsListbox
            // 
            this.actorsListbox.FormattingEnabled = true;
            this.actorsListbox.Location = new System.Drawing.Point(15, 263);
            this.actorsListbox.Name = "actorsListbox";
            this.actorsListbox.Size = new System.Drawing.Size(177, 186);
            this.actorsListbox.TabIndex = 18;
            // 
            // actorsLabel
            // 
            this.actorsLabel.AutoSize = true;
            this.actorsLabel.Location = new System.Drawing.Point(12, 247);
            this.actorsLabel.Name = "actorsLabel";
            this.actorsLabel.Size = new System.Drawing.Size(37, 13);
            this.actorsLabel.TabIndex = 17;
            this.actorsLabel.Text = "Actors";
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 516);
            this.Controls.Add(this.removeActorButton);
            this.Controls.Add(this.addActorButton);
            this.Controls.Add(this.actorsListbox);
            this.Controls.Add(this.actorsLabel);
            this.Controls.Add(this.removeDirectorButton);
            this.Controls.Add(this.addDirectorButton);
            this.Controls.Add(this.directorsListbox);
            this.Controls.Add(this.directorsLabel);
            this.Name = "AddMovieForm";
            this.Text = "Add Movie";
            this.Controls.SetChildIndex(this.nameTextbox, 0);
            this.Controls.SetChildIndex(this.yearTextbox, 0);
            this.Controls.SetChildIndex(this.typeCombo, 0);
            this.Controls.SetChildIndex(this.directorsLabel, 0);
            this.Controls.SetChildIndex(this.directorsListbox, 0);
            this.Controls.SetChildIndex(this.addDirectorButton, 0);
            this.Controls.SetChildIndex(this.removeDirectorButton, 0);
            this.Controls.SetChildIndex(this.actorsLabel, 0);
            this.Controls.SetChildIndex(this.actorsListbox, 0);
            this.Controls.SetChildIndex(this.addActorButton, 0);
            this.Controls.SetChildIndex(this.removeActorButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label directorsLabel;
        private System.Windows.Forms.Label actorsLabel;
        protected System.Windows.Forms.ListBox directorsListbox;
        protected System.Windows.Forms.ListBox actorsListbox;
        protected System.Windows.Forms.Button addDirectorButton;
        protected System.Windows.Forms.Button removeDirectorButton;
        protected System.Windows.Forms.Button removeActorButton;
        protected System.Windows.Forms.Button addActorButton;
    }
}