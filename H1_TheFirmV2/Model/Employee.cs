using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirmV2.Model
{
    /// <summary>
    /// Class <see cref="Employee"/> represents a employee in a firm, using multiple values
    /// </summary>
    internal class Employee
    {
        protected string firstName;
        protected string lastName;
        protected decimal salary;

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class, using multiple arguments
        /// </summary>
        /// <param name="firstName">first name of the employee</param>
        /// <param name="lastName">last name of the employee</param>
        /// <param name="salary">salaray of the employee</param>
        protected Employee(string firstName, string lastName, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }
    }
}
