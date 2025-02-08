// Program.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Clear();
        Scripture scripture = ScriptureLoader.LoadRandomScripture("scriptures.txt");
        
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit") break;
            
            scripture.HideRandomWords(3);
        }
        
        Console.Clear();
        Console.WriteLine("All words are hidden! Program ending.");
    }
}

// Scripture.cs
class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    
    public Scripture(string reference, string text)
    {
        _reference = new Reference(reference);
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }
    string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scriptures.txt");

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}\n" + string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }
    
    public void HideRandomWords(int count)
    {
        Random random = new Random();
        var visibleWords = _words.Where(w => !w.IsHidden).ToList();
        
        for (int i = 0; i < count && visibleWords.Any(); i++)
        {
            Word word = visibleWords[random.Next(visibleWords.Count)];
            word.Hide();
            visibleWords.Remove(word);
        }
    }
    
    public bool IsCompletelyHidden() => _words.All(w => w.IsHidden);
}

// Reference.cs
class Reference
{
    private string _text;
    
    public Reference(string text)
    {
        _text = text;
    }
    
    public string GetDisplayText() => _text;
}

// Word.cs
class Word
{
    private string _text;
    public bool IsHidden { get; private set; }
    
    public Word(string text)
    {
        _text = text;
        IsHidden = false;
    }
    
    public void Hide()
    {
        IsHidden = true;
    }
    
    public string GetDisplayText()
    {
        return IsHidden ? new string('_', _text.Length) : _text;
    }
}

// ScriptureLoader.cs
class ScriptureLoader
{
    public static Scripture LoadRandomScripture(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        Random random = new Random();
        string randomLine = lines[random.Next(lines.Length)];
        
        var parts = randomLine.Split('|');
        return new Scripture(parts[0], parts[1]);
    }
}
