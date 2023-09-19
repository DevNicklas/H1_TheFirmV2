using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirmV2.Model
{
    /// <summary>
    /// Class <see cref="Manager"/> represents a manager in a firm, using multiple values
    /// </summary>
    internal class Manager : Chief
    {
        private bool _hasCheckboard;

        /// <summary>
        /// Initializes a new instance of the <see cref="Manager"/> class, using multiple arguments
        /// </summary>
        /// <param name="firstName">first name of the manager</param>
        /// <param name="lastName">last name of the manager</param>
        /// <param name="salary">salaray of the manager</param>
        internal Manager(string firstName, string lastName, decimal salary) : base(firstName, lastName, salary)
        {
            _hasCheckboard = true;
        }
    }
}
