using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Enums.Vehicle;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.User;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Vehicles;
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
        public static List<Vehicle> GetAllAvailableVehicles()
        {
            List<Vehicle> availableVehicles = new List<Vehicle>();

            foreach (Vehicle vehicle in allVehicles)
            {
                if (vehicle.GetCarStatus().Equals(CarStatus.Available))
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

        internal static bool AddVehicle(Vehicle vehicle)
        {
            if (vehicle == null) return false;
            allVehicles.Add(vehicle); return true;
        }

        internal static List<Vehicle> GetAllReservedVehicles()
        {
            List<Vehicle> reservedVehicles = new List<Vehicle>();

            foreach (Vehicle vehicle in allVehicles)
            {
                if (vehicle.GetCarStatus().Equals(CarStatus.Reserved))
                    reservedVehicles.Add(vehicle);
            }

            return reservedVehicles;
        }

        internal static string GetAllVehiclesToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("===================================\n" +
                        "=          AUTOJOURNEY            =");
            foreach(Vehicle vehicle in allVehicles)
            {
                sb.Append(vehicle.ToString() + "\n===================================\n");
            }

            return sb.ToString();
        }

        internal static bool RemoveVehicle(Vehicle vehicle)
        {
            if (allVehicles.Contains(vehicle))
            {
                allVehicles.Remove(vehicle);
                return true;
            }
            return false;
        }
    }
}
