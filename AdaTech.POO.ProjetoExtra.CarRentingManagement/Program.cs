using AdaTech.POO.ProjetoExtra.CarRentingManagement.Data;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.Services;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.UserInterface;
using System.Runtime.CompilerServices;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            init();

            LandingPage.StartLandingPage();


            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("=AUTOJOURNEY THANKS YOU FOR YOUR VISIT=");
            Console.WriteLine("=======================================");
        }

        private static void init()
        {
            InventoryService.InitRepository();
            EmployeesService.InitRepository();
            CustomersService.InitRepository();
            RentalService.InitRepository();
        }
    }
}
