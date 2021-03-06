﻿namespace BaseConv.Tests
{
    using NUnit.Framework;
    using Interfaces;

    [TestFixture]
    public class WhenClassifyingCharacters
    {
        ICharacterClassifier _sut;

        [SetUp]
        public void Given()
        {
            _sut = new CharacterClassifier();
        }

        [TestCase(null, ExpectedResult = false, TestName = "A null character is not a upper case letter.")]
        [TestCase('a', ExpectedResult = false, TestName = "A lower case character is not an upper case letter.")]
        [TestCase('A', ExpectedResult = true, TestName = "An upper case character is an upper case letter.")]
        [TestCase('1', ExpectedResult = false, TestName = "A digit character is not an upper case letter.")]
        [TestCase('?', ExpectedResult = false, TestName = "A punctuation character is not an upper case letter.")]
        public bool IsUpperCaseAlpha(char value)
        {
            return _sut.inHighAlpha(value);
        }

        [TestCase(null, ExpectedResult = false, TestName = "A null character is not a lower case letter.")]
        [TestCase('a', ExpectedResult = true, TestName = "A lower case character is a lower case letter.")]
        [TestCase('A', ExpectedResult = false, TestName = "An upper case character is not a lower case letter.")]
        [TestCase('1', ExpectedResult = false, TestName = "A digit character is not a lower case letter.")]
        [TestCase('?', ExpectedResult = false, TestName = "A punctuation character is a lower case letter.")]
        public bool IsLowerCaseAlpha(char value)
        {
            return _sut.inLowAlpha(value);
        }

        [TestCase(null, ExpectedResult = false, TestName = "A null character is not a number.")]
        [TestCase('a', ExpectedResult = false, TestName = "A lower case character is not a number.")]
        [TestCase('A', ExpectedResult = false, TestName = "An upper case character is not numeric.")]
        [TestCase('1', ExpectedResult = true, TestName = "A digit character is numeric.")]
        [TestCase('?', ExpectedResult = false, TestName = "A punctuation character not is numeric.")]
        public bool IsNumeric(char value)
        {
            return _sut.inNumer(value);
        }

        [TestCase(null, ExpectedResult = false, TestName = "A null character is not upper alphanumeric.")]
        [TestCase('a', ExpectedResult = false, TestName = "A lower case character is not upper alphanumeric.")]
        [TestCase('A', ExpectedResult = true, TestName = "An upper case character is upper alphanumeric.")]
        [TestCase('1', ExpectedResult = true, TestName = "A digit character is upper alphanumeric.")]
        [TestCase('?', ExpectedResult = false, TestName = "A punctuation character is not upper alphanumeric.")]
        public bool IsUpperAlphanumeric(char value)
        {
            return _sut.InUpperAlphaOrNumeric(value);
        }

        [TestCase('a', ExpectedResult = 'A', TestName = "A lower case character is converted to upper case.")]
        [TestCase('A', ExpectedResult = 'A', TestName = "An upper case character is not affected by upper casing.")]
        [TestCase('1', ExpectedResult = '1', TestName = "A digit character is not affected by upper casing.")]
        [TestCase('?', ExpectedResult = '?', TestName = "A punctuation character is not affected by upper casing.")]
        public char MakeUpperCase(char value)
        {
            return _sut.Caps_On(value);
        }
    }
}
