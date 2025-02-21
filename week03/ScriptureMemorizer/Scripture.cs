class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> _word = new List<Word> {};
    private int hiddenWords = 0;

    public Scripture()
    {

    }
   public Scripture(Reference reference, List<string> words)
   {
    this._reference = reference;
    // Converte WordList into a Object Word 
    foreach(string word in words)
    {
        Word aWord = new Word();
        aWord.SetWord(word);
        _word.Add(aWord);
    }
   }

   public Scripture(Reference reference, List<Word> words)
   {
        this._reference = reference;
        this._word = words;
   }

   public string getScripture()
   {
        string reference = _reference.GetReference();
        string words = "";

        foreach(Word aWord in _word)
        {
            string word = aWord.GetWord();
            if (aWord.IsHidden())
            {
                string underline = "";
                foreach(char letter in word)
                {
                    underline += "_";
                }
                words += $" {underline}";
            } 
            else
            {
                words += $" {word}";
            }

        }


        string scripture = $"{reference} {words}";
        return scripture;
   }

   public void SetScripture(Reference reference, string words) 
   {
        this._reference = reference;
        List<string> scriptureList = words.Split(' ').ToList();
        // Converte WordList into a Object Word 
        foreach(string word in scriptureList)
        {
            Word aWord = new Word(word);
            _word.Add(aWord);
        }
   }

    //Methods
    public void HideRandomWord()
    {
        int listLenght = _word.Count;
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, listLenght);
        
        if (!_word[randomNumber].IsHidden())
        {
            _word[randomNumber].HideWord();
            hiddenWords += 1;
            Console.WriteLine(hiddenWords);
        }
        else
        {  
            if (hiddenWords == _word.Count)
            {
                Console.Clear();
                Console.WriteLine(getScripture());
                Environment.Exit(0);
            }
            else
            {
                HideRandomWord();
            }
        }

    }
}
    