using System;
using DVLD_Business;

namespace DVLD_ConsoleApp_Presentation
{
    internal class clsTestConsole
    {
        static void Main(string[] args)
        {
            string message = clsTestBus.getTestData();

            Console.WriteLine(message);

        }
    }
}
