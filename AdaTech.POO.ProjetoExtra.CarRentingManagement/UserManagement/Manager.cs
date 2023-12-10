using AdaTech.POO.ProjetoExtra.CarRentingManagement.Exceptions;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.RentalManagement.PaymentManagement;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.UserManagement.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.UserManagement
{
    using Exceptions;
    internal class Manager : Employee
    {
        public decimal Bonus { get; private set; }
        public Manager(decimal bonus, decimal id, string CPF, string name, string phoneNumber, string email, 
            Address address, string password, Department department, string position, decimal salary) 
                : base(id, CPF, name, phoneNumber, email, address, password, department, position, salary)
        {
            this.Bonus = bonus;
        }

        public void UpdateBonus(decimal bonus)
        {
            if(bonus == 0)
                throw new EmptyValueException("Bonus cannot be zero.");
            this.Bonus = bonus;
        }


    }
}
