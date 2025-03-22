using System.Dynamic;

public class Word
{
    //The member variables
    private string _text;
    private bool _isHidden;

    //The constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //The methods 
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_',_text.Length) : _text;
    }
}