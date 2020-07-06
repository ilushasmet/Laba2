using System;

namespace Laba2_2semestr_
{
    class Program
    {
        static void Main(string[] args)
        {
            Kolo kolo = new Kolo();
            kolo.Display();


        }
    }

    class Kolo
    {
        protected int Rad = 6;

        public void Display()
        {
            Okruzhnost o = new Okruzhnost();  
            o.Rozmir();

            Tochka t = new Tochka(3, 2);
            t.TochkaPolzovatelya(4, 5);
            t.Proverka();
        }

        class Tochka: Kolo
        {
            
            public int Tochka_X0 { get; set; }
            public int Tochka_Y0 { get; set; }
            public Tochka(int x0, int y0)
            {
                Tochka_X0 = x0;
                Tochka_Y0 = y0;
            }

            public int Tochka_X { get; set; }
            public int Tochka_Y { get; set; }
            public void TochkaPolzovatelya(int x, int y)
            {
                Tochka_X = x;
                Tochka_Y = y;
            }

            public void Proverka()
            {
                Console.WriteLine();
                Console.WriteLine("TochkaKruga = (" + Tochka_X +"," + Tochka_Y + ").");
                Console.WriteLine("TochkaPolzovatelya = (" + Tochka_X0 + "," + Tochka_Y0 + ")." + "\n");
                int Uslovie = (Tochka_X - Tochka_X0) ^ 2 + (Tochka_Y - Tochka_Y0) ^ 2;
                if (Uslovie <= Rad)
                {
                    Console.WriteLine("The point belong to this circle!");
                }
                else
                {
                    Console.WriteLine("The point does not belong to this circle.");
                }
            }
            
        }

        class Okruzhnost: Kolo
        {
         
            public void Rozmir()
            {
                float plosha;
                float Dl_okr;
                int diametr;
                Console.WriteLine("Radius = " + Rad +"\n");
                float pi = 3.14f; 

                diametr = 2 * Rad;                                         
                Dl_okr = 2 * pi * Rad;
                plosha = pi * Rad * Rad;

                Console.WriteLine("Info: " + "\n");
                Console.WriteLine("Diametr = "+diametr + "\n" + "P = "+Dl_okr + "\n" + "S = "+plosha);
            }

            

        }

    }

}
