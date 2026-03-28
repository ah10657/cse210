using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Scripture
{
    public Word _word;
    private Reference _reference;
    public string PickWords()
    {
        _word.HideWord();
    }
    public string Display()
    {
        return _word.GetWord();
    }
}