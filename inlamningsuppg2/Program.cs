using System;
using System.Collections.Generic;

namespace inlamningsuppg2
{
    class Program
    {
        static List<GroupMember> listOfMembers = new List<GroupMember>();

        static void Main(string[] args)
        {
            /*
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
            */

            listOfMembers.Add(new GroupMember("Mikael Alexander Larsson", 36, "Vänersborg", "Villa", "Fru, två döttrar och en tredje dotter på väg", 2, "Restauranglärare", "Träning och hälsa, surdegsbröd", "Bönchiligryta i tortillabröd", "Elektroniskt. Allt mellan ambient och techno", "Mitt största driv är att det är härligt att få den dagliga hjärngympan man får med programmering, att det är kreativt och att man faktiskt skapar en produkt i slutändan."));
            listOfMembers.Add(new GroupMember("Karin Madeleine Karlsson", 35, "Stockholm", "Hyr en Villa", "Sambo och en dotter", 3, "Ekonomassistent och testare", "Bakning och spela Stardew Valley", "Någon form av biff, sötpotatispommes och beanésås", "Just nu, allt som inte är barnvisor ", "Har alltid tyckt det är intressant hur system är uppbyggda och hur de skapas, så nu vill jag kunna göra det själv."));
            listOfMembers.Add(new GroupMember("Sammy On Tat Wong", 54, "Åmål", "Villa", "Fru och en son", 4, "Personlig assistent", "Fotografering, matlagning", "Asiatisk, italiensk, svensk husmanskost", "Soul, RnB, House", "Att kunna skapa någonting själv, problemlösning och tillfredsställelse när man har löst ett problem."));
            listOfMembers.Add(new GroupMember("Sammy On Tat Wong", 54, "Åmål", "Villa", "Fru och en son", 4, "Personlig assistent", "Fotografering, matlagning", "Asiatisk, italiensk, svensk husmanskost", "Soul, RnB, House", "Att kunna skapa någonting själv, problemlösning och tillfredsställelse när man har löst ett problem."));
            listOfMembers.Add(new GroupMember("David Josef Frödin", 25, "Sundbyberg", "Lägenhet", "Det vanliga", 0, "Verksamhetschef på en studentförening", "Leta efter universums hemligheter, målning, lära sig språk", "Bortsch", "Allt! Inne i rockperiod som varvas med rysk folkmusik", "Det är ballt och jag får kombinera kreativitet, problemlösning och människoperspektiv i en trevlig mix."));
            listOfMembers.Add(new GroupMember("Rauf Karimli", 36, "Göteborg", "Villa", "Fru, en son och en dotter", 0, "Projektledare", "Spela piano, laga mat", "Grillat kött ", "Gott och blandat", "De gränslösa möjligheterna att utveckla och utvecklas."));
            listOfMembers.Add(new GroupMember("Erik Rindlert", 31, "Stockholm", "Lägenhet", "Ogift", 0, "IT-support", "Litteratur, datorspel", "Svensk-fransk fisksoppa", "chubert eller Darkthrone, beroende på dag", "Bygga, bygga, bygga"));
            listOfMembers.Add(new GroupMember("Daniel Jacob Arlbring", 24, "Alingsås", "Lägenhet", "Sambo", 0, "Väktare", "Motorsport/datorspel", "Italienskt", "House", ""));
            listOfMembers.Add(new GroupMember("Svante Joelsson", 36, "Strömstad", "Lägenhet", "Sambo och en son", 1, "Fritidspedagog/Förskolelärare", "Illustrera Animera", "Pasta al fungi", "Gubbrock och allt som är bra", "Kul combo av problemlösning och kreativitet, och att en dag landa ett jobb med mer frihet."));
            listOfMembers.Add(new GroupMember("Sarah Winroth", 31, "Vara", "Lägenhet", "Gift", 0, "Reseledare", "Motionerar gärna", "Älskar mat i alla former", "Lyssnar på det mesta", "Själva problemlösningen och tillfredsställelsen efteråt!"));
            listOfMembers.Add(new GroupMember("Farzane Zafarzade", 32, "Karlstad", "Lägenhet", "Gift", 0, "IT-support", "Träning och bakning", "Alla typer av pastarätter", "lugna och klassikermusik", "Problemlösning, inom att lösa problem man lär sig att bli mer tålmodig och kreativ."));

            Start();
        }
        static void Start()
        {                      
                Console.WriteLine("Vänligen ange gruppnamn för att få åtkomst till medlemmar: ");
                string input = Console.ReadLine();

                if (input.Trim().ToLower() == "coffeencode")
                {
                    Console.Clear();
                    Menu();
                }
                else
                {
                    string message = "Åtkomst nekad. Du har skrivit in fel gruppnamn, var god försök igen!";
                    Console.WriteLine(message + "\n");
                }                      
        }       
        static void Menu()
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
                    ListNameOfMembers();
                    break;
                case 2:
                    ShowMembers();
                    break;
                case 3:
                    editMembers();
                    break;
            }
        }     
        static void ListNameOfMembers()
        {
            Console.Clear();
            foreach (var member in listOfMembers)
            {
                member.MemberName();
            }
            Console.WriteLine("\n");
            Menu();
        }
        static void ShowMembers()
        {
            Console.Clear();
            Console.WriteLine("Välj vem du vill se uppgifter om:");
            Console.WriteLine("1. ALLA medlemmar i gruppen.");
            Console.WriteLine("2. ENSKILDA medlemmar i gruppen.");
            string input = Console.ReadLine();
            Console.Write("\n");

            switch (Convert.ToInt32(input))
            {
                case 1:
                    ShowAllMembersDescription();
                    break;
                case 2:
                    ShowMemberDescription();
                    break;
            }            
            Menu();
        }
        static void ShowAllMembersDescription()
        {
            Console.Clear();
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
            Menu();
        }
        static void ShowMemberDescription()
        {
            Console.Clear();
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
            Menu();
        }
        static void editMembers()
        {          
            bool keepGoing = true;

            while (keepGoing)
            {
            Console.Clear();
            Console.WriteLine("Välj vad du vill göra");
            Console.WriteLine("1. Lägg till gruppmedlem.");
            Console.WriteLine("2. Ta bort gruppmedlem.");
            Console.WriteLine("2. Redigera gruppmedlem.");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            switch (input)
            {
                case 1:
                    AddMember();
                    break;
                case 2:
                    DeleteMember();
                    break;
                case 3:
                    ChangeMember();
                    break;
            }
                Console.WriteLine("För att återgå till startmenyn tryck q. Annars tryck enter.");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "q")
                {
                    keepGoing = false;
                    Console.Clear();
                    Menu();
                }
            }           
        }
        static void AddMember()
        {
                Console.Clear();
                Console.Write("Ange fullständigt namn (för- och efternamn): ");
                string name = Console.ReadLine();
                Console.Write("Ange ålder: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ange stad: ");
                string city = Console.ReadLine();
                Console.Write("Ange typ av bostad: ");
                string accomondation = Console.ReadLine();
                Console.Write("Ange familjemedlemmar: ");
                string family = Console.ReadLine();
                Console.Write("Ange antalet husdjur: ");
                int numberOfPets = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ange tidigare yrke: ");
                string profession = Console.ReadLine();
                Console.Write("Ange hobby: ");
                string hobbies = Console.ReadLine();
                Console.Write("Ange favorit mat: ");
                string favoriteFood = Console.ReadLine();
                Console.Write("Ange favorit musik: ");
                string favoriteMusic = Console.ReadLine();
                Console.WriteLine("Vad som driver till programmering: ");
                string comment = Console.ReadLine();

                listOfMembers.Add(new GroupMember(name, age, city, accomondation, family, numberOfPets, profession, hobbies, favoriteFood, favoriteMusic, comment));
                Console.Write("\n");               
        }
        static void DeleteMember()
        {
            Console.Clear();
            Console.WriteLine("Skriv namnet på den gruppmedlem du vill ta bort:");
            Console.WriteLine("(Ex. Svante Joelsson)");
            string input = Console.ReadLine();
            Console.Write("\n");

            foreach (var member in listOfMembers)
            {
                if (input == member.Name)
                {
                    listOfMembers.Remove(member);
                    break;
                }
            }
        }
        static void ChangeMember()
        {
            Console.Clear();

        }
    }
}
