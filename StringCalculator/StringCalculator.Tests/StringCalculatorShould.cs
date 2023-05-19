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

        [Test]
        public void ReturnSumOfInputNumbers()
        {
            var result = StringCalculator.Add("1,2");

            result.Should().Be(3);
        }
    }
}