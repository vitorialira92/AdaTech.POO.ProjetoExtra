using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Rentals.PaymentManagement
{
    using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Enums.Payment;

    internal class Payment
    {
        public DateTime timestamp { get; private set; }
        public PaymentStatus PaymentStatus { get; private set; }
        public CreditCard CreditCard
        {
            get { return CreditCard; }
            private set { CreditCard = value; }
        }

        public Payment(CreditCard creditCard)
        {
            if (creditCard == null)
                throw new ArgumentNullException(nameof(creditCard), "Credit card cannot be null.");

            timestamp = DateTime.Now;
            PaymentStatus = PaymentStatus.Pending;
            CreditCard = creditCard;
        }
    }
}
