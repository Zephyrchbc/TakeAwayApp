using System;
using System.Collections.Generic;

namespace TakeAwayApp
{
    class Program
    {
        //Global Variables
        static List<string> deliveryName = new List<string>() { "delivery", "pickup" };

        static decimal FinalPrice = 0.00M;

        //Pizza Chosen List
        static List<string> pizzaChoice = new List<string>()
        {
            "Asparagus Pizza", "Mexican Pizza", "Salmon Pizza", "Horse Meat Pizza", "Seaweed Pizza", "Gorgonzola Pizza", "Pumpkin & Hummus Pizza"
            , "Cabbage, Pork, Noodles, And Squid Pizza", " Red Peanut Curry Pizza", "Chicken Tikka Masala, Tandoori & Butter Chicken Pizza"
            , "Caramelised Onions, Apples And Goat Cheese Pizza ", "Smoked Reindeer Pizza" };

        


        static void Main(string[] args)
        {

            string flagmain = "";
            while (!flagmain.Equals("jerome"))
            {
                OrderName();

                PizzaOrder();

                flagmain = CheckFlag();

               
            }
        }
        static void PizzaOrder()
        {
            decimal sumPrice = 0.00M;
            decimal Gourmet = 5.00M;
            decimal Regular = 8.50M;


            for (int i = 0; i < 5; i++) 
            {

                int pizzaSelection = CheckPizza(
                "What Pizza u want homie\n" +
                " ___________________________________________________________________\n" +
                "|1. Asparagus Pizza                                        | $8.50 |\n" +
                "|2. Mexican Pizza                                          | $8.50 |\n" +
                "|3. Salmon Pizza                                           | $8.50 |\n" +
                "|4. Horse Meat Pizza                                       | $8.50 |\n" +
                "|5. Seaweed Pizza                                          | $8.50 |\n" +
                "|6. Gorgonzola Pizza                                       | $8.50 |\n" +
                "|7. Pumpkin & Hummus Pizza                                 | $8.50 |\n" +
                "|__________________________________________________________|_______|\n" +
                "|8. Cabbage, Pork, Noodles, And Squid Pizza                | $5.00 |\n" +
                "|9. Red Peanut Curry Pizza                                 | $5.00 |\n" +
                "|10. Chicken Tikka Masala, Tandoori & Butter Chicken Pizza | $5.00 |\n" +
                "|11. Caramelised Onions, Apples And Goat Cheese Pizza      | $5.00 |\n" +
                "|12. Smoked Reindeer Pizza                                 | $5.00 |\n" +
                "|__________________________________________________________|_______|"
                , 1, 12);

                Console.WriteLine($"You have selected: {pizzaSelection}");
                //Calculator for the prices of pizza
                if (pizzaSelection > 7)
                {
                    sumPrice = sumPrice + Gourmet;

                    Console.WriteLine($"\nThe pizza you have chosen is {pizzaChoice[pizzaSelection - 1]}\n" +
                        "\nYour pizza costs $" + Gourmet);

                    Console.WriteLine($"\nYour total price is ${sumPrice}\n");

                    FinalPrice = sumPrice;
                }
                else
                {
                    sumPrice = sumPrice + Regular;

                    Console.WriteLine($"\nThe pizza you have chosen is { pizzaChoice[pizzaSelection - 1]}\n" +
                        "\nYour pizza costs $" + Regular);

                    Console.WriteLine($"\nYour total price is ${sumPrice}\n");

                    FinalPrice = sumPrice;
                }
                Console.WriteLine($"This is your final price {FinalPrice}\n");
                //get users selection
                Console.WriteLine("Press (ENTER) to choose more pizzas for your order or type 'jerome' to finish your order");
                string userInput = Console.ReadLine();
                Console.Clear();

          

                if (userInput.Equals("jerome"))
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

        }

        static string CheckFlag()
        {
            while (true)
            {
                Console.WriteLine("Press (ENTER) on your keyboard if you would like to order more or please type (jerome) if you are done with your order");
                string UserInput = Console.ReadLine();

                if (UserInput.Equals("jerome") || UserInput.Equals(""))
                {
                    return UserInput;
                }
                
                Console.WriteLine("mexcianshateme");
            }
        }
        static void OrderName()
        {
            Console.WriteLine("Please Enter Your Name Homie\n");

            string CustomerName = Console.ReadLine();
            Console.WriteLine($"This Is Your Name Homie: {CustomerName}");

            //Enter and store delivery choice

            int deliveryname = CheckDelivery("Please select a choice for recieving your order:\n1) Delivery | 2) Pickup\n", 1, 2);

            //Display delivery choice
            Console.WriteLine($"\nYou've Selected: {deliveryName[deliveryname - 1]}\n");

        }
        static int CheckDelivery(string question, int min, int max)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(question);
                    int userint = Convert.ToInt32(Console.ReadLine());
                    if ((userint < 1) || (userint > 2))
                    {
                        //Display a error message letting the user know its too low/high what they have entered
                        Console.WriteLine("\nError:Enter the number 1-2 for recieving your order" +
                            "| Please press enter to try again");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        return userint;
                    }
                }
                catch (System.FormatException)
                {
                    //Display an error message letting the user know the intergers can only be entered
                    Console.WriteLine("\nError: Enter the number 1-2 for recieving your order\n" +
                        "| Please press enter to try again");
                    Console.ReadLine();
                    Console.Clear();



                }
            }


        }
        static int CheckPizza(string question, int min, int max)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(question);
                    int userint = Convert.ToInt32(Console.ReadLine());
                    if ((userint < 1) || (userint > 12))
                    {
                        //Display a error message letting the user know its too low/high what they have entered
                        Console.WriteLine("\nError:Enter the number 1-12 for recieving your order" +
                            "| Please press enter to try again");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        return userint;
                    }
                }
                catch (System.FormatException)
                {
                    //Display an error message letting the user know the intergers can only be entered
                    Console.WriteLine("\nError: Enter the number 1-12 for recieving your order\n" +
                        "| Please press enter to try again");
                    Console.ReadLine();
                    Console.Clear();



                }
            }


        }
    }


}
















