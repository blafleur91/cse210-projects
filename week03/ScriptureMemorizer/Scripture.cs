using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;    

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();
        // Trying to figure out how to split the text into the list. First attempt.
        string[] splitText = text.Split(' ');
        foreach (var word in splitText)
        {
            // _words.Add(word);

            // this is creating a new word object, not a list, which is called newWord
            Word newWord = new Word(word);
            newWord.Show();
            // from there, I can add the word object to the list object (_words)
            _words.Add(newWord);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        // what this line of code is doing is checking how many of the words are hidden, and having a running count for each
        // time the user presses enter.
        int visibleText = 0;
        foreach (Word w in _words)
        {
            if (w.IsHidden() == false)
            {
                visibleText++;
            }
        }

        numberToHide = Math.Min(numberToHide, visibleText);

        // I was having trouble with this part. I had i < numberToHide. that meant that unless there were as many words as numberToHide,
        // the program got stuck in a permanent loop trying to find enough words to hide. To fix it, I added the above code.
        Random ranIndex = new Random();
        for (int i = 0; i < numberToHide;)
        {
            // this needs the random generator to get an index.
            int index = ranIndex.Next(_words.Count);

            var originalWord = _words[index];
            if (originalWord.IsHidden() == false)
            {
                originalWord.Hide();
                i++;
            }

        }
    }

    public string GetDisplayText()
    {
        string fullScripture = _reference.GetDisplayText();
        foreach(var word in _words)
        {
            // the plus/equal tells the computer to add to fullScripture without having to write it out twice.
            fullScripture += word.GetDisplayText();
        }

        return fullScripture;
    }

    public bool IsCompletelyHidden()
    {
        // what this does is that it runs through the Word list and checks if any of them are showing. if they are it is false.
        // once all are hidden, it can return true, which will end the program.
        foreach (Word w in _words)
        {
            if (w.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}