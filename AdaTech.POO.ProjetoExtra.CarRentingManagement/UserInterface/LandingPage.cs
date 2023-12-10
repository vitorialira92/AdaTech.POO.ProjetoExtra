using AdaTech.POO.ProjetoExtra.CarRentingManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.UserInterface
{
    internal static class LandingPage
    {
        public static void StartLandingPage()
        {
            bool endPage = false;

            while(!endPage)
            {
                Console.Clear();
                Console.WriteLine("===================================");
                Console.WriteLine("=          AUTOJOURNEY            =");
                Console.WriteLine("===================================");
                Console.WriteLine("= Welcome! You come here as a...? =");
                Console.WriteLine("1 - Employee");
                Console.WriteLine("2 - Customer");
                Console.WriteLine("0 - Leave");
                Console.WriteLine("===================================");
                Console.WriteLine("Please enter your choice: ");
                int op = Utils.ReadInteger(0, 2);
                switch (op)
                {
                    case 1:
                        EmployeeLandingPage.ShowEmployeeLandingPage(); break;
                    case 2:
                        CustomerLandingPage.ShowCustomerLandingPage(); break;
                    case 0:
                        endPage = true; break;
                }
            }
            
        }
    }
}
