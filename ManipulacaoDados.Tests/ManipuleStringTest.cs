using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace ManipulacaoDados.Tests
{
    public class ManipuleStringTest
    {
        [Fact]
        public void deleteVowels() {
            // Arrange
            var m = new ManipuleString();
            string input = "cool vibes FOR YOU";
            string expected = "cl vbs FR Y";

            // Act
            string result = m.deleteVowels(input);
            
            // Assert
            Assert.True(expected.Equals(result));
        }
        [Fact]
        public void quantityLetter()
        {
            // Arrange
            var m = new ManipuleString();
            string input = "cool vibes";
            char find = 'o';
            int expected = 2;

            // Act
            var result = m.quantityLetter(input,find);
            
            // Assert
            Assert.True(result == expected);
        }
        [Fact]
        public void invertString() 
        {
            // arrange
            var m = new ManipuleString();
            string input = "cool vibes";
            string expected = "sebiv looc";

            // Act
            string? result = m.invertString(input);

            // Assert
            Assert.True(expected.Equals(result));
        }

        [Fact]
        public void deleteLetter() { 
            // arrange
            var m = new ManipuleString();
            string input = "cool vibes";
            char letter = 'o';
            string expected = "cl vibes";

            // act
            string result = m.deleteLetter(input, letter);
            
            // Assert
            Assert.True(expected.Equals(result));
        }
        
        [Fact]
        public void deleteAfterLetter() 
        {
            // arrange
            var m = new ManipuleString();
            string input = "cool vibes";
            char letter = 'v';
            string expected = "cool ";

            // act
            string result = m.deleteAfterLetter(input, letter);
            
            // Assert
            Assert.True(expected.Equals(result));
        }
        [Fact]
        public void deleteBeforeLetter() 
        {
            // arrange
            var m = new ManipuleString();
            string input = "cool vibes";
            char letter = 'v';
            string expected = "vibes";

            // act
            string result = m.deleteBeforeLetter(input, letter);
            
            // Assert
            Assert.True(expected.Equals(result));
        }
        [Fact]
        public void toUpperSomeLetters()
        {
            // arrange
            var m = new ManipuleString();
            string input = "cool vibes";
            string letters = "LCVBS";
            string expected = "CooL ViBeS";

            // act
            string result = m.toUpperSomeLetters(input, letters);
            
            // Assert
            Assert.True(expected.Equals(result));
        }

        public void deleteEveryOtherLetter() {
            // arrange
            var m = new ManipuleString();
            string input = "cool vibes";
            
            string expected = "co ie";

            // act
            string result = m.deleteEveryOtherLetter(input);
            
            // Assert
            Assert.True(expected.Equals(result));
        }
        [Fact]
        public void findUniqueLetters() {
            // arrange
            var m = new ManipuleString();
            string input = "cool vibes for you";
            Dictionary<char,int> expected = new Dictionary<char, int>{
                {'c', 1},
                {'o', 4},
                {'l', 1},
                {' ', 3},
                {'v', 1},
                {'i', 1},
                {'b', 1},
                {'e', 1},
                {'s', 1},
                {'f', 1},
                {'r', 1},
                {'y', 1},
                {'u', 1}
            };

            // act
            Dictionary<char,int> result = m.findUniqueLetters(input);
            // Assert
            
            Assert.True(expected.Count == result.Count && !expected.Except(result).Any());
        }
        [Fact]
        public void overrideLetter()
        {
            // arrange
            var m = new ManipuleString();
            string input = "caal vibes far yau";
            char letterBase = 'a';
            char overrideTo = 'o';
            string expected = "cool vibes for you";

            // act
            string result = m.overrideLetter(input, letterBase, overrideTo);
            
            // Assert
            Assert.True(expected.Equals(result));
        }
    }
}