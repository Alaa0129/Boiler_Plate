using System;
using Xunit;
using System.IO;

namespace BoilerPlate.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1600, true)]
        [InlineData(1700, false)]
        [InlineData(2000, true)]
        [InlineData(1800, false)]
        
        public void Get_true_if_leap_year(int year, bool exp)
        {
            // arrange
            var bb = new BoilerPlateClass();
            
            // Act
            var actual = bb.IsLeapYear(year);

            // Assert
            Assert.Equal(exp, actual);
        }
    }
}
