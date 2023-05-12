using Planets.Models.AbstractClasses;
using Planets.Models.Classes;

namespace Planets.DAL
{
    public static class MockData
    {
        private static List<InterstarPlanet> GetSolarSystemPlanets()
        {
            return new List<InterstarPlanet>()
            {
                new RockyPlanet
                {
                    Name = "Mercury",
                    Diameter = 4880,
                    Mass = 0.055f,
                    RockTypes = new List<string>() { "Silicate", "Iron sulfid"},
                    Picture = "https://upload.wikimedia.org/wikipedia/commons/4/4a/Mercury_in_true_color.jpg",
                    DistanceFromSun = new Tuple<int, int>(46000000, 70000000),
                },
                new RockyPlanet
                {
                    Name = "Venus",
                    Diameter = 12100,
                    Mass = 0.857f,
                    RockTypes = new List<string>() { "Metal", "Dense rocks"},
                    Picture = "https://en.wikipedia.org/wiki/Venus#/media/File:Venus_2_Approach_Image.jpg",
                    DistanceFromSun = new Tuple<int, int>(108000000, 108000000), 
                },
                new RockyPlanet
                {
                    Name = "Earth",
                    Diameter = 12742,
                    Mass = 1,
                    RockTypes = new List<string>() { "Aluminium", "Silicon", "Iron", "Calcium", "Sodium" },
                    DistanceFromSun = new Tuple<int, int>(108000000, 108000000),
                }
            };
        }

        public static SolarSystem GetSolarSystem()
        {
            return new SolarSystem
            {
                Planets = GetSolarSystemPlanets(),
            };
        }
    }
}
