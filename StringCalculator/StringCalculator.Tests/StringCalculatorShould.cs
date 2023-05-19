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

        [Theory]
        [TestCase("1,2", 3)]
        [TestCase("1", 1)]
        public void ReturnSumOfInputNumbers(string numbers, int expectedSum)
        {
            var result = StringCalculator.Add(numbers);

            result.Should().Be(expectedSum);
        }
    }
}