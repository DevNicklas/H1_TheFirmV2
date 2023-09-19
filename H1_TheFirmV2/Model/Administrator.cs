using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirmV2.Model
{
    /// <summary>
    /// Class <see cref="Administrator"/> represents a administrator in a firm, using multiple values
    /// </summary>
    internal class Administrator : CEO
    {
        private bool _hasCar;

        /// <summary>
        /// Initializes a new instance of the <see cref="Administrator"/> class, using multiple arguments
        /// </summary>
        /// <param name="firstName">first name of the administrator</param>
        /// <param name="lastName">last name of the administrator</param>
        /// <param name="salary">salaray of the administrator</param>
        internal Administrator(string firstName, string lastName, decimal salary) : base(firstName, lastName, salary)
        {
            _hasCar = true;
        }
    }
}
