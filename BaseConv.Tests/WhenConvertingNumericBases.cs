namespace BaseConv.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class WhenConvertingNumericBases
    {
        private BaseConvClass _bc;

        [SetUp]
        public void Given()
        {
            _bc = new BaseConvClass();
        }
        
        [TestCase("42", 10, 2, ExpectedResult = "101010", TestName = "Decimal-Binary Conversion")]
        [TestCase("101010", 2, 10, ExpectedResult = "42", TestName = "Decimal - Binary Conversion")]
        [TestCase("FF", 16, 10, ExpectedResult = "255", TestName = "Decimal-Hex Conversion")]
        [TestCase("255", 10, 16, ExpectedResult = "FF", TestName = "Hex - Decimal Conversion")]
        public string TheCorrectAnswerIsGiven(string Value, int CurrentBase, int RequiredBase)
        {
            return _bc.BasCalc(Value, Convert.ToUInt32(CurrentBase), Convert.ToUInt32(RequiredBase));
        }
    }
}
