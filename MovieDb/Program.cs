using MovieDb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MovieDb
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var context = new MovieDbContext("MovieDb");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppForm(context));
        }
    }
}
