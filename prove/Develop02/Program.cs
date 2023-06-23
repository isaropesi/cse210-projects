using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        while (true)
        {
            menu.ShowMenu();
            Console.Write("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());

            menu.HandleChoice(choice);

            Console.WriteLine();
        }
    }
}

//Showing Creativity and Exceeding Requirements: One common problem that keeps people from writing in their journal is finding the time and motivation to sit down and write. To address this, I've implemented a reminder feature that prompts the user to write a journal entry at specified intervals. To that, I added a new method called 'SetReminder'.