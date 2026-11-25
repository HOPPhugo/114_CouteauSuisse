using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CouteauSuisse
{
    static class MorseCode
    {

        static public void ShowMorseCode(string userMorseCode, bool soundState)
        {
            Console.WriteLine("Résultat en morse : ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false;
            if (userMorseCode != "" || userMorseCode != null)
            foreach (char c in userMorseCode)
            {
                if (c == '.')
                {
                    Console.Write(c);
                    if (soundState)
                    Console.Beep(800, 300);
                    Thread.Sleep(200);
                }
                else if (c == '-')
                {
                    Console.Write(c);
                    if(soundState)
                    Console.Beep(800, 750);
                }
                else if (c == '/')
                {
                    Console.Write(c);
                    Thread.Sleep(700);
                }
                else
                {
                    Console.Write(c);
                }
            }
            Console.ResetColor();
            Console.WriteLine("\n\nContinuer -->");
            Console.CursorVisible = true;
            Console.ReadKey();
        }
        static public string ConvertIntoMorseCode()
        {

            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine("=== Convertisseur de texte en code Morse ===");
            Console.WriteLine("Entrez un mot ou une phrase (sans accents, lettres A-Z) (Exemple : SOS -> ... --- ... ) :");
            Console.CursorVisible = true;
            string userEntry = Console.ReadLine();
            string userMorseCode = null;

            foreach (char c in userEntry.ToUpper())
            {
                switch (c)
                {
                    case 'A': userMorseCode += ".- "; break;
                    case 'B': userMorseCode += "-... "; break;
                    case 'C': userMorseCode += "-.- ."; break;
                    case 'D': userMorseCode += "-.. "; break;
                    case 'E': userMorseCode += ". "; break;
                    case 'F': userMorseCode += "..-. "; break;
                    case 'G': userMorseCode += "--. "; break;
                    case 'H': userMorseCode += ".... "; break;
                    case 'I': userMorseCode += ".. "; break;
                    case 'J': userMorseCode += ".--- "; break;
                    case 'K': userMorseCode += "-.- "; break;
                    case 'L': userMorseCode += ".-.. "; break;
                    case 'M': userMorseCode += "-- "; break;
                    case 'N': userMorseCode += "-. "; break;
                    case 'O': userMorseCode += "--- "; break;
                    case 'P': userMorseCode += ".--. "; break;
                    case 'Q': userMorseCode += "--.- "; break;
                    case 'R': userMorseCode += ".-. "; break;
                    case 'S': userMorseCode += "... "; break;
                    case 'T': userMorseCode += "- "; break;
                    case 'U': userMorseCode += "..- "; break;
                    case 'V': userMorseCode += "...- "; break;
                    case 'W': userMorseCode += ".-- "; break;
                    case 'X': userMorseCode += "-..- "; break;
                    case 'Y': userMorseCode += "-.-- "; break;
                    case 'Z': userMorseCode += "--.. "; break;
                    case '0': userMorseCode += "----- "; break;
                    case '1': userMorseCode += ".---- "; break;
                    case '2': userMorseCode += "..--- "; break;
                    case '3': userMorseCode += "...-- "; break;
                    case '4': userMorseCode += "....- "; break;
                    case '5': userMorseCode += "..... "; break;
                    case '6': userMorseCode += "-.... "; break;
                    case '7': userMorseCode += "--... "; break;
                    case '8': userMorseCode += "---.. "; break;
                    case '9': userMorseCode += "----. "; break;
                    case ' ': userMorseCode += "/ "; break;
                    case '$': Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"Le caractère \"$\" n'a pas été pris en compte."); break;
                    default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"Le caractère \"{c}\" n'a pas été pris en compte."); break;
                }
                Console.ResetColor();
            }
            return userMorseCode;
        }
    }
}
