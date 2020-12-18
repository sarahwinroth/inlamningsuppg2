using System;
using System.Collections.Generic;
using System.Text;

namespace inlamningsuppg2
{
    class Group
    {
        //Tilldelar klassen en global lista för att lagra alla medlemmar i
        public List<GroupMember> listOfMembers = new List<GroupMember>();
        
        //Startmenyn som man anropar när man skriver in rätt lösenord, denna innehåller valalternativ och beroende på valet så anropas metoden genom switch-sats
        public void Menu()
        {
            AddMembers();
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("Välj något av följande alternativ.");
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
                        default:
                            Console.WriteLine("Alternativet du skrev in existerar inte, vad god försök igen!");
                            break;
                    }              

                Console.WriteLine("För att avsluta tryck q. Tryck enter för att fortsätta på startmenyn.");
                string answer = Console.ReadLine();
                if (answer.ToLower().Replace(" ", "") == "q")
                {
                    Console.Clear();
                    Console.Write("Tack för denna gång och på återseende!\n");
                    Console.Write("Stay safe <3 \n");
                    keepGoing = false;
                }
            }
        }
        //Nedan följer en metod som skapar objekt av klassen GroupMember och samtidigt lägger in dom i listan listOfMembers.
        public void AddMembers()
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
        }

        //En metod som listar namnen på alla Gruppmedlemmar samt skriver ut hur många gruppmedlemmar som finns
        public void ListNameOfMembers()
        {
            Console.Clear();
            List<string> listOfMemberNames = new List<string>();

            foreach (var member in listOfMembers)
            {
                listOfMemberNames.Add(member.Name);
            }

            Console.WriteLine(string.Join(',', listOfMemberNames));
            Console.WriteLine($"Antalet gruppmedlemmar är: {GroupMember.count} \n");
        }
        //För att få info om gruppmedlemmar så anropas denna metod som representerar en submeny där man kan 
        //välja om man vill se uppgifter om alla medlemmar eller från en medlem. 
        public void ShowMembers()
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
                        ShowAllMemberDescription();
                        break;
                    case 2:
                        ShowMemberDescription();
                        break;
                    default:
                        Console.WriteLine("Alternativet du skrev in existerar inte, vad god försök igen!");
                        break;
                }

                Console.WriteLine("För att återgå till startmenyn tryck q. Tryck enter för att fortsätta.");
                string answer = Console.ReadLine();
                if (answer.ToLower().Replace(" ", "") == "q")
                {
                    keepGoing = false;
                    Console.Clear();
                    Menu();
                }
            }
        }
        //Vill man se uppgifter om alla medlemmar så anropas denna metod. 
        public void ShowAllMemberDescription()
        {
            Console.Clear();
            foreach (var member in listOfMembers)
            {
                //Lyckades få till att varje medlems text slumpmässigt ändrar färg med hjälp av denna sida. https://www.c-sharpcorner.com/article/change-console-foreground-and-background-color-in-c-sharp/
                ConsoleColor currentBackground = Console.BackgroundColor; 
                ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor)); 
                Random random = new Random(); 
                int index = random.Next(colors.Length);
                var color = colors[index];

                if (color == currentBackground)
                { Console.ForegroundColor = ConsoleColor.White; }
                else { Console.ForegroundColor = color; }
                member.Description();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        //Denna metod låter användaren ta fram uppgifter om en enskild medlem i gruppen    
        public void ShowMemberDescription()
        {
            Console.Clear();
            Console.WriteLine("Skriv namnet på den gruppmedlem du vill se uppgifter om:");
            Console.WriteLine("(Ex. Svante Joelsson)");
            string input = Console.ReadLine();
            Console.Write("\n");

            GroupMember member = GetMemberFromList(input);
            if(member == null)
            { Console.WriteLine($"{input} existerar inte, var god försök igen!"); }
            else 
            { member.Description(); }           
        }
        //Metoden EditMembers ger dig en submeny med alternativ på om du vill redigera, lägga till eller ta bort medlem och anropar metoder för dess syfte
        public void EditMembers()
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
                        AddNewMember();
                        break;
                    case 2:
                        DeleteMember();
                        break;
                    case 3:
                        EditDetailsOfMember();
                        break;
                    default:
                        Console.WriteLine("Alternativet du skrev in existerar inte, vad god försök igen!");
                        break;
                }
                Console.WriteLine("För att återgå till startmenyn tryck q. Tryck enter för att fortsätta.");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "q")
                {
                    keepGoing = false;
                    Console.Clear();
                    Menu();
                }
            }
        }
        //Metoden AddMember låter användaren lägga till en medlem genom att ta emot värdena som skall skickas med som argument när objektet/medlemmen skapas
        public void AddNewMember()
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
            //Här skapar vi en instans av klassen GroupMember och skickar med de värden användaren matat in som argument och samtidigt lägger vi till instansen i listan listOfMembers
            listOfMembers.Add(new GroupMember(name, age, city, accomondation, family, numberOfPets, profession, hobbies, favoriteFood, favoriteMusic, comment));

            Console.WriteLine($"\nDu har nu lagt till {name} som ny medlem i gruppen. Välkommen {name}!\n");
        }
        //DeleteMember-metoden tar bort ett objekt med hjälp av Remove-metoden som klassen List har. 
        public void DeleteMember()
        {
            Console.Clear();
            Console.WriteLine("Skriv namnet på den gruppmedlem du vill ta bort:");
            Console.WriteLine("(Ex. Sarah Winroth)");
            string input = Console.ReadLine();

            GroupMember member = GetMemberFromList(input);
            if (member == null)
            { Console.WriteLine($"{input} existerar inte, var god försök igen!"); }
            else
            {
                listOfMembers.Remove(member);
                GroupMember.count--;//Här minskar vi variabeln count som finns deklarerad i GroupMemberklassen med 1.
                Console.WriteLine($"\nDu har nu tagit bort {member.Name}.\n");
            }
            
        }
        //Metoden nedan låter användaren ändra värdena som är tilldelade ett objekt/gruppmedlem
        public void EditDetailsOfMember()
        {
            Console.Clear();
            Console.WriteLine("Skriv namnet på den gruppmedlem du vill ändra uppgifter på:");
            Console.WriteLine("(Ex. Erik Rindlert)\n");
            string input = Console.ReadLine();

            GroupMember member = GetMemberFromList(input);
            if (member == null)
            { Console.WriteLine($"{input} existerar inte, var god försök igen!"); }
            else
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
                default:
                    Console.WriteLine("Alternativet du skrev in existerar inte, vad god försök igen!");
                    break;
            }
            }
        }
        public GroupMember GetMemberFromList(string input)
        {
            foreach (GroupMember member in listOfMembers)
            {
                if (input == member.Name)
                {
                    return member;
                }
            }
            return null;
        }
    }
}
