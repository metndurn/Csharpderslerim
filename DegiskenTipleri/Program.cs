using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte s1 = 10;
            short s2 = 20;
            int s3 = 30;
            long s4 = 40;
            float s5 = 50.2f;
            double s6 = 60;
            char karakter = 'A';
            string metin = "Metin Duran";
            bool yes=false;
            object a = true;


            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(karakter);
            Console.WriteLine(metin);
            Console.WriteLine(yes);
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
