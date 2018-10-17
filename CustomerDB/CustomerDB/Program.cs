/*
 * Author      : Jackson Currie
 * Email       : 30005345@student.toiohomai.ac.nz
 * Last Edited : 16th October 2018
 * Description : Main program for the Customer Database
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerDB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CustomerDetails());
        }
    }
}
