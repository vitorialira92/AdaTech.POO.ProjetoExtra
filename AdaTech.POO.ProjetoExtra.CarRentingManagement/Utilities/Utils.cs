using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Enums.User;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Utilities
{
    internal static class Utils
    {
        public static int ReadInteger(int b = -55, int e = -55)
        {
            int number = 0;
            bool validNumber = false;

            while (!validNumber)
            {
                validNumber = int.TryParse(Console.ReadLine(), out number);

                if (b != e && b != -55)
                    validNumber = number >= b && number <= e;

                if (!validNumber)
                    Console.WriteLine("Please type a valid number");
            }

            return number;
        }

        public static string ReadString(string restriction = null)
        {
            string word = "";
            bool validString = false;

            while (!validString)
            {
                word = Console.ReadLine();

                validString = !string.IsNullOrEmpty(word) && !string.IsNullOrWhiteSpace(word);

                if (restriction == "emailCompany")
                    validString = word.Contains("@vj.com");
                else if (restriction == "email")
                    validString = word.Contains('@') && word.Contains(".com") && !word.Contains(' ');
                if (!validString)
                    Console.WriteLine("Please type a valid input");
            }

            return word;
        }

        public static bool ReadYOrN()
        {
            string word = "";
            bool validString = false;

            while (!validString)
            {
                word = Console.ReadLine();

                validString = word.ToUpper().Equals("Y") || word.ToUpper().Equals("N");

                if (!validString)
                    Console.WriteLine("Please type Y or N");
            }

            return word.ToUpper().Equals("Y");
        }

        internal static BrazilStates ReadBrazilState()
        {
            string word = "";
            bool validState = false;
            
            BrazilStates brazilState = new BrazilStates();

            while (!validState)
            {
                word = Console.ReadLine();

                validState = Enum.TryParse(word, ignoreCase: true, out brazilState);

                if (!validState)
                    Console.WriteLine("Please type a valid input");
            }

            return brazilState;
        }

        internal static DateTime ReadDateTime(string type, DateTime from)
        {
            string word = "";
            bool validDate = false;

            DateTime dateTime = new DateTime();

            while (!validDate)
            {
                word = Console.ReadLine();

                validDate = DateTime.TryParseExact(word, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);

                if (type.Equals("future")) { validDate = dateTime > from; }
                else if (type.Equals("past")) { validDate = dateTime < from; }

                if (!validDate)
                    Console.WriteLine("Please type a valid input [dd/mm/yyyy]");
            }

            return dateTime;
        }

    }
}
