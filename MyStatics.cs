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
            Id = LuckyNumber;
        }
        public static int LuckyNumber { get; set; } = 0;
        public string Name { get; set; }

        public int Id { get; set; }

        public void Incrementing()
        {
            LuckyNumber++;
        }
    }
}
