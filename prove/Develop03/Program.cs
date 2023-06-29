using System;
using System.Collections.Generic;

// Main program class
public class Program
{
    public static void Main(string[] args)
    {
        // Create a scripture library
        ScriptureLibrary library = new ScriptureLibrary();

        // Display the initial scripture
        library.DisplayCurrentScripture();

        // Loop until all words are hidden or user types 'quit'
        while (true)
        {
            string input = Console.ReadLine();

            if (input == "quit")
            {
                return;
            }
            else
            {
                if (library.AllWordsHidden())
                {
                    library.MoveToNextScripture();
                    library.DisplayCurrentScripture();
                }
                else
                {
                    library.HideRandomWord();
                    library.DisplayCurrentScripture();
                }
            }
        }
    }
}

//Showing Creativity and Exceeding Requirements: The program works with a library of scriptures rather than a single one. I chose scriptures at random to present to the user, so the program will display the first scripture and hide random words from it each time the user presses Enter. Once all the words in the current scripture are hidden, it will automatically move to the next scripture and repeat the process. The program will exit if the user types "quit".