using AdaTech.POO.ProjetoExtra.CarRentingManagement.Data;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Services
{
    internal static class EmployeesService
    {
        public static void InitRepository() { DataCollector.GetAllEmployees(); }

        public static bool AddEmployee(Employee employee) { return EmployeesRepository.AddEmployee(employee); }

        public static Employee GetEmployeeById(decimal employeeId) { return EmployeesRepository.GetEmployeeById(employeeId); }
        public static Employee GetEmployeeByCPF(string employeeCPF) { return EmployeesRepository.GetEmployeeByCPF(employeeCPF); }

        public static bool RemoveEmployee(Employee employee) { return EmployeesRepository.RemoveEmployee(employee); }

        public static string ListAllEmployees()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("===================================\n=          AUTOJOURNEY            =" +
                "\n===================================");
            stringBuilder.Append(EmployeesRepository.GetAllEmployeesToString());
            return stringBuilder.ToString();
        }

        internal static bool AddManager(Manager manager) { return EmployeesRepository.AddManager(manager); }
    }
}
