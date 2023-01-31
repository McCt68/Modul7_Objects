using System.Diagnostics;

namespace Modul7_Objects
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // User menu
            // Console.WriteLine("\nVælg den øvelse du vil se. 1 - 10");

            bool stayInLoop = true;


            while (stayInLoop)
            {
                Console.WriteLine("\nVælg den øvelse du vil se. 1 - 10, eller Nul hvis du vil afslutte programmet");


                string exersizeNumber = Console.ReadLine();

                switch (exersizeNumber)
                {
                    case "1":
                        ExersizeOne();
                        break;

                    case "2":
                        ExersizeTwo();
                        break;

                    case "3":
                        ExersizeTree();
                        break;

                    case "4":
                        ExersizeFour();
                        break;

                    case "5":
                        ExersizeFive();
                        break;

                    case "6":
                        ExersizeSix();
                        break;

                    case "7":
                        ExersizeSeven();
                        break;

                    case "8":
                        ExersizeEight();
                        break;

                    case "9":
                        ExersizeNine();
                        break;

                    case "10":
                        ExersizeTen();
                        break;

                    case "0":
                        Console.WriteLine("Programmet afsluttes. Tak for denne gang");
                        stayInLoop = false;
                        break;

                    default:
                        Console.WriteLine("Ugyldigt valg. Prøv venligst igen.");
                        break;


                }

            }

            // Øvelse 1
            static void ExersizeOne()
            {
                Console.WriteLine("Øvelse 1\n");
                ClassSevenOne hejVerden = new ClassSevenOne();
                hejVerden.SigHej();

            }

            // Øvelse 2
            static void ExersizeTwo()
            {
                Console.WriteLine("Øvelse 2");
                Matematik Tal = new Matematik("24");
            }

            // Øvelse 3
            static void ExersizeTree()
            {
                Console.WriteLine("Øvelse 3");
                Matematik lagtSammen = new Matematik("48");
                lagtSammen.LægSammen(51, 5);
            }

            // Øvelse 4
            static void ExersizeFour() {
                Console.Clear();
                Console.WriteLine("Øvelse 4");

                Matematik trækFra = new Matematik("455");               
                Console.WriteLine(trækFra.TrækFra(25, 10).ToString()); 
            }

            // Øvelse 5
            static void ExersizeFive() {
                Console.Clear();
                Console.WriteLine("Øvelse 5");

                Matematik ØvelseFem = new Matematik("12455");
                ØvelseFem.PlusTotal(55);
                ØvelseFem.Sum();
            }

            // Øvelse 6
            static void ExersizeSix() {
                Console.Clear();
                Console.WriteLine("Øvelse 6");

                Person øvelse6 = new Person();

                øvelse6.navn = "Michael";
                øvelse6.eMail = "Michael@yousee.com";

                øvelse6.printPersonInformation();
                
            }

            // Øvelse 7
            static void ExersizeSeven() { }

            // Øvelse 8
            static void ExersizeEight() { }

            // Øvelse 9
            static void ExersizeNine() { }

            // Øvelse 10
            static void ExersizeTen() { }


        }
    }
}