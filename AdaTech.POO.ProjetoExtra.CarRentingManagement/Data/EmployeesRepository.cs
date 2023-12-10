using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Data
{
    internal static class EmployeesRepository
    {
        private static List<Employee> allEmployees = new List<Employee>();
        private static List<Manager> allManagers = new List<Manager>();

        internal static bool AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        internal static bool GetAllEmployeesToString()
        {
            throw new NotImplementedException();
        }

        internal static Employee GetEmployeeByCPF(string employeeCPF)
        {
            throw new NotImplementedException();
        }

        internal static Employee GetEmployeeById(decimal employeeId)
        {
            throw new NotImplementedException();
        }

        internal static bool RemoveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
