using System;

namespace oop_6115261027_w02
{
    class Program
    {
        static void Main(string[] args)
        {
            Room r434 = new Room("434", "434", 4, 4, "Computer");
            Console.WriteLine(r434);
            Building b4 = new Building("4 ", " Computer ", " 5.456 ", " 562.654 ");
            Console.WriteLine(b4);
            Subject th = new Subject("33235 ", " thai ", " 2 ", " 2 ", " 2 ");
            Console.WriteLine(th);
            Lecturer tc = new Lecturer("Sarayut ", " Tabteesud ", " Teacher ");
            Console.WriteLine(tc);
            Section aa = new Section("341 ", " 01 ", " Computer ", " T.arm ", " 01 Aug ", " 13.00 ", " 15.30 ");
            Console.WriteLine(aa);
            Programm cc = new Programm("Com ", " Bachelor degree ");
            Console.WriteLine(cc);
        }
    }
}
