using inheritance;
using System;
using static inheritance.orang;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            orang orang1 = new orang();
            orang orang2 = new orang("Rifqa", 19);
            Member member1 = new Member("Atifa", 20);

            orang1.InfoOrang();
            orang2.InfoOrang();

            member1.InfoOrang();
            member1.InfoOrang("Perempuan", " Ketua Member");

            Console.ReadKey();
        }
    }

   
}