using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class Employee
    {
        public void AddEmployee()
        {
            try
            {
                // TODO: Insert Logic Need to Written
                Console.WriteLine("Employee Added.");
            }
            catch (Exception ex)
            {

                ErrorLog.WriteLog(new string[] { ex.Message.ToString() });
            }

        }

        public void RemoveEmployee()
        {
            // TODO: Remove Logic Need to Written
            Console.WriteLine("Employee Removed.");
        }

        public void UpdateEmployee()
        {
            // TODO: Update Logic Need to Written
            Console.WriteLine("Employee Removed.");
        }
    }
}
