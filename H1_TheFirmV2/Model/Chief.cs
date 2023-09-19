using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirmV2.Model
{
    /// <summary>
    /// Class <see cref="Chief"/> represents a chief in a firm, using multiple values
    /// </summary>
    internal class Chief : CFO
    {
        private bool _hasPhone;

        /// <summary>
        /// Initializes a new instance of the <see cref="Chief"/> class, using multiple arguments
        /// </summary>
        /// <param name="firstName">first name of the chief</param>
        /// <param name="lastName">last name of the chief</param>
        /// <param name="salary">salaray of the chief</param>
        internal Chief(string firstName, string lastName, decimal salary) : base(firstName, lastName, salary)
        {
            _hasPhone = true;
        }
    }
}
