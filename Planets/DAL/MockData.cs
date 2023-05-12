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
                    Description = "Mercury, the closest planet to the Sun, is a tiny world of extremes, with scorching surface temperatures during the day and freezing cold nights, making it a fascinating and mysterious celestial neighbor.",
                    Diameter = 4880,
                    Mass = 0.055f,
                    RockTypes = new List<string>() { "Silicate", "Iron sulfid"},
                    Picture = "https://upload.wikimedia.org/wikipedia/commons/4/4a/Mercury_in_true_color.jpg",
                    DistanceFromSun = new Tuple<int, int>(46000000, 70000000),
                },
                new RockyPlanet
                {
                    Name = "Venus",
                    Description = "Venus, the second planet from the Sun, is a blistering hot world cloaked in thick clouds, where crushing atmospheric pressure and a runaway greenhouse effect create a hellish environment worthy of its status as Earth's \"evil twin.\"",
                    Diameter = 12100,
                    Mass = 0.857f,
                    RockTypes = new List<string>() { "Metal", "Dense rocks"},
                    Picture = "https://en.wikipedia.org/wiki/Venus#/media/File:Venus_2_Approach_Image.jpg",
                    DistanceFromSun = new Tuple<int, int>(66800000, 108000000), 
                },
                new RockyPlanet
                {
                    Name = "Earth",
                    Description = "Planet Earth, our beautiful blue oasis in the vastness of space, teems with diverse life, breathtaking landscapes, and the perfect conditions for humanity to thrive.",
                    Diameter = 12742,
                    Mass = 1,
                    RockTypes = new List<string>() { "Aluminium", "Silicon", "Iron", "Calcium", "Sodium" },
                    DistanceFromSun = new Tuple<int, int>(147000000, 152000000),
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
