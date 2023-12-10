using AdaTech.POO.ProjetoExtra.CarRentingManagement.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.UserInterface.EmployeeInterface
{
    internal static class EmployeeInterface
    {
        private static Employee loggedEmployee;
        public static void LoadEmployeeInterface()
        {
            bool leaveEmployeeInterface = false;

            while(!leaveEmployeeInterface)
            {
                leaveEmployeeInterface = InitialMenu();
            }
        }

        private static bool InitialMenu() 
        {
            bool leaveInitialMenu = false;
            while(!leaveInitialMenu)
            {
                Console.Clear();
                Console.WriteLine("===================================");
                Console.WriteLine("=          AUTOJOURNEY            =");
                Console.WriteLine("=    EMPLOYEES' LOGIN SYSTEM      =");
                Console.WriteLine("===================================");
                Console.WriteLine("1 - Login");
                Console.WriteLine("0 - Leave");
                Console.WriteLine("===================================");
                Console.WriteLine("Please enter your choice: ");
                int op = Utils.ReadInteger(0, 1);
                if (op == 1)
                    LoginMenu();
                else
                    leaveInitialMenu = true;
            }

            return false;

        }

        private static bool LoginMenu()
        {

            bool leaveInitialMenu = false;
            while (!leaveInitialMenu)
            {
                Console.Clear();
                Console.WriteLine("===================================");
                Console.WriteLine("=          AUTOJOURNEY            =");
                Console.WriteLine("=    EMPLOYEES' LOGIN SYSTEM      =");
                Console.WriteLine("===================================");
                Console.WriteLine("===================================");
                Console.WriteLine("Please type your email: ");
                string email = Utils.ReadString("email");
                Console.WriteLine("===================================");
                Console.WriteLine("Please type your password: ");
                string password = Utils.ReadString();

                return TryToLogin(email, password);
                else
                    leaveInitialMenu = true;
            }

            return false;
            


        }

        
   
        private static void ShowWrongLoginInformationScreen()
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("=          AUTOJOURNEY            =");
            Console.WriteLine("=    EMPLOYEES' LOGIN SYSTEM      =");
            Console.WriteLine("===================================");
            Console.WriteLine("===================================");
            Console.WriteLine("Your login information is incorrent");
            Console.WriteLine("Would you like to try again? Type y or n");
        }
    }
}
