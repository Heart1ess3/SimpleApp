using Xunit;
using SimpleApp;

namespace SimpleApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            var calc = new Calculator();
            var result = calc.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}