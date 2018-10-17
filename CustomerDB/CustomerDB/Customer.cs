/*
 * Author      : Jackson Currie
 * Email       : 30005345@student.toiohomai.ac.nz
 * Last Edited : 17th October 2018
 * Description : Class for customers to be added to the database
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDB
{
    class Customer
    {
        // Auto implemented properties
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }

        // Constructor
        public Customer(string fn, string ln, string ph)
        {
            FName = fn;
            LName = ln;
            Phone = ph;
        }

        // Returning data method
        public string GetCustomer()
        {
            return FName + "\t\t" + LName + "\t\t" + Phone;
        }
    }
}
