using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    private List<string> _usedPrompts = new List<string>();
    private Random _random = new Random();

    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }

    public string GetRandomPrompt()
    {
        // Se todos já foram usados, avisa o usuário
        if (_usedPrompts.Count == _prompts.Count)
        {
            return "All prompts have already been used.";
        }

        string prompt = _prompts[_random.Next(_prompts.Count)];

        // Garante que não repete
        while (_usedPrompts.Contains(prompt))
        {
            prompt = _prompts[_random.Next(_prompts.Count)];
        }

        _usedPrompts.Add(prompt);
        return prompt;
    }
}
