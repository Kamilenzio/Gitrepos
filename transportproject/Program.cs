using System;
using System.IO;

namespace Projekt_na_HTDP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Witaj! Narzedzie pomoże sprawdzić jaki maksymalny tonaż dopuszczalny jest dla twojego pojazdu");
            System.Console.WriteLine("Możesz także sprawdzić szczegóły dotyczące konkretnego modelu z 10 najpopularniejszych");
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("Press any hotkey to continue.. :)");
            Console.ReadKey();
            Console.Clear();
            poczatek:
            static void listaPojazdow()
            {
            System.Console.WriteLine("Ponizej lista 10 najpopularniejszych samochodow transportowych :)");
            System.Console.WriteLine("Wybierz numer pojazdu, ktory cie interesuje. Od 1 do 10 i wcisnij ENTER ");
            System.Console.WriteLine("");
            System.Console.WriteLine("Po cisnieciu odpowiedniego numeru wyswietla sie szczegolowe informacje o danym pojezdzie i prosty kalkukator, ktory obliczy ile brakuje do pelnego zaladunku i poinformuje czy dany pojazd jest w stanie sprostac obciazeniu.");
            System.Console.WriteLine("");
            System.Console.WriteLine("1. Volat 750440-010");
            System.Console.WriteLine("2. Hino 700");
            System.Console.WriteLine("3. Ashok Leyland Captain");
            System.Console.WriteLine("4. Ford Cargo");
            System.Console.WriteLine("5. SISU Polar");
            System.Console.WriteLine("6. Iveco Strator");
            System.Console.WriteLine("7. Uro K5-30.16");
            System.Console.WriteLine("8. Ural Next");
            System.Console.WriteLine("9.Hyundai Xcient");
            System.Console.WriteLine("10. FAW J6P");
            }
            listaPojazdow();
            int ciezar;
            int maxciezar;
            int roznica;
            int pojazd = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (pojazd)
            {
 ////////////////////////             
                    case 1:
                System.Console.WriteLine("Wybor 1. Volat 750440-010. Typu firanka (maks 25T). Zaladunek mozliwy z kazdej strony. Wysokosc: 2,7M");
                System.Console.WriteLine(" Podaj ciezar w kilogramach ile chcesz przewiezc: ");
                maxciezar = 25000;
                ciezar = int.Parse(Console.ReadLine());
                roznica = maxciezar - ciezar;
                    if (ciezar < 25000 & ciezar >= 0)
                {
                    System.Console.WriteLine("Przewozisz " + ciezar + "kg, na auto mozna zaladowac jeszcze " + roznica + "kg");
                }
                    else
                    {
                        System.Console.WriteLine("Ciezar zaladunku przekracza mozliwosci tego auta, sprwadz inne :)");
                    }
                break;
 ////////////////////////   

                    case 2:
                System.Console.WriteLine("Wybor 2. Hino 700. Typu ... (maks ...). Zaladunek mozliwy z ... Wysokosc: ...M");
                System.Console.WriteLine(" Podaj ciezar w kilogramach ile chcesz przewiezc: ");
                maxciezar = 25000;
                ciezar = int.Parse(Console.ReadLine());
                roznica = maxciezar - ciezar;
                    if (ciezar < 25000 & ciezar >= 0)
                {
                    System.Console.WriteLine("Przewozisz " + ciezar + "kg, na auto mozna zaladowac jeszcze " + roznica + "kg");
                }
                    else
                    {
                        System.Console.WriteLine("Ciezar zaladunku przekracza mozliwosci tego auta, sprwadz inne :)");
                    }
                break;
 ////////////////////////                               
                    case 3:
                System.Console.WriteLine("Wybor 3. Ashok Leyland Captain. Typu ... (maks. ...T). Zaladunek mozliwy z ... Wysokosc: ...M");
                System.Console.WriteLine(" Podaj ciezar w kilogramach ile chcesz przewiezc: ");
                maxciezar = 25000;
                ciezar = int.Parse(Console.ReadLine());
                roznica = maxciezar - ciezar;
                    if (ciezar < 25000 & ciezar >= 0)
                {
                    System.Console.WriteLine("Przewozisz " + ciezar + "kg, na auto mozna zaladowac jeszcze " + roznica + "kg");
                }
                    else
                    {
                        System.Console.WriteLine("Ciezar zaladunku przekracza mozliwosci tego auta, sprwadz inne :)");
                    }
                break;
 ////////////////////////                               
                    case 4:
                System.Console.WriteLine("Wybor 4. Ford Cargo. Typu ... (maks ...). Zaladunek mozliwy z ... Wysokosc: ...M");
                System.Console.WriteLine(" Podaj ciezar w kilogramach ile chcesz przewiezc: ");
                maxciezar = 25000;
                ciezar = int.Parse(Console.ReadLine());
                roznica = maxciezar - ciezar;
                    if (ciezar < 25000 & ciezar >= 0)
                {
                    System.Console.WriteLine("Przewozisz " + ciezar + "kg, na auto mozna zaladowac jeszcze " + roznica + "kg");
                }
                    else
                    {
                        System.Console.WriteLine("Ciezar zaladunku przekracza mozliwosci tego auta, sprwadz inne :)");
                    }
                break;
 ////////////////////////                                
                   case 5:
                System.Console.WriteLine("Wybor 5. SISU Polar. Typu ... (maks ...). Zaladunek mozliwy z ... Wysokosc: ...M");
                System.Console.WriteLine(" Podaj ciezar w kilogramach ile chcesz przewiezc: ");
                maxciezar = 25000;
                ciezar = int.Parse(Console.ReadLine());
                roznica = maxciezar - ciezar;
                    if (ciezar < 25000 & ciezar >= 0)
                {
                    System.Console.WriteLine("Przewozisz " + ciezar + "kg, na auto mozna zaladowac jeszcze " + roznica + "kg");
                }
                    else
                    {
                        System.Console.WriteLine("Ciezar zaladunku przekracza mozliwosci tego auta, sprwadz inne :)");
                    }
                break;
 ////////////////////////                           
                        case 6:
                System.Console.WriteLine("Wybor 6. Iveco Strator. Typu ... (maks ...). Zaladunek mozliwy z ... Wysokosc: ...M");
                System.Console.WriteLine(" Podaj ciezar w kilogramach ile chcesz przewiezc: ");
                maxciezar = 25000;
                ciezar = int.Parse(Console.ReadLine());
                roznica = maxciezar - ciezar;
                    if (ciezar < 25000 & ciezar >= 0)
                {
                    System.Console.WriteLine("Przewozisz " + ciezar + "kg, na auto mozna zaladowac jeszcze " + roznica + "kg");
                }
                    else
                    {
                        System.Console.WriteLine("Ciezar zaladunku przekracza mozliwosci tego auta, sprwadz inne :)");
                    }
                break;
 ////////////////////////                            
                       case 7:
                System.Console.WriteLine("Wybor 7. Uro K5-30.16. Typu ... (maks ...). Zaladunek mozliwy z ... Wysokosc: ...M");
                System.Console.WriteLine(" Podaj ciezar w kilogramach ile chcesz przewiezc: ");
                maxciezar = 25000;
                ciezar = int.Parse(Console.ReadLine());
                roznica = maxciezar - ciezar;
                    if (ciezar < 25000 & ciezar >= 0)
                {
                    System.Console.WriteLine("Przewozisz " + ciezar + "kg, na auto mozna zaladowac jeszcze " + roznica + "kg");
                }
                    else
                    {
                        System.Console.WriteLine("Ciezar zaladunku przekracza mozliwosci tego auta, sprwadz inne :)");
                    }
                break;
 ////////////////////////                         
                      case 8:
                System.Console.WriteLine("Wybor 8. Ural Next. Typu ... (maks ...). Zaladunek mozliwy z ... Wysokosc: ...M");
                System.Console.WriteLine(" Podaj ciezar w kilogramach ile chcesz przewiezc: ");
                maxciezar = 25000;
                ciezar = int.Parse(Console.ReadLine());
                roznica = maxciezar - ciezar;
                    if (ciezar < 25000 & ciezar >= 0)
                {
                    System.Console.WriteLine("Przewozisz " + ciezar + "kg, na auto mozna zaladowac jeszcze " + roznica + "kg");
                }
                    else
                    {
                        System.Console.WriteLine("Ciezar zaladunku przekracza mozliwosci tego auta, sprwadz inne :)");
                    }
                break;
 ////////////////////////                           
                        case 9:
                System.Console.WriteLine("Wybor 9. Hyundai Xcient. Typu ... (maks ...). Zaladunek mozliwy z ... Wysokosc: ...M");
                System.Console.WriteLine(" Podaj ciezar w kilogramach ile chcesz przewiezc: ");
                maxciezar = 25000;
                ciezar = int.Parse(Console.ReadLine());
                roznica = maxciezar - ciezar;
                    if (ciezar < 25000 & ciezar >= 0)
                {
                    System.Console.WriteLine("Przewozisz " + ciezar + "kg, na auto mozna zaladowac jeszcze " + roznica + "kg");
                }
                    else
                    {
                        System.Console.WriteLine("Ciezar zaladunku przekracza mozliwosci tego auta, sprwadz inne :)");
                    }
                break;
 ////////////////////////                         
                        case 10:
                System.Console.WriteLine("Wybor 10. FAW J6P. Typu ... (maks ...). Zaladunek mozliwy z ... Wysokosc: ...M");
                System.Console.WriteLine(" Podaj ciezar w kilogramach ile chcesz przewiezc: ");
                maxciezar = 25000;
                ciezar = int.Parse(Console.ReadLine());
                roznica = maxciezar - ciezar;
                    if (ciezar < 25000 & ciezar >= 0)
                {
                    System.Console.WriteLine("Przewozisz " + ciezar + "kg, na auto mozna zaladowac jeszcze " + roznica + "kg");
                }
                    else
                    {
                        System.Console.WriteLine("Ciezar zaladunku przekracza mozliwosci tego auta, sprwadz inne :)");
                    }
                break;
 ////////////////////////                   
                default:
                   System.Console.WriteLine("Wybrales bledna liczbe :/ Jesli chcesz wrocic do Menu wpisz 1"); 
                break;  
            }
        minimenu:
        System.Console.WriteLine("");
        System.Console.WriteLine("Aby wrocic do poczatkowego Menu wcisnij 1, zamknac program wcisnij 2");
        int menu = int.Parse(Console.ReadLine());
////////////// MINI MENU
            Console.Clear();
            switch (menu)
            {
                case 1:
                
                goto poczatek;

                case 2:

                return;
                default:
                System.Console.WriteLine(" Wpisz 1 lub... zamknij program");
                System.Console.WriteLine("");
                goto minimenu;
            }
        

           




        }

        
    }
}
