namespace BaseConv
{
    using Interfaces;

    public class CharacterClassifier : ICharacterClassifier
    {
        public bool inHighAlpha(char input)
        {
            return 'A' <= input && input <= 'Z';
        }

        public bool inLowAlpha(char input)
        {
            return 'a' <= input && input <= 'z';
        }

        public bool inNumer(char input)
        {
            return '0' <= input && input <= '9';
        }

        public bool InUpperAlphaOrNumeric(char input)
        {
            return inHighAlpha(input) || inNumer(input);
        }
    }
}
