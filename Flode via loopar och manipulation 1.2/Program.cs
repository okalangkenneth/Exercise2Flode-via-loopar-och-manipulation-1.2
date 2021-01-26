using System;

namespace Flode_via_loopar_och_manipulation_1._2
    

{
    class Program
    {
        static void Main(string[] args)
        {
            // MainMenu () anropas inuti while-loop.

            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        public static bool MainMenu()

        {
            Console.Clear();  //För att säkerställa att menyn kommer att skrivas ut på en tom konsolskärm.
            Console.Write("Du har kommit till huvudmenyn.Du kommer navigera genoma \natt" +
                          " skriva in siffror for att testa olika funktionär");
            Console.WriteLine("");
            Console.WriteLine("\nVälj alternativ 1, 2 , 3 eller 4  : ");
            Console.WriteLine("");
            Console.WriteLine("1) FleraBiljetter: ");
            Console.WriteLine("2) Upprepa Tio Gånger: ");
            Console.WriteLine("3) Det Tredje Ordet: ");
            Console.WriteLine("4) Exit");

            // läsa vad användaren angav för att avgöra om de valde alternativet "1", "2" eller "3."

            switch (Console.ReadLine()) //
            {
                case "1":
                    FleraBiljetter();
                    return true;
                case "2":
                    UpprepaTioGånger();
                    return true;
                case "3":
                    DetTredjeOrdet();
                    return true;

                //Om användaren väljer alternativ 4 kommer MainMenu () 
                //-metoden att returnera falskt och programmet avslutas.
                case "4" :
                    return false;
                //Om användaren anger andra värden än 1, 2 eller 3., återgår metoden till true och 
                //menyn återställs så att användaren kan försöka igen.
                default:
                    return true;

                
            }

        }
        // Visa Menyval 1: Ungdom eller pensionär.
        public static void FleraBiljetter()
        {
            var totalPrice = 0;

            Console.WriteLine("Hur många biljetter?");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Ålder?");
                var input2 = Console.ReadLine();
                var number2 = Convert.ToInt32(input2);

                if (number2 <= 20 && number2 > 5)
                    totalPrice += 80;
                else if (number2 <= 5 || number2 >= 100)
                    totalPrice += 0;
                else if (number2 >= 64 && number2 < 100)
                    totalPrice += 90;
                else
                    totalPrice += 120;
            }

            Console.WriteLine($"\nThe total price is: {totalPrice} kr.");
            Console.ReadLine();
        }
            // Visa Menyval 2: Upprepa tio gånger.
            public static void UpprepaTioGånger()
        {
            Console.WriteLine("Ange en godtycklig text");
            var input = Console.ReadLine();
            for (int i = 0; i < 10; i++)
                Console.Write(input + ",");
            Console.Write("\nTryck på Enter för att återgå till huvudmenyn");
            Console.ReadLine();
        }
        // Visa Menyval 3: Det tredje ordet.
        public static void DetTredjeOrdet()
        {
            Console.WriteLine("Ange en mening med minst 3 ord");
            var input = Console.ReadLine();
            {
                Console.WriteLine(input.Split(' ')[2]);
                Console.Write("\nTryck på Enter för att återgå till huvudmenyn");
                Console.ReadLine();
            }
        }
        public static void Exit()
        {

        }
    }

}
