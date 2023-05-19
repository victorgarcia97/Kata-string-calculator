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
        [TestCase("2,2", 4)]
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("1,2,3", 6)]
        [TestCase("1,2,3,4", 10)]
        [TestCase("1\n2,3,4", 10)]
        [TestCase("2\n2,2\n2", 8)]
        public void ReturnSumOfInputNumbers(string numbers, int expectedSum)
        {
            var result = StringCalculator.Add(numbers);

            result.Should().Be(expectedSum);
        }
    }
}