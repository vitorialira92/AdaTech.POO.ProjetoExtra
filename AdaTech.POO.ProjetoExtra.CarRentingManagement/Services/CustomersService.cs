using AdaTech.POO.ProjetoExtra.CarRentingManagement.Data;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.UserManagement.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Services
{
    internal class VehiclesService
    {
        public static void InitRepository() { DataCollector.GetAllVehicles(); }

        public static bool AddVehicle(Vehicle Vehicle) { return VehiclesRepository.AddVehicle(Vehicle); }

        public static Vehicle GetVehicleById(decimal VehicleId) { return VehiclesRepository.GetVehicleById(VehicleId); }
        public static Vehicle GetVehicleByCPF(string VehicleCPF) { return VehiclesRepository.GetVehicleByCPF(VehicleCPF); }

        public static bool RemoveVehicle(Vehicle Vehicle) { return VehiclesRepository.RemoveVehicle(Vehicle); }

        public static string ListAllVehicles()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("===================================\n=          AUTOJOURNEY            =" +
                "\n===================================");
            stringBuilder.Append(VehiclesRepository.GetAllVehiclesToString());
            return stringBuilder.ToString();
        }
    }
}
