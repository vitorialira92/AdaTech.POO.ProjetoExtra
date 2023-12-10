using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Rental.PaymentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.User
{
    internal class Vehicle : Person
    {
        List<CreditCard> savedCreditCards = new List<CreditCard>();
        public Vehicle(decimal id, string CPF, string name, string phoneNumber, string email,
                    Address address, string password) : base(id, CPF, name, phoneNumber, email, address, password)
        {

        }
        public Vehicle(decimal id, string CPF, string name, string phoneNumber, string email,
                    Address address, string password, string mode) : base(id, CPF, name, phoneNumber, email, address, password, mode)
        {

        }

        public override string ToString()
        {
            return $"Costumer {Name} | {CPF}";
        }
    }
}
