using System;

class Program
{
    static void Main(string[] args)
    {
        //Display Menu
        int userMenuChoice = 0;
        while (userMenuChoice != 4)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Mindfulness Program!\r\n");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select an option from the menu: ");
            string response = Console.ReadLine();
            userMenuChoice = Convert.ToInt32(response);

            if (userMenuChoice == 1)
            {
                Console.Clear();
                Breathing newBreathing = new Breathing();
                newBreathing.GetOpeningMessage();
                Console.WriteLine();
                newBreathing.EstablishDuration();
                Console.WriteLine();
                newBreathing.StartBreathingActivity();
                Console.WriteLine();
                newBreathing.GetEndingMessage();
            }

            else if (userMenuChoice == 2)
            {
                Console.Clear();
                Reflecting newReflecting = new Reflecting();
                newReflecting.GetOpeningMessage();
                Console.WriteLine();
                newReflecting.EstablishDuration();
                Console.WriteLine();
                newReflecting.StartReflectingActivity();
                Console.WriteLine();
                newReflecting.GetEndingMessage();
            }

            else if (userMenuChoice == 3)
            {
                Console.Clear();
                Listing newListing = new Listing();
                newListing.GetOpeningMessage();
                Console.WriteLine();
                newListing.EstablishDuration();
                Console.WriteLine();
                newListing.StartListingActivity();
                Console.WriteLine();
                newListing.GetEndingMessage();
            }
        }
    }
}

//Showing Creativity and Exceeding Requirements: The Program displays to the user a countdown for whe they may begin and also for when they will be redirected to the menu options again; It also has instructions within the description of each activity.