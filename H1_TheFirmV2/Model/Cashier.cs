using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirmV2.Model
{
    /// <summary>
    /// Class <see cref="Cashier"/> represents a cashier in a firm, using multiple values
    /// </summary>
    internal class Cashier : Manager
    {
        private bool hasChestPain;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cashier"/> class, using multiple arguments
        /// </summary>
        /// <param name="firstName">first name of the cashier</param>
        /// <param name="lastName">last name of the cashier</param>
        /// <param name="salary">salaray of the cashier</param>
        internal Cashier(string firstName, string lastName, decimal salary) : base(firstName, lastName, salary)
        {
            hasChestPain = true;
        }
    }
}
