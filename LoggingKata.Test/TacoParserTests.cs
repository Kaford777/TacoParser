using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }


        //calculate the 2 locations that is fartherst apart

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            //Parse method is located inside of the TacoParser class

            var tester = new TacoParser();


            //Act
            var actual = tester.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]

        public void ShouldParseLatitude(string line, double expected)
        {
            var tester = new TacoParser();

            var actual = tester.Parse(line);

            Assert.Equal(expected, actual.Location.Latitude);
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", " Taco Bell Acwort...")]

        public void GetName(string line, string expected)
        { 

        var tester = new TacoParser();

        var actual = tester.Parse(line);

        Assert.Equal(expected, actual.Name);
         }
    }
}
