using H1_TheFirmV2.Controller;
using H1_TheFirmV2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirmV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainController mainCtrl = new MainController();
            mainCtrl.Start();

            Console.ReadLine();
        }
    }
}
