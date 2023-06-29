// ScriptureLibrary class to manage the collection of scriptures
public class ScriptureLibrary
{
    private List<Scripture> scriptures;
    private Random random;
    private int currentScriptureIndex;

    public ScriptureLibrary()
    {
        scriptures = new List<Scripture>();
        random = new Random();
        currentScriptureIndex = 0;

        // Add scriptures to the library
        AddScripture("Moses 1:39", "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.");
        AddScripture("Matthew 5:14-16", "Ye are the light of the world. A city that is set on an hill cannot be hid; neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house; let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.");
        AddScripture("1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        AddScripture("Doctrine and Covenants 50:24", "That which is of God is light; and he that receiveth light, and continueth in God, receiveth more light; and that light groweth brighter and brighter until the perfect day.");
        AddScripture("Moses 7:18", "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them.");
        AddScripture("Matthew 11:28-30", "Come unto me, all ye that labour and are heavy laden, and I will give you rest; take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls; for my yoke is easy, and my burden is light.");
        AddScripture("2 Nephi 2:25", "Adam fell that men might be; and men are, that they might have joy.");
        AddScripture("Doctrine and Covenants 1:37-38", "Search these commandments, for they are true and faithful, and the prophecies and promises which are in them shall all be fulfilled; what I the Lord have spoken, I have spoken, and I excuse not myself; and though the heavens and the earth pass away, my word shall not pass away, but shall all be fulfilled, whether by mine own voice or by the voice of my servants, it is the same.");
        AddScripture("Abraham 3:22-23", "Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones; and God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast chosen before thou wast born.");
        AddScripture("Luke 24:36-39", "And as they thus spake, Jesus himself stood in the midst of them, and saith unto them, Peace be unto you; but they were terrified and affrighted, and supposed that they had seen a spirit; and he said unto them, Why are ye troubled? and why do thoughts arise in your hearts?; behold my hands and my feet, that it is I myself: handle me, and see; for a spirit hath not flesh and bones, as ye see me have.");
        AddScripture("Mosiah 4:30", "But this much I can tell you, that if ye do not watch yourselves, and your thoughts, and your words, and your deeds, and observe the commandments of God, and continue in the faith of what ye have heard concerning the coming of our Lord, even unto the end of your lives, ye must perish. And now, O man, remember, and perish not.");
        AddScripture("Doctrine and Covenants 82:10", "I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise.");

        // Shuffle the scriptures randomly
        ShuffleScriptures();
    }

    // Method to add a new scripture to the library
    private void AddScripture(string referenceText, string scriptureText)
    {
        scriptures.Add(new Scripture(referenceText, scriptureText));
    }

    // Method to shuffle the scriptures randomly
    private void ShuffleScriptures()
    {
        int n = scriptures.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            Scripture value = scriptures[k];
            scriptures[k] = scriptures[n];
            scriptures[n] = value;
        }
    }

    // Method to move to the next scripture
    public void MoveToNextScripture()
    {
        currentScriptureIndex++;
        if (currentScriptureIndex >= scriptures.Count)
        {
            // Reached the end, shuffle the scriptures again
            ShuffleScriptures();
            currentScriptureIndex = 0;
        }
    }

    // Method to hide a random word in the current scripture
    public void HideRandomWord()
    {
        Scripture currentScripture = scriptures[currentScriptureIndex];
        currentScripture.HideRandomWord();
    }

    // Method to check if all words in the current scripture are hidden
    public bool AllWordsHidden()
    {
        Scripture currentScripture = scriptures[currentScriptureIndex];
        return currentScripture.AllWordsHidden();
    }

    // Method to display the current scripture with hidden words
    public void DisplayCurrentScripture()
    {
        Scripture currentScripture = scriptures[currentScriptureIndex];
        currentScripture.DisplayScripture();
    }
}