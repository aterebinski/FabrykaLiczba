using System;

namespace FabrykaLiczb
{
    class Program
    {
        


        static void Main(string[] args)
        {
            NumberGenerator nGen;
            //Sprawdz += NumberManager.sprawdzCzyPodzielnePrzez2;
            //Sprawdz += NumberManager.sprawdzCzyPodzielnePrzez3;
            Console.WriteLine("Podaj liczbę: ");
            string sLiczba = Console.ReadLine();
            int liczba = int.Parse(sLiczba);
            

        }
    }

    class NumberGenerator
    {
        

        int start(int liczba)
        {
            liczba++;
            
            return liczba;
        }
    }

    class NumberManager
    {
        public delegate int Sprawdz(int liczba);

        public NumberManager(NumberGenerator numberGenerator)
        {
            Sprawdz sprawdz = new Sprawdz(sprawdzCzyPodzielnePrzez2);
            sprawdz += sprawdzCzyPodzielnePrzez3;
        }

        public static int sprawdzCzyPodzielnePrzez2(int liczba)
        {
            if (liczba%2 == 0)
            {
                Console.WriteLine($"Liczba {liczba} jest podzilne przez 2!");
                return liczba;
            }

            return 0;
        }

        public static int sprawdzCzyPodzielnePrzez3(int liczba)
        {
            if (liczba%3 == 0)
            {
                Console.WriteLine($"Liczba {liczba} jest podzielna przez 3!");
                return liczba;
            }
            return 0;
        }

        public int sprawdzCzyPodzielnePrzez7(int liczba)
        {
            if (liczba%7 == 0)
            {
                Console.WriteLine($"Liczba {liczba} jest podzielna przez 7!");
                return liczba;
            }
            return 0;
        }
    }
}
