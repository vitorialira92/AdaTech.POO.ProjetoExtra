using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.User
{
    using AdaTech.POO.ProjetoExtra.CarRentingManagement.Exceptions;
    using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Enums.User;
    using Enums;

    internal class Employee : Person
    {

        protected decimal MinimumSalary = 1500;

        public Employee(decimal id, string CPF, string name, string phoneNumber,
            string email, Address address, string password, Department department, string position, decimal salary)
                : base(id, CPF, name, phoneNumber, email, address, password)
        {
            Department = department;
            Position = position;
            Salary = salary;
        }

        public Employee(decimal id, string CPF, string name, string phoneNumber,
            string email, Address address, string password, string mode, Department department, string position, decimal salary)
                : base(id, CPF, name, phoneNumber, email, address, password, mode)
        {
            Department = department;
            Position = position;
            Salary = salary;
        }

        public Department Department { get; private set; }
        public string Position { get; private set; }
        public decimal Salary { get; private set; }

        public void UpdateSalary(decimal salary)
        {
            if (salary == 0)
                throw new InvalidValueException("Salary cannot be zero.");

            if (!IsSalaryBeyondMinimum(salary))
                throw new InvalidValueException("Salary cannot be zero.");

            Salary = salary;
        }

        public override string ToString()
        {
            string employee = $"Employee {Name} ID {Id}| {Department.ToString()} : {Position} | Salary a year $${Salary}";

            return employee;
        }

        public void UpdatePosition(string position)
        {
            Position = position;
        }

        public void UpdateDepartment(Department newDepartment, string newPosition)
        {
            UpdatePosition(newPosition);
            Department = newDepartment;
        }

        public bool IsSalaryBeyondMinimum(decimal salary)
        {
            return salary >= MinimumSalary;
        }
    }
}
