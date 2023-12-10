using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Rentals;
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
        private static List<Employee> _allEmployees = new List<Employee>();
        private static List<Manager> _allManagers = new List<Manager>();

        internal static bool AddEmployee(Employee employee)
        {
            if (employee == null) return false;
            _allEmployees.Add(employee); return true;
        }

        internal static bool AddManager(Manager manager)
        {
            if (manager == null) return false;
            _allManagers.Add(manager); return true;
        }

        internal static string GetAllEmployeesToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("===================================\n" +
                        "=          AUTOJOURNEY            =");
            foreach (Employee employee in _allEmployees)
            {
                sb.Append(employee.ToString() + "\n===================================\n");
            }

            foreach (Manager manager in _allManagers)
            {
                sb.Append(manager.ToString() + "\n===================================\n");
            }


            return sb.ToString();
        }

        internal static Employee GetEmployeeByCPF(string employeeCPF)
        {
            foreach (Employee employee in _allEmployees)
            {
                if(employee.CPF == employeeCPF) return employee;
            }

            foreach (Manager manager in _allManagers)
            {
                if(manager.CPF == employeeCPF) return manager;
            }
            return null;
        }


        internal static Employee GetEmployeeById(decimal employeeId)
        {
            foreach (Employee employee in _allEmployees)
            {
                if (employee.Id == employeeId) return employee;
            }

            foreach (Manager manager in _allManagers)
            {
                if (manager.Id == employeeId) return manager;
            }
            return null;
        }

        internal static bool RemoveEmployee(Employee employee)
        {
            if(employee == null) return false;
            if (_allEmployees.Contains(employee)) { _allEmployees.Remove(employee); return true; } 

            return false;
        }

        internal static bool RemoveManager(Manager employee)
        {
            if (employee == null) return false;
            if (_allManagers.Contains(employee)) { _allManagers.Remove(employee); return true; }

            return false;
        }

        internal static Employee Login(string email, string password)
        {
            foreach (var employee in _allEmployees)
            {
                if (employee.Email.Equals(email.ToLower()))
                {
                    if (employee.CheckPassword(password))
                        return employee;
                    return null;
                }
            }

            foreach (var employee in _allManagers)
            {
                if (employee.Email.Equals(email.ToLower()))
                {
                    if (employee.CheckPassword(password))
                        return employee;
                    return null;
                }
            }

            return null;
        }
    }
}
