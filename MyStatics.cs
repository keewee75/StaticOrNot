using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOrNot
{
    public class MyStatics
    {
        //Skapa unika Idn med hjälp av konstruktorn
        public MyStatics()
        {
            Incrementing();
            Id = _currentIndex;           
        }

        public MyStatics(string name, int age) :this() // 'this' pekar på den parameterlösa konstruktorn som körs först innan denna konstruktor körs
        {
            //Incrementing();
            //Id = _currentIndex;
            Name = name;
            Age = age;
        }

        public int Age { get; set; }            //'Age' nårbar utifrån klassen med 'public'

        private static int _currentIndex  = 0;  //'_currentIndex' är synlig endast i klassen med 'private'
        public string Name { get; set; }        //'Name' nårbar utifrån klassen med 'public'
        public int Id { get; private set; }     //'Id' Nårbar utifrån men förhindrar att någon kan förändra Id med 'private set'

        private void Incrementing()             //Denna körs bara i klassen. Inkrementerar Id i detta fallet
        {
            _currentIndex++;
        }

        public void HappyBirthDay() 
        {
            Age++;
            Console.WriteLine($"Happy Birthday {Name}! You are now {Age} years old!");
        }

        public static DateTime CurrentDate()    //Kan anropas utan att skapa ett objekt av MyStatic klassen
        {
            DateTime currentDate = DateTime.Now;
            return currentDate;
        }

        public override string ToString() //Overridar inbyggda ToString
        {
            return "Id: " + Id + " Name: " + Name + " Age: " + Age;
        }

        public bool IsAdult()
        {
            return (Age >= 18) ? true : false;
        }
    }
}
