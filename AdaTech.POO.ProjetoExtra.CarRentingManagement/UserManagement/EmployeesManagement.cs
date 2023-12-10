using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.UserManagement
{
    internal class EmployeesManagement
    {
        private static List<Employee> employees;

        internal static Employee Login(string email, string password)
        {
            foreach (var employee in employees)
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
