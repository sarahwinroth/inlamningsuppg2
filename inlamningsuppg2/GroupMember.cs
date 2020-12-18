using System;
using System.Collections.Generic;
using System.Text;

namespace inlamningsuppg2
{
    class GroupMember
    {
        //Klassmedlemmar/Fält av klassen GroupMember
        private string name;
        private int age;
        private string city;
        private string accomondation;
        private string family;
        private int numOfPets;
        private string profession;
        private string hobbies;
        private string favoriteFood;
        private string favoriteMusic;
        private string comment;
     
        public static int count = 0; 
        
        public GroupMember()
        { 
        }
        //Denna konstruktor tar emot variabler av olika typer som motsvarar de värden som skall tilldelas fälten/klassmedlemmarna vid en instasienring av klassen
        public GroupMember(string name, int age, string city, string accomondation, string family, int numOfPets, string profession, string hobbies, string favoriteFood, string favoriteMusic, string comment)
        {
            this.Name = name; //Värdet som skickas in i konstruktorn hänvisar till propertyn för variabeln name som är döpt till Name. 
            this.Age = age;//Nyckelordet THIS behövs normalt sätt inte i detta fallet då jag hänvisar direkt till propertyn för variabeln jag vill komma åt
            City = city;//Exempel på att THIS inte behövs då variabeln jag refererar till skrivs med stor bokstav (Hänvisar till propertyn)
            this.accomondation = accomondation;//Nyckelordet THIS behövs i detta läge då variablen som tar emot värdet är samma som klassens variabel/fält. Därför används this för att understryka att man menar klassens fält
            this.Family = family;
            this.NumOfPets = numOfPets;
            this.Profession = profession;
            this.Hobbies = hobbies;
            this.FavoriteFood = favoriteFood;
            this.FavoriteMusic = favoriteMusic;
            this.Comment = comment;
            count++; 
        }
        //Då variabeln name är private så behövs en property för att hämta och ändra värde på variabeln. Detta används för att 
        //inte göra data för lätt åtkomlig och för att ha bättre kontroll för hur datan som skickas in och hämtas hanteras på rätt sätt
        //I propertyn finns en SET-metod som tar emot ett värde och tilldelar variablen name värdet som skickas in, GET-metoden returnerar värdet på variabeln
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Accomondation
        {
            get { return accomondation; }
            set { accomondation = value; }
        }
        public string Family
        {
            get { return family; }
            set { family = value; }
        }
        public int NumOfPets
        {
            get { return numOfPets; }
            set { numOfPets = value; }
        }
        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }
        public string Hobbies
        {
            get { return hobbies; }
            set { hobbies = value; }
        }
        public string FavoriteFood
        {
            get { return favoriteFood; }
            set { favoriteFood = value; }
        }
        public string FavoriteMusic
        {
            get { return favoriteMusic; }
            set { favoriteMusic = value; }
        }
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        //Denna metod skriver ut en beskrivning av värdena samt värdena för objektet man refererar till när denna metod anropas
        public void Description()
        {          
            Console.WriteLine("Namn: {0}", Name);
            Console.WriteLine("Ålder: {0}", Age);
            Console.WriteLine("Stad: {0}", City);
            Console.WriteLine("Boende: {0}", Accomondation);
            Console.WriteLine("Familj: {0}", Family);
            Console.WriteLine("Antal husdjur: {0}", NumOfPets);
            Console.WriteLine("Tidigare yrke: {0}", Profession);
            Console.WriteLine("Hobby: {0}", Hobbies);
            Console.WriteLine("Favorit mat: {0}", FavoriteFood);
            Console.WriteLine("Favorit musik: {0}", FavoriteMusic);
            Console.WriteLine("Vad som driver till programmering: {0}", Comment);
            Console.Write("\n");
        }
    }
}
