using System.Windows.Forms;
namespace MovieDb
{
    partial class AppForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.entryList = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YearHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.moviesCheckBox = new System.Windows.Forms.CheckBox();
            this.booksCheckBox = new System.Windows.Forms.CheckBox();
            this.yearMinTextbox = new System.Windows.Forms.TextBox();
            this.yearMaxTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(439, 325);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 31);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.Add_Click);
            // 
            // entryList
            // 
            this.entryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.TypeHeader,
            this.YearHeader});
            this.entryList.Location = new System.Drawing.Point(13, 51);
            this.entryList.Name = "entryList";
            this.entryList.Size = new System.Drawing.Size(420, 453);
            this.entryList.TabIndex = 2;
            this.entryList.UseCompatibleStateImageBehavior = false;
            this.entryList.View = System.Windows.Forms.View.Details;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 200;
            // 
            // TypeHeader
            // 
            this.TypeHeader.Text = "Type";
            // 
            // YearHeader
            // 
            this.YearHeader.Text = "Year";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(439, 399);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(114, 31);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(439, 362);
            this.editButton.Name = "editButton";
            this.editButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editButton.Size = new System.Drawing.Size(114, 31);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 25);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(192, 20);
            this.searchBox.TabIndex = 5;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(10, 9);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(41, 13);
            this.searchLabel.TabIndex = 6;
            this.searchLabel.Text = "Search";
            // 
            // moviesCheckBox
            // 
            this.moviesCheckBox.AutoSize = true;
            this.moviesCheckBox.Location = new System.Drawing.Point(439, 51);
            this.moviesCheckBox.Name = "moviesCheckBox";
            this.moviesCheckBox.Size = new System.Drawing.Size(60, 17);
            this.moviesCheckBox.TabIndex = 7;
            this.moviesCheckBox.Text = "Movies";
            this.moviesCheckBox.UseVisualStyleBackColor = true;
            this.moviesCheckBox.CheckedChanged += new System.EventHandler(this.moviesCheckBox_CheckedChanged);
            // 
            // booksCheckBox
            // 
            this.booksCheckBox.AutoSize = true;
            this.booksCheckBox.Location = new System.Drawing.Point(439, 74);
            this.booksCheckBox.Name = "booksCheckBox";
            this.booksCheckBox.Size = new System.Drawing.Size(56, 17);
            this.booksCheckBox.TabIndex = 8;
            this.booksCheckBox.Text = "Books";
            this.booksCheckBox.UseVisualStyleBackColor = true;
            this.booksCheckBox.CheckedChanged += new System.EventHandler(this.booksCheckBox_CheckedChanged);
            // 
            // yearMinTextbox
            // 
            this.yearMinTextbox.Location = new System.Drawing.Point(210, 25);
            this.yearMinTextbox.Name = "yearMinTextbox";
            this.yearMinTextbox.Size = new System.Drawing.Size(54, 20);
            this.yearMinTextbox.TabIndex = 9;
            this.yearMinTextbox.TextChanged += new System.EventHandler(this.yearMinTextbox_TextChanged);
            this.yearMinTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearMinTextbox_KeyPress);
            // 
            // yearMaxTextbox
            // 
            this.yearMaxTextbox.Location = new System.Drawing.Point(270, 25);
            this.yearMaxTextbox.Name = "yearMaxTextbox";
            this.yearMaxTextbox.Size = new System.Drawing.Size(54, 20);
            this.yearMaxTextbox.TabIndex = 10;
            this.yearMaxTextbox.TextChanged += new System.EventHandler(this.yearMaxTextbox_TextChanged);
            this.yearMaxTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearMaxTextbox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Year";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(439, 473);
            this.exitButton.Name = "exitButton";
            this.exitButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.exitButton.Size = new System.Drawing.Size(114, 31);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 516);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearMaxTextbox);
            this.Controls.Add(this.yearMinTextbox);
            this.Controls.Add(this.booksCheckBox);
            this.Controls.Add(this.moviesCheckBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.entryList);
            this.Controls.Add(this.addButton);
            this.Name = "AppForm";
            this.Text = "Movie Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListView entryList;
        private ColumnHeader NameHeader;
        private ColumnHeader TypeHeader;
        private ColumnHeader YearHeader;
        private Button removeButton;
        private Button editButton;
        private TextBox searchBox;
        private Label searchLabel;
        private CheckBox moviesCheckBox;
        private CheckBox booksCheckBox;
        private TextBox yearMinTextbox;
        private TextBox yearMaxTextbox;
        private Label label1;
        private Button exitButton;
    }
}

