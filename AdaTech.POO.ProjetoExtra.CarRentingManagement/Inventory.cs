using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement
{
    using AdaTech.POO.ProjetoExtra.CarRentingManagement.VehicleManagement;
    internal static class Inventory
    {
        private static List<Vehicle> allVehicles;
        private static List<decimal> rentedVehiclesId;

        public static List<Vehicle> AllVehicles() {  return allVehicles; }

        public static List<Vehicle> AllAvailableVehicles()
        {
            List<Vehicle> availableVehicles = new List<Vehicle>();

            foreach (Vehicle vehicle in allVehicles)
            {
                if(!rentedVehiclesId.Contains(vehicle.Id))
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
