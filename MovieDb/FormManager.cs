using MovieDb.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieDb
{
    /// <summary>
    /// Simple class to create, close and switch between forms
    /// </summary>
    static class AddFormManager
    {
        private static FormClosingEventHandler m_callback;
        private static Form m_form;

        public static void AddForm(Form form, FormClosingEventHandler callback)
        {
            m_form = form;
            m_callback = callback;
        }

        public static void CloseForm()
        {
            try
            {
                m_form.FormClosing += m_callback;
                m_form.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot remove form.");
                return;
            }
        }

        public static void SwitchForm(Form newForm)
        {
            if (m_form == null)
                return;
            m_form.Close();
            m_form = newForm;
        }
    }
}
