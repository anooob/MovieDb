namespace MovieDb.Forms
{
    partial class AddFormBase
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
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.yearTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Location = new System.Drawing.Point(15, 95);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(177, 21);
            this.typeCombo.TabIndex = 15;
            // 
            // yearTextbox
            // 
            this.yearTextbox.Location = new System.Drawing.Point(15, 135);
            this.yearTextbox.Name = "yearTextbox";
            this.yearTextbox.Size = new System.Drawing.Size(54, 20);
            this.yearTextbox.TabIndex = 14;
            this.yearTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearTextbox_KeyPress);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(15, 58);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(177, 20);
            this.nameTextbox.TabIndex = 13;
            // 
            // AddFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 516);
            this.Controls.Add(this.typeCombo);
            this.Controls.Add(this.yearTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Name = "AddFormBase";
            this.Text = "AddFormBase";
            this.Controls.SetChildIndex(this.nameTextbox, 0);
            this.Controls.SetChildIndex(this.yearTextbox, 0);
            this.Controls.SetChildIndex(this.typeCombo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ComboBox typeCombo;
        protected System.Windows.Forms.TextBox yearTextbox;
        protected System.Windows.Forms.TextBox nameTextbox;
    }
}