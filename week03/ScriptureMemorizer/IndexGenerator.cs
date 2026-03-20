public class IndexGenerator
{
    private List<string> _bookName;
    private List<int> _chapterNumber;

    private List<int> _verseNumber;
    private List<int> _endVerseNumber;
    private List<string> _scripture;

    public string GetRandomBook(int index)
    {
        // I might not need this line right below this since when it is active the .Adds say the initializition can be simplified.
        _bookName = new List<string>();
        _bookName.Add("John");
        _bookName.Add("Mosiah");
        _bookName.Add("Mosiah");
        _bookName.Add("Matthew");
        _bookName.Add("Ether");

        string name = _bookName[index];
        return name;
    }

    public int GetRandomChapter(int index)
    {
        _chapterNumber = new List<int>();
        _chapterNumber.Add(3);
        _chapterNumber.Add(16);
        _chapterNumber.Add(16);
        _chapterNumber.Add(11);
        _chapterNumber.Add(12);


        int chapter = _chapterNumber[index];
        return chapter;
    }

    public int GetRandomVerse(int index)
    {
        _verseNumber = new List<int>();
        _verseNumber.Add(16);
        _verseNumber.Add(8);
        _verseNumber.Add(15);
        _verseNumber.Add(28);
        _verseNumber.Add(37);

        int verse = _verseNumber[index];
        return verse;
    }

    public int GetRandomEndVerse(int index)
    {
        _endVerseNumber = new List<int>();
        _endVerseNumber.Add(-1);
        _endVerseNumber.Add(9);
        _endVerseNumber.Add(-1);
        _endVerseNumber.Add(30);
        _endVerseNumber.Add(-1);

        int endVerse = _endVerseNumber[index];
        return endVerse;
    }

    public string GetRandomScripture(int index)
    {
        _scripture = new List<string>();
        _scripture.Add("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        _scripture.Add("But there is a resurrection, therefore the grave hath no victory, and the sting of death is swallowed up in Christ. He is the light and the life of the world; yea, a light that is endless, that can never be darkened; yea, and also a life which is endless, that there can be no more death.");
        _scripture.Add("Teach them that redemption cometh through Christ the Lord, who is the very Eternal Father. Amen.");
        _scripture.Add("Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.");
        _scripture.Add("And it came to pass that the Lord said unto me: If they have not charity it mattereth not unto thee, thou hast been faithful; wherefore, thy garments shall be made clean. And because thou hast seen thy weakness thou shalt be made strong, even unto the sitting down in the place which I have prepared in the mansions of my Father.");

        string scripture = _scripture[index];
        return scripture;
    }
}