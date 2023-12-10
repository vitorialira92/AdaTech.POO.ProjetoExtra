using AdaTech.POO.ProjetoExtra.CarRentingManagement.Data;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.User;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Services
{
    internal class InventoryService
    {
        public static void InitRepository() { DataCollector.GetAllVehicles(); }

        public static bool AddVehicle(Vehicle vehicle) { return VehiclesRepository.AddVehicle(vehicle); }

        public static Vehicle GetVehicleById(decimal vehicleId) { return VehiclesRepository.GetVehicleById(vehicleId); }

        public static bool RemoveVehicle(Vehicle vehicle) { return VehiclesRepository.RemoveVehicle(vehicle); }

        public static string ListAllVehicles()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("===================================\n=          AUTOJOURNEY            =" +
                "\n===================================");
            stringBuilder.Append(VehiclesRepository.GetAllVehiclesToString());
            return stringBuilder.ToString();
        }
       
        public static List<Vehicle> GetAllAvailableVehicles() { return VehiclesRepository.GetAllAvailableVehicles(); }
    }
}
