using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    private Random _random = new Random();

    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }

    // usedPromptsToday vem do Journal (já inclui o que foi carregado do arquivo)
    public string GetRandomPrompt(List<string> usedPromptsToday)
    {
        if (usedPromptsToday.Count == _prompts.Count)
        {
            return "All prompts for today have already been used.";
        }

        string prompt = _prompts[_random.Next(_prompts.Count)];

        while (usedPromptsToday.Contains(prompt))
        {
            prompt = _prompts[_random.Next(_prompts.Count)];
        }

        return prompt;
    }
}
