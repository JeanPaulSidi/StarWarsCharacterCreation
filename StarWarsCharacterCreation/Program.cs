using StarWarsCharacterCreation.AccessoryFactoryClasses;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Channels;
using System.Reflection.Emit;

namespace StarWarsCharacterCreation
{
    internal class Program
    {
        //Abstract Factory Pattern

        //Its goal is to define rules for creating families
        //of related objects without specifying their concrete classes.
        //The Abstract Factory Pattern is a good way of organizing how you create 
        //groups of things that are related to each other.
        //the design helps you keep everything organized and
        //lets you switch between different types easily.
        // The Abstract Factory pattern can add unnecessary complexity to simpler projects;
        //Introducing more factories and product families can indeed,
        //quickly increase the number of classes,
        // making code management difficult in smaller projects.

        static int GetUserChoice() 
        {
            ConsoleKeyInfo keyPressed = new ConsoleKeyInfo();

            Console.WriteLine("What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("1. Create A Jedi Character         2. create a Sith Character");
            Console.WriteLine();

            do
            {
                keyPressed = Console.ReadKey(true);

            } while (keyPressed.Key != ConsoleKey.D1 && keyPressed.Key != ConsoleKey.D2);

            if (keyPressed.Key == ConsoleKey.D1)
            {
                return 1;
            }
            else 
            {
                return 2;
            }

        }

        static void ReturnToMenu() 
        {
            Console.WriteLine();
            Console.Write("Press any key to return to the menu");
            Console.ReadKey(true);
            Console.Clear();
        }

        static void Main(string[] args)
        {
            int UserChoice;
            string Message = string.Empty;

            while (true) 
            {
                UserChoice = GetUserChoice();

                Console.Clear();

                switch (UserChoice)
                {
                    case 1:
                        Console.WriteLine("***** New Jedi Character *****");
                        Console.WriteLine();
                        Message = CharacterFactory.CreateJediCharacter();
                        Console.WriteLine(Message);
                        Console.WriteLine();
                        ReturnToMenu();
                        break;

                    case 2:
                        Console.WriteLine("***** New Sith Character *****");
                        Message = CharacterFactory.CreateSithCharacter();
                        Console.WriteLine();
                        Console.WriteLine(Message);
                        Console.WriteLine();
                        ReturnToMenu();
                        break;

                }
            }

        }
    }
}
