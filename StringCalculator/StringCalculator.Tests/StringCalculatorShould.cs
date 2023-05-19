using FluentAssertions;
using StringCalculatorKata;

namespace StringCalculatorTests
{
    public class StringCalculatorShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReturnZeroWhenStringIsEmpty()
        {
            var result = StringCalculator.Add("");

            result.Should().Be(0);
        }
    }
}