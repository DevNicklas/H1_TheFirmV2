using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirmV2.Model
{
    /// <summary>
    /// Class <see cref="CFO"/> represents a CFO in a firm, using multiple values
    /// </summary>
    internal class CFO : CEO
    {
        private bool _hasCar;

        /// <summary>
        /// Initializes a new instance of the <see cref="CFO"/> class, using multiple arguments
        /// </summary>
        /// <param name="firstName">first name of the CFO</param>
        /// <param name="lastName">last name of the CFO</param>
        /// <param name="salary">salaray of the CFO</param>
        internal CFO(string firstName, string lastName, decimal salary) : base(firstName, lastName, salary)
        {
            _hasCar = true;
        }
    }
}
