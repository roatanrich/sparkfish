using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using WebApplication1.Common;

namespace WebApplication1.Testing
{
    [TestFixture]
    public class SparkfishListTester
    {
        [Test]
        public void Run()
        {
            // Given a list of numbers ranging from 100 to 200
            int expectedFirstResult = 150;
            int expectedSecondResult = 115;
            int expectedThirdResult = 173;
            int expectedFailure = 699;

            IList<int> list = new SparkfishList(100, 200);

            // When I access index position 50
            int firstResult = list[50];
            int secondResult = list[15];
            int thirdResult = list[73];
            int faailureResult = list[699];

            // Then I should get back the expected results
            firstResult.Should().Be(expectedFirstResult);
            secondResult.Should().Be(expectedSecondResult);
            thirdResult.Should().Be(expectedThirdResult);
            faailureResult.Should().Be(expectedFailure);
        }
    }
}