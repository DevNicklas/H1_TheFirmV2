using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirmV2.Model
{
    /// <summary>
    /// Class <see cref="HR"/> represents a HR in a firm, using multiple values
    /// </summary>
    internal class HR : CEO
    {
        private bool _hasCar;

        /// <summary>
        /// Initializes a new instance of the <see cref="HR"/> class, using multiple arguments
        /// </summary>
        /// <param name="firstName">first name of the HR</param>
        /// <param name="lastName">last name of the HR</param>
        /// <param name="salary">salaray of the HR</param>
        internal HR(string firstName, string lastName, decimal salary) : base(firstName, lastName, salary)
        {
            _hasCar = true;
        }
    }
}
