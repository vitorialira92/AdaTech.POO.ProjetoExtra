using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Enums.User;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.User;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.Services;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.UserInterface
{
    internal static class CustomerLandingPage
    {

        private static bool _isCustomerLoggedIn = false;
        private static Customer customerLoggedIn;

        public static void ShowCustomerLandingPage()
        {
            bool endPage = false;

            while (!endPage)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("=          AUTOJOURNEY             =");
                Console.WriteLine("====================================");
                Console.WriteLine("= Welcome! Please choose an option =");
                Console.WriteLine("1 - See all available vehicles");
                Console.WriteLine("2 - Check for a reservation");
                Console.WriteLine("3 - Leave");
                Console.WriteLine("====================================");
                Console.WriteLine("Please enter your choice: ");
                int op = Utils.ReadInteger(1, 3);
                switch (op)
                {
                    case 1:
                        SeeAllAvailableVehicles(); break;
                    case 2:
                        //CustomerLandingPage.ShowCustomerLandingPage(); break;
                    case 0:
                        endPage = true; break;
                }
            }
        }

        private static void ShowAllAvailableVehicles()
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("=          AUTOJOURNEY              =");
            Console.WriteLine("=====================================");
            Console.WriteLine("      ALL AVAILABLE VEHICLES");
            InventoryService.GetAllAvailableVehicles().ForEach(vehicle => { Console.WriteLine(vehicle.ToString() + "\n----"); });
            Console.WriteLine("=====================================");
        }

        private static void ShowAllAvailableVehiclesInTimePeriod(DateTime from, DateTime to)
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("=          AUTOJOURNEY              =");
            Console.WriteLine("=====================================");
            Console.WriteLine("      ALL AVAILABLE VEHICLES");
            InventoryService.GetAllAvailableVehiclesInTimePeriod(from, to).ForEach(vehicle => { Console.WriteLine(vehicle.ToString() + "\n----"); });
            Console.WriteLine("=====================================");
        }


        private static void SeeAllAvailableVehicles()
        {
            ShowAllAvailableVehicles();
           
            Console.WriteLine("Do you want to make a reservation? Type Y or N");
            if (Utils.ReadYOrN())
            {
                
                if (!_isCustomerLoggedIn) 
                {
                    Console.WriteLine("======================================");
                    Console.WriteLine("You'll need to login for that. Do you");
                    Console.WriteLine("have an account? Type Y or N");
                    if (Utils.ReadYOrN())
                    {
                        Login();
                    }
                    else
                    {
                        Register();
                    }
                }
            }
            
        }

        private static void Login()
        {
            bool endPage = false;
            while(!endPage)
            {
                Console.Clear();
                Console.WriteLine("=====================================");
                Console.WriteLine("=          AUTOJOURNEY              =");
                Console.WriteLine("=====================================");
                Console.Write("Type your email: ");
                string email = Utils.ReadString("email");
                Console.WriteLine("Type your password: ");
                string password = Utils.ReadString();

                customerLoggedIn = CustomersService.Login(email, password);

                if (customerLoggedIn != null)
                {
                    _isCustomerLoggedIn = true;
                    Console.Clear();
                    Console.WriteLine("=====================================");
                    Console.WriteLine("=          AUTOJOURNEY              =");
                    Console.WriteLine("=====================================");
                    Console.Write($"Welcome back, {customerLoggedIn.Name}");
                    Thread.Sleep(3000);
                    ShowLoggedInMenu();
                }
            }
            
        }

        private static void Register()
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("=          AUTOJOURNEY              =");
            Console.WriteLine("=====================================");
            Console.Write("Type your name: ");
            string name = Utils.ReadString();
            Console.WriteLine("Type your CPF in the format xxx.xxx.xxx-xx: ");
            string cpf = Utils.ReadString();
            Console.WriteLine("Type your phone number: ");
            string phoneNumber = Utils.ReadString();
            Console.WriteLine("Type your email: ");
            string email = Utils.ReadString("email");
            Console.WriteLine("Type your street: ");
            string street = Utils.ReadString();
            Console.WriteLine("Type your city: ");
            string city = Utils.ReadString();
            Console.WriteLine("Type your state, ex: 'SP': ");
            BrazilStates state = Utils.ReadBrazilState();
            Console.WriteLine("Type your postal code: ");
            string postalCode = Utils.ReadString();
            Console.WriteLine("Now type your new password: ");
            string password = Utils.ReadString();

            Customer customer = new Customer(cpf, name, phoneNumber, email, new Address(street, city, state, postalCode), password);
            if(!CustomersService.AddCustomer(customer))
            {
                Console.WriteLine("=====================================");
                Console.Write("There was an error creating your account. ");
                return;
            }
            customerLoggedIn = customer;
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("=          AUTOJOURNEY              =");
            Console.WriteLine("=====================================");
            Console.WriteLine("=====================================");
            Console.Write($"Hello, {customerLoggedIn.Name}! All set. ");
            Thread.Sleep(3000);
            ShowLoggedInMenu();
        }

        private static void ShowLoggedInMenu()
        {
            Console.Clear();
            Console.WriteLine("=====================================================");
            Console.WriteLine("=                     AUTOJOURNEY                   =");
            Console.WriteLine("=====================================================");
            Console.WriteLine($"= Hello, {customerLoggedIn.Name}                   =");
            Console.WriteLine("Please remind us want operation you'd like to perform");
            Console.WriteLine("1 - Make a reservation");
            Console.WriteLine("2 - See all your reservations");
            Console.WriteLine("3 - Leave");
            int op = Utils.ReadInteger(1,3);
            switch(op)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("=====================================================");
                    Console.WriteLine("=                     AUTOJOURNEY                   =");
                    Console.WriteLine("=====================================================");
                    Console.WriteLine("Would you like to check all available vehicles in");
                    Console.WriteLine("general [1] or would you likt to specify a date [2]?");
                    op = Utils.ReadInteger(1,2);
                    DateTime from, to;
                    switch( op ) { 
                        case 1:
                            ShowAllAvailableVehicles();
                            break;
                        case 2:
                            Console.WriteLine("Please type the initial date in the format dd/mm/yyyy");
                            from = Utils.ReadDateTime("future", DateTime.Now);
                            Console.WriteLine("Please type the end date in the format dd/mm/yyyy");
                            to = Utils.ReadDateTime("future", from);
                            ShowAllAvailableVehiclesInTimePeriod(from, to);
                            break;
                    }
                    Console.WriteLine("Please type the id of the vehicle you'd like to reserve");

                    break;
                case 2:
                    break; 
                case 3: 
                    break;

            }
        }
    }
}
