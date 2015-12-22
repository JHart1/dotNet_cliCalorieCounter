using System;

namespace JHart1.ConsoleCalorieTracker
{
    class Program
    {
        static void Main()
        {
            int caloriesTotal = 0;
            bool moreCalories = true;
            int mealNum = 1;

            while (moreCalories)
            {
                // Prompt the user for minutes exercised
                Console.Write("Meal #" + mealNum + " - Enter grams of fat (type \"quit\" to exit): ");
                string entry = Console.ReadLine();

                if (entry == "quit")
                {
                    moreCalories = false;
                }
                else
                {

                    int fat = int.Parse(entry);

                    // Add minutes exercised to total
                    caloriesTotal = caloriesTotal + fat * 9;

                    // Prompt the user for minutes exercised
                    Console.Write("Enter grams of carbohydrates (type \"quit\" to exit): ");
                    entry = Console.ReadLine();

                    if (entry == "quit")
                    {
                        moreCalories = false;
                    }
                    else
                    {

                        int carb = int.Parse(entry);

                        // Add minutes exercised to total
                        caloriesTotal = caloriesTotal + carb * 4;

                        // Prompt the user for minutes exercised
                        Console.Write("Enter grams of protein (type \"quit\" to exit): ");
                        entry = Console.ReadLine();

                        if (entry == "quit")
                        {
                            moreCalories = false;
                        }
                        else
                        {

                            int protein = int.Parse(entry);

                            // Add minutes exercised to total
                            caloriesTotal = caloriesTotal + protein * 4;

                            // Display total minutes exercised to the screen
                            Console.WriteLine("You've entered " + caloriesTotal + " calories today");
                        }
                    }
                }

                mealNum = mealNum + 1;
                // Repeat until the user quits
            }

            Console.WriteLine("Goodbye");

        }
    }
}
