using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Enums.Rental;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Rental.PaymentManagement
{
    internal class CreditCard
    {
        public string CardHolder { get; private set; }
        public string CardNumber { get; private set; }
        public int ExpirationMonth { get; private set; }
        public int ExpirationYear { get; private set; }
        public string Cvv { get; private set; }
        public CardIssuer CardIssuer { get; private set; }

        public CreditCard(string cardHolder, string cardNumber, int expirationMonth, int expirationYear, string cvv, CardIssuer cardIssuer)
        {
            CardHolder = cardHolder;
            CardNumber = cardNumber;
            ExpirationMonth = expirationMonth;
            ExpirationYear = expirationYear;
            Cvv = cvv;
            CardIssuer = cardIssuer;
        }

        public void RenewCard(int expirationMonth, int expirationYear, string cvv = null)
        {
            ExpirationMonth = expirationMonth;
            ExpirationYear = expirationYear;
            if (cvv != null)
                Cvv = cvv;
        }
    }
}
