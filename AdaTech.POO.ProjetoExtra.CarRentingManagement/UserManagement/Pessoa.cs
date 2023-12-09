using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.UserManagement
{
    internal abstract class Pessoa
    {
        public decimal Id { get; private set; }
        public string CPF { get; private set; }
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public Address Address { get; private set; }
        public string Senha { get; private set; }


    }
}
