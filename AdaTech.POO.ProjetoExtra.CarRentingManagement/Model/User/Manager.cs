using AdaTech.POO.ProjetoExtra.CarRentingManagement.Exceptions;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.RentalManagement.PaymentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.User
{
    using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Enums.User;
    using Exceptions;
    internal class Manager : Employee
    {
        public decimal Bonus { get; private set; }
        public Manager(decimal bonus, decimal id, string CPF, string name, string phoneNumber, string email,
            Address address, string password, Department department, string position, decimal salary)
                : base(id, CPF, name, phoneNumber, email, address, password, department, position, salary)
        {
            Bonus = bonus;
            MinimumSalary = 3000;
        }

        public Manager(decimal bonus, decimal id, string CPF, string name, string phoneNumber, string email,
            Address address, string password, string mode, Department department, string position, decimal salary)
                : base(id, CPF, name, phoneNumber, email, address, password, mode, department, position, salary)
        {
            Bonus = bonus;
            MinimumSalary = 3000;
        }

        public void UpdateBonus(decimal bonus)
        {
            if (bonus == 0)
                throw new InvalidValueException("Bonus cannot be zero.");
            Bonus = bonus;
        }

        public override string ToString()
        {
            string manager = $"Manager {Name} ID {Id}| {Department.ToString()} : {Position}";

            return manager;
        }
    }
}
