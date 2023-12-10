using AdaTech.POO.ProjetoExtra.CarRentingManagement.Data;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.RentalManagement;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.UserManagement.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Services
{
    internal class RentalService
    {
        public static void InitRepository() { DataCollector.GetAllRentals(); }

        public static bool AddRental(Rental Rental) { return RentalRepository.AddRental(Rental); }

        public static Rental GetRentalById(decimal rentalId) { return RentalRepository.GetRentalById(rentalId); }
        public static Rental GetRentalByVehicleId(string VehicleId) { return RentalRepository.GetRentalByVehicleId(VehicleId); }

        public static bool RemoveRental(Rental rental) { return RentalRepository.RemoveRental(rental); }

        public static string ListAllRentals()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("===================================\n=          AUTOJOURNEY            =" +
                "\n===================================");
            stringBuilder.Append(RentalRepository.GetAllRentalsToString());
            return stringBuilder.ToString();
        }
    }
}
