class Reference {
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse = "";


    public Reference()
    {
        
    }
    public Reference(string book, string chapter, string verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
    }

    public Reference(string book, string chapter, string verse, string endVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._endVerse = endVerse;
    }

    public string GetReference() 
    {
        string reference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        return reference;
    }

    public void setMultipleVerse(string book, string chapter, string verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
    }

    public void setSingleVerse(string book, string chapter, string verse, string endVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._endVerse = endVerse;
    }
}