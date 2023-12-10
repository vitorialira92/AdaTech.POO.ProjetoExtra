using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Data
{
    internal static class VehiclesRepository
    {
        private static List<Vehicle> allVehicles = new List<Vehicle>();
        public static List<Vehicle> AllAvailableVehicles()
        {
            List<Vehicle> availableVehicles = new List<Vehicle>();

            foreach (Vehicle vehicle in allVehicles)
            {
                if (!rentedVehiclesId.Contains(vehicle.Id))
                    availableVehicles.Add(vehicle);
            }

            return availableVehicles;
        }

        public static Vehicle GetVehicleById(decimal vehicleId)
        {

            return allVehicles.FirstOrDefault(x => x.Id.Equals(vehicleId));
        }

        public static double GetVehiclePricePerDayById(decimal id)
        {
            foreach (Vehicle vehicle in allVehicles)
            {
                if (vehicle.Id == id)
                {
                    return vehicle.PricePerDay;
                }
            }

            return 0;
        }
    }
}
