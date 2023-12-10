using AdaTech.POO.ProjetoExtra.CarRentingManagement.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.UserInterface.EmployeeInterface
{
    internal static class EmployeeDataDealing
    {
        private static Employee TryToLogin(string email, string password)
        {
            Employee employee = EmployeesManagement.Login(email, password);
           
            return employee;
        }
    }
}
