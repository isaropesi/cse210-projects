public class PromptGenerator
{
    private List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("What was the most inspiring conversation I had today?");
        prompts.Add("Describe a moment of unexpected kindness that you experienced today.");
        prompts.Add("In what ways did I challenge myself today?");
        prompts.Add("Reflect on a mistake or failure you encountered today and what you learned from it.");
        prompts.Add("What is one thing you accomplished today that you're proud of?");
        prompts.Add("Write about a new idea or perspective you gained today.");
        prompts.Add("Describe a moment of laughter or joy that brightened your day.");
        prompts.Add("Reflect on a difficult decision you made today and how it has affected you.");
        prompts.Add("Write about a book, article, or piece of art that made an impact on you today.");
        prompts.Add("In what ways did you take care of yourself physically, emotionally, or mentally today?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
