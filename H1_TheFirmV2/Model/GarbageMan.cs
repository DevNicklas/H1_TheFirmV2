using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirmV2.Model
{
    /// <summary>
    /// Class <see cref="GarbageMan"/> represents a garbage man in a firm, using multiple values
    /// </summary>
    internal class GarbageMan : Manager
    {
        private bool _hasGarbageBag;

        /// <summary>
        /// Initializes a new instance of the <see cref="GarbageMan"/> class, using multiple arguments
        /// </summary>
        /// <param name="firstName">first name of the garbage man</param>
        /// <param name="lastName">last name of the garbage man</param>
        /// <param name="salary">salaray of the garbage man</param>
        internal GarbageMan(string firstName, string lastName, decimal salary) : base(firstName, lastName, salary)
        {
            _hasGarbageBag = true;
        }
    }
}
