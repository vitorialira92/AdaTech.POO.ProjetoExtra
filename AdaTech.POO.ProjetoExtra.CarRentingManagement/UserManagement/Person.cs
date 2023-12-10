using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.UserManagement
{
    internal abstract class Person
    {
        public decimal Id { get; private set; }
        public string CPF { get; private set; }
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public Address Address { get; private set; }
        private string _hashedPassword;

        protected Person(decimal id, string CPF, string name, string phoneNumber, string email, Address address, string password)
        {
            this.Id = id;
            this.CPF = CPF;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Address = address;
            SavePassword(password);
        }

        private void SavePassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 2500);
            
            byte[] hash = pbkdf2.GetBytes(30); 
            byte[] hashBytes = new byte[hash.Length + salt.Length];

            Array.Copy(salt, 0, hashBytes, 0, salt.Length);
            Array.Copy(hash, 0, hashBytes, salt.Length, hash.Length);

            this._hashedPassword = Convert.ToBase64String(hashBytes);
        }

        public bool CheckPassword(string password)
        {
            byte[] hashBytes = Convert.FromBase64String(_hashedPassword);

            byte[] salt = new byte[16];

            Array.Copy(hashBytes, 0, salt, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 2500);

            byte[] hash = pbkdf2.GetBytes(30);

            return hash.Equals(hashBytes);
        }
        
        public void UpdateEmail(string email)
        {
            this.Email = email;
        }
        public void UpdatePhoneNumber(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }
        public void UpdateAddress (Address address)
        {
            this.Address = address;
        }

    }
}
