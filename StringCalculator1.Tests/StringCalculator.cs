namespace StringCalculator1.Tests
{
    public class Tests
    {
        [TestCase(null)]
        public void ShouldAdd(string numbers)
        {
            var stringCalculator = new StringCalculator();

            var result = stringCalculator.AddNumbers(numbers);

            Assert.That(result, Is.EqualTo(0));
            //Assert.Pass();
        }

        [TestCase("1")]
        public void ShouldAdd1number(string numbers)
        {
            var stringCalculator = new StringCalculator();

            var result = stringCalculator.AddNumbers(numbers);

            Assert.That(result, Is.EqualTo(1));
        }

        [TestCase("1,2")]
        public void ShouldAdd2numbers(string numbers)
        {
            var stringCalculator = new StringCalculator();

            var result = stringCalculator.AddNumbers(numbers);

            Assert.That(result, Is.EqualTo(3));
        }

        [TestCase("1\n2,3", 6)]
        [TestCase("1,2,3", 6)]
        [TestCase("5,4,3", 12)]
        [TestCase("1,2,3,4,5,6,7,8,9,10", 55)]
        public void ShouldAddMorenumbers(string numbers, int suma)
        {
            var stringCalculator = new StringCalculator();

            var result = stringCalculator.AddNumbers(numbers);

            Assert.That(result, Is.EqualTo(suma));
        }

        [TestCase("1;2")]
        public void ShouldException(string numbers)
        {
            var stringCalculator = new StringCalculator();

            Assert.Throws<ArgumentException> (() => stringCalculator.AddNumbers(numbers));
        }


        [TestCase("//;\n1;2", 3)]
        [TestCase("//k\n-1k2k3k4", 8)]
        [TestCase("//;\n1;2;1001", 3)]
        public void ShouldAddMorenumbersWithDelimeter(string numbers, int suma)
        {
            var stringCalculator = new StringCalculator();

            var result = stringCalculator.AddNumbersFindDelimiter(numbers);

            Assert.That(result, Is.EqualTo(suma));
        }
    }
}