using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.UserManagement
{
    using Enums;
    internal class Address
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public BrazilStates State { get; private set; }
        public string PostalCode { get; private set; }

    }
}
