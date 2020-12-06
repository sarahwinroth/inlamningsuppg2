using System;
using System.Collections.Generic;

namespace inlamningsuppg2
{
    class Program
    {      
        static void Main(string[] args)
        {          
            GroupMember member1 = new GroupMember("Mikael Alexander Larsson", 36, "Vänersborg", "Villa", "Fru, två döttrar och en tredje dotter på väg", 2, "Restauranglärare", "Träning och hälsa, surdegsbröd", "Bönchiligryta i tortillabröd", "Elektroniskt. Allt mellan ambient och techno", "Mitt största driv är att det är härligt att få den dagliga hjärngympan man får med programmering, att det är kreativt och att man faktiskt skapar en produkt i slutändan.");
            GroupMember member2 = new GroupMember("Karin Madeleine Karlsson", 35, "Stockholm", "Hyr en Villa", "Sambo och en dotter", 3, "Ekonomassistent och testare", "Bakning och spela Stardew Valley", "Någon form av biff, sötpotatispommes och beanésås", "Just nu, allt som inte är barnvisor ", "Har alltid tyckt det är intressant hur system är uppbyggda och hur de skapas, så nu vill jag kunna göra det själv.");
            GroupMember member3 = new GroupMember("Sammy On Tat Wong", 54, "Åmål", "Villa", "Fru och en son", 4, "Personlig assistent", "Fotografering, matlagning", "Asiatisk, italiensk, svensk husmanskost", "Soul, RnB, House", "Att kunna skapa någonting själv, problemlösning och tillfredsställelse när man har löst ett problem.");
            GroupMember member4 = new GroupMember("David Josef Frödin", 25, "Sundbyberg", "Lägenhet", "Det vanliga", 0, "Verksamhetschef på en studentförening", "Leta efter universums hemligheter, målning, lära sig språk", "Bortsch", "Allt! Inne i rockperiod som varvas med rysk folkmusik", "Det är ballt och jag får kombinera kreativitet, problemlösning och människoperspektiv i en trevlig mix.");
            GroupMember member5 = new GroupMember("Rauf Karimli", 36, "Göteborg", "Villa", "Fru, en son och en dotter", 0, "Projektledare", "Spela piano, laga mat", "Grillat kött ", "Gott och blandat", "De gränslösa möjligheterna att utveckla och utvecklas.");
            GroupMember member6 = new GroupMember("Erik Rindlert", 31, "Stockholm", "Lägenhet", "Ogift", 0, "IT-support", "Litteratur, datorspel", "Svensk-fransk fisksoppa", "chubert eller Darkthrone, beroende på dag", "Bygga, bygga, bygga");
            GroupMember member7 = new GroupMember("Daniel Jacob Arlbring", 24, "Alingsås", "Lägenhet", "Sambo", 0, "Väktare", "Motorsport/datorspel", "Italienskt", "House", "");
            GroupMember member8 = new GroupMember("Svante Joelsson", 36, "Strömstad", "Lägenhet", "Sambo och en son", 1, "Fritidspedagog/Förskolelärare", "Illustrera Animera", "Pasta al fungi", "Gubbrock och allt som är bra", "Kul combo av problemlösning och kreativitet, och att en dag landa ett jobb med mer frihet.");
            GroupMember member9 = new GroupMember("Sarah Winroth", 31, "Vara", "Lägenhet", "Gift", 0, "Reseledare", "Motionerar gärna", "Älskar mat i alla former", "Lyssnar på det mesta", "Själva problemlösningen och tillfredsställelsen efteråt!");
            GroupMember member10 = new GroupMember("Farzane Zafarzade", 32, "Karlstad", "Lägenhet", "Gift", 0, "IT-support", "Träning och bakning", "Alla typer av pastarätter", "lugna och klassikermusik", "Problemlösning, inom att lösa problem man lär sig att bli mer tålmodig och kreativ.");

            List<GroupMember> listOfMembers = new List<GroupMember>() { member1, member2, member3, member4, member5, member6, member7, member8, member9, member10 };
            
            Start(listOfMembers);
        }
        static void Start(List<GroupMember> listOfMembers)
        {                      
                Console.WriteLine("Vänligen ange gruppnamn för att få åtkomst till medlemmar: ");
                string input = Console.ReadLine();
                if (input == "coffeencode" || input == "Coffee 'n' Code" || input == "coffee 'n' code")
                {
                    Menu(listOfMembers);
                }
                else
                {
                    string message = "Åtkomst nekad. Du har skrivit in fel gruppnamn, var god försök igen!";
                    Console.WriteLine(message + "\n");
                }                      
        }       
        static void Menu(List<GroupMember> listOfMembers)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Välj något av alternativen nedan genom att skriva in siffran.");
            Console.WriteLine("1. Lista namn på alla medlemmar i gruppen.");
            Console.WriteLine("2. Visa uppgifter om medlemmar i gruppen.");
            Console.WriteLine("3. Redigera medlem i gruppen.");
            string input = Console.ReadLine();

            switch(Convert.ToInt32(input))
            {
                case 1:
                    ListNameOfMembers(listOfMembers);
                    break;
                case 2:
                    ShowMembers(listOfMembers);
                    break;
                case 3:
                    ListNameOfMembers(listOfMembers);
                    break;
            }
        }
        
        static void ListNameOfMembers(List<GroupMember> listOfMembers)
        {
            foreach (var member in listOfMembers)
            {
                member.MemberName();
            }
            Console.WriteLine("\n");
            Menu(listOfMembers);
        }
        static void ShowMembers(List<GroupMember> listOfMembers)
        {
            Console.WriteLine("Du kan välja att se uppgifter ifrån alla medlemmar genom att skriva ");
            Console.WriteLine("1. Visa uppgifter om ALLA medlemmar i gruppen.");
            Console.WriteLine("2. Visa uppgifter om ENSKILDA medlemmar i gruppen.");
            string input = Console.ReadLine();
            Console.Write("\n");

            switch (Convert.ToInt32(input))
            {
                case 1:
                    ShowAllMembersDescription(listOfMembers);
                    break;
                case 2:
                    ShowMemberDescription(listOfMembers);
                    break;
            }
            foreach (var member in listOfMembers)
            {
                member.Description();
            }
            Menu(listOfMembers);
        }
        static void ShowAllMembersDescription(List<GroupMember> listOfMembers)
        {
            foreach (var member in listOfMembers)
            {
                ConsoleColor currentBackground = Console.BackgroundColor;
                ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
                Random random = new Random();
                int index = random.Next(colors.Length);
                ConsoleColor color = colors[index];

                if (color == currentBackground) 
                { Console.ForegroundColor = ConsoleColor.White; }
                else { Console.ForegroundColor = color; }
                member.Description();
            }
            Console.Write("\n");
            Menu(listOfMembers);
        }
        static void ShowMemberDescription(List<GroupMember> listOfMembers)
        {
            Console.WriteLine("Skriv namnet på den gruppmedlem du vill se uppgifter om:");
            Console.WriteLine("(Ex. Svante Joelsson)");
            string input = Console.ReadLine();
            Console.Write("\n");

            foreach (var member in listOfMembers)
            {
                while(input == member.Name)
                {
                    member.Description();
                    break;
                }               
            }         
            Console.Write("\n");
            Menu(listOfMembers);
        }


    }
}
