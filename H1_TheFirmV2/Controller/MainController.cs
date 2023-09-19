using H1_TheFirmV2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirmV2.Controller
{
    /// <summary>
    /// Class <see cref="MainController"/> controls the whole program
    /// </summary>
    internal class MainController
    {
        /// <summary>
        /// Starts the controller
        /// </summary>
        public void Start()
        {
            CEO ceo = new CEO("Rasmus", "Frederiksen", 110000);
            CFO cfo = new CFO("Silas", "Rasmussen", 75000);
            COO coo = new COO("Karl", "Haraldsen", 72000);
            Chief chief1 = new Chief("Anders", "Mikkelsen", 65000);
            Chief chief2 = new Chief("Carl", "Mikkelsen", 64000);
            Manager manager1 = new Manager("Silas", "Timber", 50000);
            Manager manager2 = new Manager("Andreas", "Timber", 49000);
            Manager manager3 = new Manager("Erik", "Jakobsen", 52000);
            Manager manager4 = new Manager("Jakob", "Eriksen", 50000);
            Cashier cashier1 = new Cashier("Rico", "Olsen", 36000);
            Cashier cashier2 = new Cashier("Ole", "Frederiksen", 36000);
            Cashier cashier3 = new Cashier("Peter", "Gerdo", 36000);
            Cashier cashier4 = new Cashier("Ulrik", "Schmidt", 36000);
            Cashier cashier5 = new Cashier("Freja", "Lodbrog", 36000);
            Cashier cashier6 = new Cashier("Andrea", "Olsen", 36000);
            Cashier cashier7 = new Cashier("Anders", "Gerdo", 36000);
            Cashier cashier8 = new Cashier("Ulrik", "Schmidt", 36000);
        }
    }
}
