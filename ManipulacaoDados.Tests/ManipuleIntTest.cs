using Xunit;
using ManipulacaoDados;
using System.Linq;

namespace ManipulacaoDados.Tests
{

    public class IntManipulation
    {
        [Fact]
        public void arrBetweenTwoN() {
            // arrange
            var m = new ManipuleInt();
            int n1 = 1;
            int n2 = 4;
            int[] expected = new int[]{1, 2, 3, 4};

            // act
            int[] result = m.arrBetweenTwoN(n1, n2);
            // Assert
            Assert.True(expected.SequenceEqual(result));
        }
        [Fact]
        public void invertArray()
        {
            // arrange
            var m = new ManipuleInt();
            int[] input = new int[]{3, 2, 1};
            int[] expected = new int[]{1, 2, 3};

            // act
            int[] result = m.invertArray(input);
            // Assert
            Assert.True(expected.SequenceEqual(result));
        }
        [Fact]
        public void findPairs() 
        {
            // arrange
            var m = new ManipuleInt();
            int[] input = new int[]{ 2, 1, 4, 6, 8, 9, 12, 13};
            int[] expected = new int[]{2, 4, 6, 8, 12};

            // act
            int[] result = m.findPairs(input);
            // Assert
            Assert.True(expected.SequenceEqual(result));        }
        
        [Fact]
        public void uniiqueGreaterThan()
        {
            // arrange
            var m = new ManipuleInt();
            int n = 6;
            int[] input = new int[]{ 2, 2, 7, 6, 8, 8, 12, 13};
            int[] expected = new int[]{7, 8, 12, 13};

            // act
            int[] result = m.uniqueGreaterThan(input, n);
            // Assert
            Assert.True(expected.SequenceEqual(result));
        }
        
        [Fact]
        public void organize()
        {
            // arrange
            var m = new ManipuleInt();
            int[] input = new int[]{4,2, 5, 1};
            int[] expected = new int[]{1, 2, 4, 5};

            // act
            int[] result = m.organize(input);

            // Assert
            Assert.True(expected.SequenceEqual(result));
        }

        [Fact]
        public void findMultiples() 
        {
            // arrange
            var m = new ManipuleInt();
            int n = 2;
            int[] input_arr = new int[]{1, 2, 3, 4, 5, 6};
            int[] expected = new int[]{2, 4, 6};

            // act
            int[] result = m.findMultiples(input_arr, n);
            
            // Assert
            Assert.True(expected.SequenceEqual(result));
        }

        [Fact]
        public void SquarePairs()
        {
            // arrange
            var m = new ManipuleInt();
            int n1 = 1;
            int n2 = 4;
            int[] expected = new int[]{4, 16};

            // act
            int[] result = m.squareAllPairs(n1, n2);
            
            // Assert
            Assert.True(expected.SequenceEqual(result));
        }
    }
}
