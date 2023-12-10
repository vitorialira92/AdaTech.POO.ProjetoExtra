using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Rentals.PaymentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.User
{
    internal class Customer : Person
    {
        List<CreditCard> savedCreditCards = new List<CreditCard>();
        public Customer(string CPF, string name, string phoneNumber, string email,
                    Address address, string password) : base( CPF, name, phoneNumber, email, address, password)
        {

        }
        public Customer(decimal id, string CPF, string name, string phoneNumber, string email,
                    Address address, string password, string mode) : base(id, CPF, name, phoneNumber, email, address, password, mode)
        {

        }

        public override string ToString()
        {
            return $"Costumer {Name} | {CPF}";
        }
    }
}
