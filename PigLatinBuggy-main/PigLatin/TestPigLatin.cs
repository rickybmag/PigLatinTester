using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PigLatin
{
    public class TestPigLatin
    {
        [Fact]
        public void TestIsVowel()
        {
            //Arrange
            PigLatin p = new PigLatin();
            char[] expected = { 'a', 'e', 'i', 'o', 'u' };
            
            //Act
            bool actual = p.IsVowel('a');

            //Assert
            Assert.True(actual);

            //Testing before adding Foreach loop indicated that every char was not a vowel.
        }

        [Fact]
        public void TestToPigLatin()
        {
            PigLatin p = new PigLatin();
            string expected = "appleway";

            string actual = p.ToPigLatin("apple");

            Assert.Equal(expected, actual);

            //Testing before fixing method only printed "appleay"

        }

        [Theory]
        [InlineData("apple", "appleway")]
        [InlineData("heck", "eckhay")]
        [InlineData("strong", "ongstray")]
        [InlineData("tommy@email.com", "tommy@email.com")]
        [InlineData("aardvark", "aardvarkway")]
        [InlineData("Tommy", "ommytay")]
        [InlineData("gym", "gym")]
        [InlineData("apple joy gym tommy@email.com strong", "appleway oyjay gym tommy@email.com ongstray")]
        public void TestEverything(string input, string expected)
        {
            PigLatin p = new PigLatin();
            string actual = p.ToPigLatin(input);
            Assert.Equal(expected, actual);
        }
    }
}
