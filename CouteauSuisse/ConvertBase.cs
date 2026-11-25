using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CouteauSuisse
{
    static class ConvertBase
    {
        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Convertisseur de bases ===");
            Console.WriteLine("1. Décimal > Binaire");
            Console.WriteLine("2. Binaire > Décimal");
            Console.WriteLine("3. Binaire > Octal");
            Console.WriteLine("4. Octal > Binaire");
            Console.WriteLine("5. hexadécimal > Décimal");
            Console.WriteLine("6. Décimal > Héxadécimal");
            Console.Write("Veuillez entrer votre choix : ");
            ShowConvertor(Console.ReadLine());
        }
        private static void ShowConvertor(string userEntry)
        {
            List<int> binaryResult = new List<int>();
            switch(userEntry)
            {
                case "1": Console.Write("Entrez un nombre décimal : "); 
                    binaryResult = ConvertDecimalToBinary(Console.ReadLine());
                    if (binaryResult != null) { 
                    string result = "";
                        foreach (int i in binaryResult)
                        {
                            result += i.ToString();
                        } 
                        Console.WriteLine($"Résultat : {result}");
                        Console.ReadKey();
                    }
                    break;
                case "2": Console.Write("Entrez un nombre Binaire : "); break;
                case "3": Console.Write("Entrez un nombre Binaire : "); break;
                case "4": Console.Write("Entrez un nombre Octal : "); break;
                case "5": Console.Write("Entrez un nombre Hexadécimal : "); break;
                case "6": Console.Write("Entrez un nombre Décimal : "); break;
            }
        }
        private static List<int> ConvertDecimalToBinary(string entry)
        {
            bool isDigit = false;
            int userEntry = 0;
            try
            {
                userEntry = int.Parse(entry);
                isDigit = true;
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ceci n'est pas un chiffre Décmial !");
                Console.ResetColor();

            }
            if (isDigit)
            {
                List<int> binaryResult = new List<int>();
                bool progress = true;
                while (progress)
                {
                    binaryResult.Insert(0, userEntry % 2);

                    userEntry = userEntry / 2;
                    progress = !(userEntry == 0);

                }
                return binaryResult;
            }
            return null;

        }
    }
}
