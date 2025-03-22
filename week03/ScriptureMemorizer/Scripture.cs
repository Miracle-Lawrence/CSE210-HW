public class Scripture
{
    //The member variables
    private Reference _reference;
    private List<Word> _words;

    //The constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    //The methods 
    public void HideRandomWord(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count > 0) 
        {
            for (int i = 0; i < numberToHide; i++)
            {
                if (visibleWords.Count == 0)
                    break;

                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
        
            }
        }   
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} - " + string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }

    public bool isCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}