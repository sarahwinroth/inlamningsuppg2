using System;
using System.Collections.Generic;

namespace inlamningsuppg2
{
    class Program
    {
        static List<GroupMember> listOfMembers = new List<GroupMember>();

        static void Main(string[] args)
        {
            listOfMembers.Add(new GroupMember("Mikael Alexander Larsson", 36, "Vänersborg", "Villa", "Fru, två döttrar och en tredje dotter på väg", 2, "Restauranglärare", "Träning och hälsa, surdegsbröd", "Bönchiligryta i tortillabröd", "Elektroniskt. Allt mellan ambient och techno", "Mitt största driv är att det är härligt att få den dagliga hjärngympan man får med programmering, att det är kreativt och att man faktiskt skapar en produkt i slutändan."));
            listOfMembers.Add(new GroupMember("Karin Madeleine Karlsson", 35, "Stockholm", "Hyr en Villa", "Sambo och en dotter", 3, "Ekonomassistent och testare", "Bakning och spela Stardew Valley", "Någon form av biff, sötpotatispommes och beanésås", "Just nu, allt som inte är barnvisor ", "Har alltid tyckt det är intressant hur system är uppbyggda och hur de skapas, så nu vill jag kunna göra det själv."));
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
            bool keepGoing = true;
            do
            {
                Console.WriteLine("Välj något av alternativen nedan genom att skriva in siffran.");
                Console.WriteLine("1. Lista namn på alla medlemmar i gruppen.");
                Console.WriteLine("2. Visa uppgifter om medlemmar i gruppen.");
                Console.WriteLine("3. Redigera medlem i gruppen.");
                string input = Console.ReadLine();

                switch (Convert.ToInt32(input))
                {
                    case 1:
                        ListNameOfMembers();
                        break;
                    case 2:
                        ShowMembers();
                        break;
                    case 3:
                        EditMembers();
                        break;
                }
                Console.WriteLine("För att avsluta tryck q. Annars tryck enter för att återgå till startmenyn.");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "q")
                {
                    Console.Clear();
                    Console.Write("Tack för denna gång och på återseende! :) \n");
                    keepGoing = false;
                }
            } while (keepGoing);
        }     
        static void ListNameOfMembers()
        {
            Console.Clear();
            List<string> listOfMemberNames = new List<string>();

            foreach (var member in listOfMembers)
            {
                listOfMemberNames.Add(member.MemberName());
            }
            Console.WriteLine(string.Join(',' , listOfMemberNames));
            Console.WriteLine("\n");
        }
        static void ShowMembers()
        {
            bool keepGoing = true;
            while (keepGoing)
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
            Console.ForegroundColor = ConsoleColor.White;
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
        }
        static void EditMembers()
        {          
            bool keepGoing = true;

            while (keepGoing)
            {
            Console.Clear();
            Console.WriteLine("Välj vad du vill göra");
            Console.WriteLine("1. Lägg till gruppmedlem.");
            Console.WriteLine("2. Ta bort gruppmedlem.");
            Console.WriteLine("3. Redigera gruppmedlem.");
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
            Console.WriteLine("Skriv namnet på den gruppmedlem du vill ändra uppgifter på:");
            Console.WriteLine("(Ex. Svante Joelsson)");
            string input = Console.ReadLine();
            Console.Write("\n");

            foreach (var member in listOfMembers)
            {
                while (input == member.Name)
                {                   
                    member.Description();
                    Console.WriteLine("Vad är det du vill ändra på?");
                    Console.WriteLine("1. Namn");
                    Console.WriteLine("2. Ålder");
                    Console.WriteLine("3. Stad");
                    Console.WriteLine("4. Bostad");
                    Console.WriteLine("5. Familj");
                    Console.WriteLine("6. Antalet husdjur");
                    Console.WriteLine("7. Tidigare yrke");
                    Console.WriteLine("8. Hobby");
                    Console.WriteLine("9. Favorit mat");
                    Console.WriteLine("10. favorit musik");
                    Console.WriteLine("11. Vad som driver till programmering");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Ange nytt namn: ");
                            string name = Console.ReadLine();
                            member.Name = name;
                            break;
                        case 2:
                            Console.Write("Ange ny ålder: ");
                            int age = Convert.ToInt32(Console.ReadLine());
                            member.Age = age;
                            break;
                        case 3:
                            Console.Write("Ange ny stad: ");
                            string city = Console.ReadLine();
                            member.City = city;
                            break;
                        case 4:
                            Console.Write("Ange nytt boende: ");
                            string accomondation = Console.ReadLine();
                            member.Accomondation = accomondation;
                            break;
                        case 5:
                            Console.Write("Ange nytt boende: ");
                            string family = Console.ReadLine();
                            member.Family = family;
                            break;
                        case 6:
                            Console.Write("Ange nytt antal husdjur: ");
                            int numberOfPets = Convert.ToInt32(Console.ReadLine());
                            member.NumOfPets = numberOfPets;
                            break;
                        case 7:
                            Console.Write("Ange annat tidigare yrke: ");
                            string profession = Console.ReadLine();
                            member.Profession = profession;
                            break;
                        case 8:
                            Console.Write("Ange ny hobby: ");
                            string hobby = Console.ReadLine();
                            member.Hobbies = hobby;
                            break;
                        case 9:
                            Console.Write("Ange ny favorit mat: ");
                            string favoriteFood = Console.ReadLine();
                            member.FavoriteFood = favoriteFood;
                            break;
                        case 10:
                            Console.Write("Ange ny favorit musik: ");
                            string favoriteMusic = Console.ReadLine();
                            member.FavoriteMusic = favoriteMusic;
                            break;
                        case 11:
                            Console.Write("Ange ny favorit mat: ");
                            string comment = Console.ReadLine();
                            member.Comment = comment;
                            break;
                    }
                    break;
                }
            }
        }
    }
}
