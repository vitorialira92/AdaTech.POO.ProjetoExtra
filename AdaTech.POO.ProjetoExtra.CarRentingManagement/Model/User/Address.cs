using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.UserManagement.model
{
    using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Enums.User;
    using Enums;
    internal class Address
    {
        private string _street;
        private string _city;
        private BrazilStates _state;
        private string _postalCode;

        public Address(string street, string city, BrazilStates state, string postalCode)
        {
            Street = street;
            City = city;
            State = state;
            PostalCode = postalCode;
        }

        public string Street { get { return _street; } set { _street = value; } }
        public string City { get { return _city; } set { _city = value; } }
        public BrazilStates State { get { return _state; } set { _state = value; } }
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }

    }
}
