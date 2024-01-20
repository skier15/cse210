public class PromptGenerator
{
    List<string> _prompts = new List<string>() {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What activity did I do today that brought me the least pleasure?",
        "What was the strongest positive emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
    };

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int random = randomGenerator.Next(_prompts.Count);
        string result = _prompts[random];
        return result;
    }
}