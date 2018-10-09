namespace Notes.Infrastructure
{
    public abstract class Token
    {
        public string TokenChars { get; set; }
    }

    public class CharacterToken : Token
    {
    }

    public class FunctionToken : Token
    {
    }
}