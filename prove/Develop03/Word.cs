using System;
using System.Runtime.CompilerServices;

class Word
{
    private string _word;
    private bool _hidden;
    public string GetWord()
    {
        if (_hidden)
        {
            return "____";
        }
        else
        {
            return _word;
        }
    }
    public string HideWord()
    {
        _hidden = true;
        return GetWord();
    }
}