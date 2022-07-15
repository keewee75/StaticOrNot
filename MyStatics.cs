using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOrNot
{
    internal class MyStatics
    {
        //Skapa unika Idn med hjälp av konstruktorn
        public MyStatics()
        {
            Incrementing();
            Id = _currentIndex;           
        }

        public MyStatics(string name, int age, DateTime birthday) :this() // 'this' pekar på den parameterlösa konstruktorn som körs först innan denna konstruktor körs
        {
            //Incrementing();
            //Id = _currentIndex;
            Name = name;
            Age = age;
            BirthDay = birthday;
        }

        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        public int Age { get; set; }

        private static int _currentIndex  = 0;  //'_currentIndex' är synlig endast i klassen med 'private'
        public string Name { get; set; }        //'Name' nårbar utifrån klassen med 'public'
        public int Id { get; private set; }     //Förhindra att någon kan förändra Id med 'private set'
        public DateTime BirthDay { get; set; }

        private void Incrementing()             //Denna körs bara i klassen
        {
            _currentIndex++;
        }

        public static DateTime CurrentDate()
        {
            DateTime currentDate = DateTime.Now;
            return currentDate;
        }

        public override string ToString() //Overridar inbyggda ToString
        {
            //string nameAndAge = "Name: " + Name + " Age: " + Age;
            return "Id: " + Id + " Name: " + Name + " Age: " + Age + " Birth Day:" + BirthDay;
        }
    }
}
