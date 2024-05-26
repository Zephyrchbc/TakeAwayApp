using System;

namespace TakeAwayApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string flagmain = "";  
            while (!flagmain.Equals("jerome")||!flagmain.Equals(""))
            {
                PizzaOrder();

                flagmain = CheckFlag();
            }
        }
        static void PizzaOrder()
        {
            Console.WriteLine("What Pizza u want homie\n" +
                "1. Asparagus Pizza\n" +
                "2. Mexican Pizza\n" +
                "3. Baked Potato Pizza\n" +
                "4. Chicken Alfredo Pizza\n" +
                "5. Ham & Mushroom Pizza\n" +
                "6. Gorgonzola Pizza\n" +
                "7. Pumpkin & Hummus Pizza\n" +
                "8. Breakfast Pizza\n" +
                "9. Chicken Tikka Masala, Tandoori & Butter Chicken Pizza\n" +
                "10. Hawaian Pizza\n" +
                "11. Cheesy Garlic Pizza\n" +
                "12. Smoked Reindeer Pizza\n");
        }
        static string CheckFlag()
        {
            while (true)
            {
                Console.WriteLine("ihatemexicans");
                string UserInput = Console.ReadLine();
                if (UserInput.Equals("jerome")||UserInput.Equals(""))
                {
                    return UserInput;
                }
                Console.WriteLine("mexcianshateme");
            }
        }
    }


}
















