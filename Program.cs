using System;

namespace modularization_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //step 1
            //global data
            string[] grocery_items = { "nuts", "beans", "fish", "olive oil", "lentils", "eggs", "whole grains", "yogurt" };
            double[] groceryListItemsPrice = { .75, 3.00, 2.00, 1.00, 1.75, 7.49, 4.00, 1.29 };

            int userInput;

            outputGroceryList(grocery_items);
            userInput = endUserSelection();
outputPrice(userInput,grocery_items,groceryListItemsPrice);
        }

        //step 2
        //define method that outputs each item
        public static void outputGroceryList(string[] grocery_items)
        {
            for (int x = 0; x < grocery_items.Length; x++)
            {
                Console.WriteLine($"Enter {x} for {grocery_items[x]}");
            };
        }
        //step three
        //define method that asks the end-user to input their item
        public static int endUserSelection()
        {
            int userInput;
            Console.WriteLine("Please input a grocery list item");

            userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You enter item number {userInput}");

            return userInput;
        }

        //extra step
        public static void outputPrice(int userInput,string [] names,double[] price){
Console.WriteLine($"You enter item {userInput} {names [userInput]} for a price of {price[userInput].ToString("c")}");
        }
    }
}




