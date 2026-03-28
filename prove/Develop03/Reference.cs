using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    public string GetReference()
    {
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}