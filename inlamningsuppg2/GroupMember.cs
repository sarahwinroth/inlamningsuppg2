using System;
using System.Collections.Generic;
using System.Text;

namespace inlamningsuppg2
{
    class GroupMember
    {
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

        static int membersCount;

        public GroupMember()
        { 
        }
        public GroupMember(string name, int age, string city, string accomondation, string family, int numOfPets, string profession, string hobbies, string favoriteFood, string favoriteMusic, string comment)
        {
            this.Name = name;
            this.Age = age;
            this.City = city;
            this.Accomondation = accomondation;
            this.Family = family;
            this.NumOfPets = numOfPets;
            this.Profession = profession;
            this.Hobbies = hobbies;
            this.FavoriteFood = favoriteFood;
            this.FavoriteMusic = favoriteMusic;
            this.Comment = comment;

            membersCount++;
        }
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
        public void MemberName()
        {
            Console.Write(name + ", ");
        }
        public void Description()
        {
           

            Console.WriteLine("Namn: {0}", Name);
            Console.WriteLine("Ålder: {0}", Age);
            Console.WriteLine("Stad: {0}", City);
            Console.WriteLine("Boende: {0}", Accomondation);
            Console.WriteLine("Antal husdjur: {0}", NumOfPets);
            Console.WriteLine("Tidigare yrke: {0}", Profession);
            Console.WriteLine("Hobby: {0}", Hobbies);
            Console.WriteLine("Favorit mat: {0}", FavoriteFood);
            Console.WriteLine("Favorit musik: {0}", FavoriteMusic);
            Console.WriteLine("Vad som driver till programmering: {0}", Comment);
            Console.WriteLine();           
        }
     
    }
}
