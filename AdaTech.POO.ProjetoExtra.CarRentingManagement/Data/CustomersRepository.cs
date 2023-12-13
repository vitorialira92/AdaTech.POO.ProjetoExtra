using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.User;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Data
{
    internal static class CustomerRepository
    {
        private static List<Customer> _allCustomers = new List<Customer>();
        internal static bool AddCustomer(Customer customer)
        {
            if(customer == null) return false;
            _allCustomers.Add(customer); SaveCustomerInTheFile(customer);  return true;
        }

        private static void SaveCustomerInTheFile(Customer customer) {}

        internal static string GetAllCustomersToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("===================================\n" +
                        "=          AUTOJOURNEY            =");
            foreach (Customer customer in _allCustomers)
            {
                sb.Append(customer.ToString() + "\n===================================\n");
            }

            return sb.ToString();
        }

        internal static Customer GetCustomerByCPF(string customerCPF)
        {
            foreach(Customer customer in _allCustomers)
            {
                if(customer.CPF == customerCPF) return customer;
            }
            return null;
        }

        internal static Customer GetCustomerById(decimal customerId)
        {
            foreach (Customer customer in _allCustomers)
            {
                if (customer.Id == customerId) return customer;
            }
            return null;
        }

        internal static Customer Login(string email, string password)
        {
            foreach(Customer customer in _allCustomers)
            {
                if (customer.Email.Equals(email.ToLower()))
                {
                    if (customer.CheckPassword(password))
                    {
                        return customer;
                    }
                }
            }
            return null;
        }

        internal static bool RemoveCustomer(Customer customer)
        {
            if (_allCustomers.Contains(customer))
            {
                _allCustomers.Remove(customer);
                return true;
            }
            return false;
        }
    }
}
