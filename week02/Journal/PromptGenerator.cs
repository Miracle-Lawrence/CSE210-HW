public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public Random _random = new Random();

    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            return "No prompts available.";
        }

        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
