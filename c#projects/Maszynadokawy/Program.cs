using System;

namespace Maszyna
{
    public class CoffeMachine : Machine
    {
        
        private int water = 1300;
        private int milk = 2500;
        private int coffe = 500;
        private int pennies = 0;
        private int cups = 20;
        


        public void Store()
        {
            Console.WriteLine("1. Latte, 7zl");
            Console.WriteLine("2. Cappuccino, 6zl");
            Console.WriteLine("3. Espresso, 4zl");

            Console.WriteLine("Wybierz kawe");
            int Coffe = int.Parse(Console.ReadLine());

            Console.WriteLine("Czy masz wystarczajaca kwote? Jesli tak wpisz liczbe rowna cenie kawy.");
            int PriceIntput = int.Parse(Console.ReadLine());

            if ((Coffe == 1) && (PriceIntput == 7) && ( water >= 350) && (milk >= 75) && (coffe >= 20) && (cups >= 1))
            {
                Console.Clear();
                Console.WriteLine("Przygotowuje Latte...");
                water -= 350;
                milk -= 75;
                coffe -= 20;
                cups -= 1;
                pennies += 7;
                Console.WriteLine("Twoje Latte jest gotowe!");
            } else if ((Coffe == 2) && (PriceIntput == 6) && ( water >= 200) && (milk >= 100) && (coffe >= 12) && (cups >= 1))
            {
                Console.Clear();
                Console.WriteLine("Przygotowuje Cappuccino...");
                water -= 200;
                milk -= 100;
                coffe -= 12;
                cups -= 1;
                pennies += 6;
                Console.WriteLine("Twoje Cappuccino jest gotowe!");
            } else if ((Coffe == 3) && (PriceIntput == 4) && ( water >= 250) && (coffe >= 16) && (cups >= 1)) 
            {
                Console.Clear();
                Console.WriteLine("Przygotowuje Espresso...");
                water -= 250;
                coffe -= 16;
                cups -= 1;
                pennies += 4;
                Console.WriteLine("Twoje Espresso jest gotowe!");
            } else 
            {
                Console.WriteLine("Sprawd?? stany, je??eli wszystko si?? zgadza da??e?? za ma??o monet!");
            }
        }
        public void Refill()
        {
           Console.WriteLine("Ile wody chcesz uzupe??ni???");
           water += int.Parse(Console.ReadLine());
           Console.WriteLine("");

           Console.WriteLine("Ile mleka chcesz uzupe??ni???");
           milk += int.Parse(Console.ReadLine());
           Console.WriteLine("");

           Console.WriteLine("Ile kawy chcesz uzupe??ni???");
           coffe += int.Parse(Console.ReadLine());
           Console.WriteLine("");

           Console.WriteLine("Ile kubk??w chcesz uzupe??ni???");
           cups += int.Parse(Console.ReadLine());
           Console.WriteLine("");
        }
        public void ConditionCheck()
        {
            Console.WriteLine("Poziom wody wynosi: " + water + " ml");
            Console.WriteLine("Poziom mleka wynosi: " + milk + " ml");
            Console.WriteLine("Ilosc kawy: " + coffe + " szt");
            Console.WriteLine("Ilo??c kubk??w: " + cups + " szt");
            Console.WriteLine("Ilo???? monet: " + pennies + " szt");
        }
        public void GetMoney()
        {
            Console.WriteLine("Ile monet chcesz wyp??aci??");
            int withdrawal = int.Parse(Console.ReadLine());
            if (withdrawal > pennies)
            {
                Console.WriteLine("Nie posiadasz tylu monet");
            } else 
            {
                pennies = pennies - withdrawal;
            }
        }
        public void StanKonta()
        {
            Console.WriteLine("Tw??j stan konta wynosi:" + pennies + "z??");
        }
        public void Exit()
        {
            
        }

    }
}