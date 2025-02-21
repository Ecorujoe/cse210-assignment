class Word {
    // Attributes
    private string _word;
    private bool _hidden;

    //Constructor
    public Word()
    {
        
    }
    public Word(string word)
    {
        this._word = word;
        this._hidden = false;
    }

    public Word(string word, bool hidden)
    {
        this._word = word;
        this._hidden = hidden;
    }

    //Getter and Setter
    public void SetWord(string word)
    {
        this._word = word;
    }

    public string GetWord()
    {
        return _word;
    }
    
    public bool IsHidden()
    {
        return _hidden;
    }

    //Method
    public void HideWord()
    {
        this._hidden = true;
    }
    
    public void ShowWord()
    {
        this._hidden = false;
    }

}