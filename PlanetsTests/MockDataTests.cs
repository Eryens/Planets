using Planets.DAL;
using Planets.Models.AbstractClasses;
using Planets.Models.Classes;
using System.Numerics;

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

            // Assert
            Assert.That(solarSystem, Is.Not.Null);
        }

        [Test]
        public void GetSolarSystemPlanets_ReturnsNotNull()
        {
            // Arrange
            List<InterstarPlanet> planets = MockData.GetSolarSystemPlanets();

            // Assert
            Assert.That(planets, Is.Not.Null);
        }

        [Test]
        public void GetSolarSystemPlanets_ContainsElements()
        {
            // Arrange
            List<InterstarPlanet> planets = MockData.GetSolarSystemPlanets();

            // Assert
            Assert.That(planets, Is.Not.Empty);
        }

        [Test]
        public void GetSolarSystemPlanets_ContainsCorrectNumberOfElements()
        {
            // Arrange
            List<InterstarPlanet> planets = MockData.GetSolarSystemPlanets();

            // Assert
            Assert.That(planets.Count, Is.EqualTo(8));
        }
    }
}