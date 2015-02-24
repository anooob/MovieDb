using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieDb.Forms
{
    public partial class DetailFormBase : Form
    {
        public DetailFormBase()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            OnOk();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            OnCancel();
        }

        protected virtual void OnOk()
        { 
        
        }

        protected virtual void OnCancel()
        { 
        
        }


    }
}
