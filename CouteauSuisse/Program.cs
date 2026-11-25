using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace CouteauSuisse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool soundState = false;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                ShowMenu(soundState);
                ChooseOption(Console.ReadLine(), ref soundState);
            }
        }
        static private  void ShowMenu(bool soundState)
        {
            Console.CursorVisible = false;
            string userChoice = null;
            Console.Clear();
            Console.SetCursorPosition(Console.WindowLeft/2, 0);
            Console.Write("Bienvenu dans le ");
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.Write("~~Couteau Suisse~~");
            Console.ResetColor();
            Console.WriteLine(" !\n");

            Console.Write("=== ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Couteau Suisse");
            Console.ResetColor();
            Console.Write(" - Utilitaires ===");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\t [Son : {SoundStateString(soundState)}]");
            Console.ResetColor();
            Console.WriteLine("N° 1 : Convertire en code morse !");
            Console.WriteLine("N° 2 : Convertir des nombres entre différentes bases (Décimal <> Binaire <> Octal) et (Décimal <> Hexadécimal)");
            Console.WriteLine("N° 3 : Work In Progress!");
            if (soundState)
            {
                Console.WriteLine("N° 4 : Désactiver le son.");
            }
            else
            {
                Console.WriteLine("N° 4 : Activer le son.");
            }
            Console.WriteLine("Autre ? : Quitter le ~~Couteau Suisse~~...\n");
            Console.CursorVisible=true;
        }
        static private string SoundStateString(bool soundState)
        {
            if (soundState)
            {
                return "Activé";
            }
            else
            {
                return "Désactivé";
            }
        }
        static private void ChooseOption(string userEntry, ref bool soundState)
        {
            switch (userEntry)
            {
                case "1": MorseCode.ShowMorseCode(MorseCode.ConvertIntoMorseCode(), soundState); break;
                case "2": ConvertBase.ShowMenu();break;
                case "4": soundState = !soundState; Console.Clear(); break;
                default: Validation(); break;
            }
        }
        static private void Validation()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Êtes vous sûre de vouloir quitter le programme ? (o/n) : \n");
            Console.ResetColor();
            if (Console.ReadLine()=="o")
            Environment.Exit(0);
            

        }
    }
}
