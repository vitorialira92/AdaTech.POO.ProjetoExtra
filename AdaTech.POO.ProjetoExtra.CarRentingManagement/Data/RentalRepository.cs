using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Rentals;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.User;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Data
{
    internal class RentalRepository
    {
        private static List<Rental> _allRentals = new List<Rental>();
        internal static bool AddRental(Rental rental)
        {
            if (rental == null) return false;
            _allRentals.Add(rental); return true;
        }

        internal static string GetAllRentalsToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("===================================\n" +
                        "=          AUTOJOURNEY            =");
            foreach (Rental rental in _allRentals)
            {
                sb.Append(rental.ToString() + "\n===================================\n");
            }

            return sb.ToString();
        }

        internal static List<Rental> GetRentalsByVehicleId(decimal VehicleId)
        {
            List<Rental> rentals = new List<Rental>();
            foreach(Rental rental in _allRentals)
            {
                if(rental.VehicleId.Equals(VehicleId))
                    rentals.Add(rental);
            }
            return rentals;
        }

        internal static Rental GetRentalById(decimal rentalId)
        {
            foreach (Rental rental in _allRentals)
            {
                if (rental.Id.Equals(rentalId))
                    return rental;
            }
            return null;
        }

        internal static bool RemoveRental(Rental rental)
        {
            if(rental == null) return false;
            _allRentals.Remove(rental); return true;
        }
    }
}
