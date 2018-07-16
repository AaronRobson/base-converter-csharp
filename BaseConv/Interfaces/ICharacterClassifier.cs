namespace BaseConv.Interfaces
{
    public interface ICharacterClassifier
    {
        bool inHighAlpha(char input);

        bool inLowAlpha(char input);

        bool inNumer(char input);

        bool InUpperAlphaOrNumeric(char input);
    }
}
