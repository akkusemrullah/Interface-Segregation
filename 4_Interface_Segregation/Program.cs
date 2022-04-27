using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Interface_Segregation
{/// <summary>
 /// Düşünelim ki, elimizde birden fazla tankımız olsun. 
 /// Ve bu tankların özelliklerini barındıracak bir Interface’imiz olsun.
 /// Tank özellikleri: Mesafe Ölç - Hareket Et - Ateş Et
 /// Tank1 tüm özelliklere sahip Lakin, “Tank2” isimli tankımızın ateş etme özelliğinin olmadığını 
 /// ve “Tank3” isimli tankımızın ise düşman ile mesafe ölçme yeteneği olmadığını 
 /// varsayarsak Interface Segregation tasarımını uygulayın
 /// </summary>

    interface ITankMesafe
    {
        void mesafe();
    }

    interface ITankHareket
    {
        void hareket();
    }

    interface ITankAtes
    {
        void ates();
    }

    interface ITANK : ITankAtes, ITankHareket, ITankMesafe
    {

    }

    class Tank1 : ITANK
    {
        public void ates()
        {
            Console.WriteLine("Tank1 ateş ediyor !");
        }

        public void hareket()
        {
            Console.WriteLine("Tank1 hareket ediyor !");
        }

        public void mesafe()
        {
            Console.WriteLine("Tank1 düşman mesafesini ölçüyor !");
        }
    }
    class Tank2 : ITankHareket, ITankMesafe
    {
        public void hareket()
        {
            Console.WriteLine("Tank2 hareket ediyor !");
        }

        public void mesafe()
        {
            Console.WriteLine("Tank2 düşman mesafesini ölçüyor !");
        }
    }
    class Tank3 : ITankHareket, ITankAtes
    {
        public void ates()
        {
            Console.WriteLine("Tank3 ateş ediyor !");
        }

        public void hareket()
        {
            Console.WriteLine("Tank3 hareket ediyor !");
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Tank1 tank1 = new Tank1();
            Tank2 tank2 = new Tank2();
            Tank3 tank3 = new Tank3();
            tank1.mesafe();
            tank1.hareket();
            tank1.ates();
            Console.WriteLine("\n");
            tank2.mesafe();
            tank2.hareket();

            Console.WriteLine("\n");
            tank3.hareket();
            tank3.ates();

            Console.ReadKey();

        }
    }
}
