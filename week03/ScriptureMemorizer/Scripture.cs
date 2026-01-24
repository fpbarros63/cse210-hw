using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _rng;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _rng = new Random();

        // Split by spaces (approach acceptable for core requirement)
        _words = text
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(w => new Word(w))
            .ToList();
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{referenceText} - {scriptureText}";
    }

    public void HideRandomWords()
    {
        // pick only words that are NOT hidden yet
        List<int> visibleIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndexes.Add(i);
            }
        }

        if (visibleIndexes.Count == 0)
        {
            return;
        }

        // Hide "a few" words per step: hide up to 3, but not more than remaining visible
        int wordsToHide = Math.Min(3, visibleIndexes.Count);

        for (int n = 0; n < wordsToHide; n++)
        {
            int pickIndex = _rng.Next(visibleIndexes.Count);
            int wordIndex = visibleIndexes[pickIndex];

            _words[wordIndex].Hide();

            // remove that index. don't pick it again in this step
            visibleIndexes.RemoveAt(pickIndex);
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
