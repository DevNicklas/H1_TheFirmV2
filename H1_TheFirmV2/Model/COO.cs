using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirmV2.Model
{
    /// <summary>
    /// Class <see cref="COO"/> represents a COO in a firm, using multiple values
    /// </summary>
    internal class COO : CEO
    {
        private bool _hasCar;

        /// <summary>
        /// Initializes a new instance of the <see cref="COO"/> class, using multiple arguments
        /// </summary>
        /// <param name="firstName">first name of the COO</param>
        /// <param name="lastName">last name of the COO</param>
        /// <param name="salary">salaray of the COO</param>
        internal COO(string firstName, string lastName, decimal salary) : base(firstName, lastName, salary)
        {
            _hasCar = true;
        }
    }
}
