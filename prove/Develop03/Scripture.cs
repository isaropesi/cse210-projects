// Scripture class to store and manipulate the scripture
public class Scripture
{
    private List<Word> words;
    private Reference reference;

    public Scripture(string referenceText, string scriptureText)
    {
        reference = new Reference(referenceText);
        words = new List<Word>();

        // Split the scripture text into words and create Word objects
        string[] wordTexts = scriptureText.Split(' ');
        foreach (string wordText in wordTexts)
        {
            words.Add(new Word(wordText));
        }
    }

    // Method to hide a random word in the scripture
    public void HideRandomWord()
    {
        Random random = new Random();
        List<Word> visibleWords = words.FindAll(word => !word.IsHidden);

        if (visibleWords.Count > 0)
        {
            int randomIndex = random.Next(visibleWords.Count);
            Word word = visibleWords[randomIndex];
            word.IsHidden = true;
            word.Text = new string('_', word.Text.Length);
        }
    }

    // Method to check if all words in the scripture are hidden
    public bool AllWordsHidden()
    {
        return words.TrueForAll(word => word.IsHidden);
    }

    // Method to display the scripture with hidden words
    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(reference.Text);

        foreach (Word word in words)
        {
            if (word.IsHidden)
            {
                Console.Write(new string('_', word.Text.Length) + " ");
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }

        Console.WriteLine("\n\nPress Enter to continue or type 'quit' to exit.");
    }
}