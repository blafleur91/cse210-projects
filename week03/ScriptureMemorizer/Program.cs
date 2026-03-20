using System;

class Program
{
    static void Main(string[] args)
    {
        // I enhanced my program by adding random generation to call a random reference and a random scripture.
        // it then calls them from a new class called random.

        Random ranIndex = new Random();
        int index = ranIndex.Next(5);
        IndexGenerator generator = new IndexGenerator();
        string book = generator.GetRandomBook(index);
        int chapter = generator.GetRandomChapter(index);
        int verse = generator.GetRandomVerse(index);
        int endVerse = generator.GetRandomEndVerse(index);
        string text = generator.GetRandomScripture(index);
        

        Reference reference = new Reference(book, chapter, verse, endVerse);
        Scripture scripture = new Scripture(reference, text);

        string done = "";
        while (done != "quit")
        {
            Console.Clear();
            string qoute = scripture.GetDisplayText();
            Console.WriteLine(qoute);
            done = Console.ReadLine();
            scripture.HideRandomWords(3);
            if (scripture.IsCompletelyHidden() == true)
            {
                Console.Clear();
                qoute = scripture.GetDisplayText();
                Console.WriteLine(qoute);
                done = "quit";
            }
        }
    }
}