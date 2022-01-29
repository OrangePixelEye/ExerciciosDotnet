using Xunit;
using ManipulacaoDados;

namespace ManipulacaoDados.Tests
{

    public class IntManipulation
    {
        [Fact]
        public void SquarePairs()
        {
            var service = new ManipuleInt();
            int[] result = service.squareAllPairs(1,4);
            Assert.Matches(string.Join(' ', result), "4 16");
        }
    }
}
