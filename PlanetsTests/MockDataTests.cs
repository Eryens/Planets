using Planets.DAL;
using Planets.Models.Classes;

namespace PlanetsTests
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetSolarSystem_ReturnsNotNull()
        {
            // Arrange
            SolarSystem solarSystem = MockData.GetSolarSystem();
            
            // Act

            // Assert
            Assert.IsNotNull(solarSystem);
        }
    }
}