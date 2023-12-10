using AdaTech.POO.ProjetoExtra.CarRentingManagement.Data;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Services
{
    internal class CustomersService
    {
        public static void InitRepository() { DataCollector.GetAllCustomers(); }

        public static bool AddCustomer(Customer Customer) { return CustomerRepository.AddCustomer(Customer); }

        public static Customer GetCustomerById(decimal CustomerId) { return CustomerRepository.GetCustomerById(CustomerId); }
        public static Customer GetCustomerByCPF(string CustomerCPF) { return CustomerRepository.GetCustomerByCPF(CustomerCPF); }

        public static bool RemoveCustomer(Customer Customer) { return CustomerRepository.RemoveCustomer(Customer); }

        public static string ListAllCustomers()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("===================================\n=          AUTOJOURNEY            =" +
                "\n===================================");
            stringBuilder.Append(CustomerRepository.GetAllCustomersToString());
            return stringBuilder.ToString();
        }
    }
}
