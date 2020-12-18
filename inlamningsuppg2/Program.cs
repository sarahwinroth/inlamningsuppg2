using System;
using System.Collections.Generic;

namespace inlamningsuppg2
{
    class Program
    {
        // När programmet startar så anropas metoden Login
        static void Main(string[] args)
        {           
            Login();
        }
        //Metoden Login tar strängen som användaren skriver in, ändrar alla karaktärer till småbokstäver och byter mellanslag till 
        //inget mellanslag för att sedan kolla om strängen är lika med "coffeencode". Detta görs med en if-sats, och om villkoret 
        //inte stämmer skrivs ett meddelande ut, men stämmer det så anropar man Menu-metoden.
        static void Login()
        {
            bool keepGoing = true;

            do
            {
                Console.WriteLine("Vänligen ange gruppnamn för att få åtkomst till våran grupp! ");
                string input = Console.ReadLine();

                if (input.Replace(" ", "").ToLower() == "coffeencode")
                {
                    Console.Clear();
                    Group run = new Group();
                    Console.WriteLine("Välkommen!");
                    Console.WriteLine("Du har nu åtkomst till våran grupp, Coffee 'n' code.");
                    run.Menu();
                }
                else
                {
                    string message = "Åtkomst nekad. Du har skrivit in fel gruppnamn, var god försök igen!";
                    Console.WriteLine(message + "\n");
                }
            } while (keepGoing);
        }                       
    }
}
