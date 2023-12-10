using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.UserInterface
{
    internal static class Utils
    {
        public static int ReadInteger(int b = -55, int e = -55)
        {
            int number = 0;
            bool validNumber = false;
            
            while(!validNumber)
            {
                validNumber = int.TryParse(Console.ReadLine(), out number);

                if (b != e && b != -55)
                    validNumber = number >= b && number <=e;

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

                if(restriction == "email")
                    validString = word.Contains("@vj.com");

                if (!validString)
                    Console.WriteLine("Please type a valid input");
            }

            return word;
        }
    }
}
