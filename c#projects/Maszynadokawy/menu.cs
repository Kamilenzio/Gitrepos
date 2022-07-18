using System;

namespace Maszyna
{
    class Program
    {
        static void Main(string[] args)
        {
            SERVICE();
        }
        private static void SERVICE()
        {
            try
            {


                CoffeMachine automat = new CoffeMachine();

                int wybor = 0;

                while (wybor <= 5)
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("WYBIERZ JEDNA Z OPCJI");
                    Console.WriteLine("1. Zakup");
                    Console.WriteLine("2. Sprawdz stan");
                    Console.WriteLine("3. Uzupełnij stany");
                    Console.WriteLine("4. Pobieranie zarobku");
                    Console.WriteLine("5. Stan konta");
                    Console.WriteLine("6. Wyjście");
                    wybor = Int32.Parse(Console.ReadLine());
                    Console.Clear();

                    if (wybor == 1)
                    {
                        automat.Store();
                    }
                    else if (wybor == 2)
                    {
                        automat.ConditionCheck();
                    }
                    else if (wybor == 3)
                    {
                        automat.Refill();
                    }
                    else if (wybor == 4)
                    {
                        automat.GetMoney();
                    }
                    else if (wybor == 5)
                    {
                        automat.StanKonta();
                    }
                    else if (wybor == 6)
                    {
                        automat.Exit();

                    }
                }
            }
            catch
            {
                Console.WriteLine("Try again");
                Console.Read();
            }
             } 
    }
}