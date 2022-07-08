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
        private static int _currentIndex  = 0;  //'_currentIndex' är synlig endast i klassen med 'private'
        public string Name { get; set; }        //'Name' nårbar utifrån klassen med 'public'
        public int Id { get; private set; }     //Förhindra att någon kan förändra Id med 'private set'

        private void Incrementing()             //Denna
        {
            _currentIndex++;
        }

        public static DateTime CurrentDate()
        {
            DateTime currentDate = DateTime.Now;
            return currentDate;
        }
    }
}
