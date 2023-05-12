using Planets.Models.AbstractClasses;
using Planets.Models.Classes;

namespace Planets.DAL
{
    internal static class MockData
    {
        internal static List<InterstarPlanet> GetSolarSystemPlanets()
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
                    DistanceFromSun = new Tuple<long, long>(46000000, 70000000),
                },
                new RockyPlanet
                {
                    Name = "Venus",
                    Description = "Venus, the second planet from the Sun, is a blistering hot world cloaked in thick clouds, where crushing atmospheric pressure and a runaway greenhouse effect create a hellish environment worthy of its status as Earth's \"evil twin.\"",
                    Diameter = 12100,
                    Mass = 0.857f,
                    RockTypes = new List<string>() { "Metal", "Dense rocks"},
                    Picture = "https://upload.wikimedia.org/wikipedia/commons/b/b2/Venus_2_Approach_Image.jpg",
                    DistanceFromSun = new Tuple<long, long>(66800000, 108000000), 
                },
                new RockyPlanet
                {
                    Name = "Earth",
                    Description = "Planet Earth, our beautiful blue oasis in the vastness of space, teems with diverse life, breathtaking landscapes, and the perfect conditions for humanity to thrive.",
                    Diameter = 12742,
                    Mass = 1,
                    RockTypes = new List<string>() { "Aluminium", "Silicon", "Iron", "Calcium", "Sodium" },
                    Picture = "https://upload.wikimedia.org/wikipedia/commons/c/cb/The_Blue_Marble_%28remastered%29.jpg",
                    DistanceFromSun = new Tuple<long, long>(147000000, 152000000),
                },
                new RockyPlanet
                {
                    Name = "Mars",
                    Description = "Mars, the \"Red Planet,\" beckons us with its rusty allure, harboring ancient mysteries and captivating our imagination as a potential future home for humanity.",
                    Diameter = 6779,
                    Mass = 0.0107f,
                    DistanceFromSun = new Tuple<long, long>(207000000, 259000000),
                    RockTypes = new List<string>() { "Olivine", "Pyroxene", "Feldspar", "Magnetite"},
                    Picture = "https://upload.wikimedia.org/wikipedia/commons/0/0c/Mars_-_August_30_2021_-_Flickr_-_Kevin_M._Gill.png",
                },
                new GasGiant
                {
                    Name = "Jupiter",
                    Description = "Jupiter, the majestic giant of our solar system, enthralls us with its swirling storms, mesmerizing bands of clouds, and a colossal magnetic field that leaves us in awe of its immense power.",
                    Diameter = 139820,
                    Mass = 317.8f,
                    DistanceFromSun = new Tuple<long, long>(741000000, 817000000),
                    Gas = new List<string>() {"Hydrogen", "Helium"},
                    Picture = "https://upload.wikimedia.org/wikipedia/commons/c/c1/Jupiter_New_Horizons.jpg"
                },
                new GasGiant
                {
                    Name = "Saturn",
                    Description = "Saturn, the ringed beauty of our celestial neighborhood, enchants us with its mesmerizing system of dazzling rings, captivating storms, and a breathtaking array of moons, making it a celestial wonder to behold.",
                    Diameter = 116460,
                    Mass = 95.2f,
                    DistanceFromSun = new Tuple<long, long>(1350000000, 1510000000),
                    Gas = new List<string>() {"Hydrogen", "Helium"},
                    Picture = "https://upload.wikimedia.org/wikipedia/commons/c/c7/Saturn_during_Equinox.jpg",
                },
                new GasGiant
                {
                    Name = "Uranus",
                    Description = "Uranus, the mysterious ice giant, surprises us with its sideways spin, ethereal blue-green hue, and a host of enigmatic moons that beckon us to uncover the secrets of this distant and intriguing world.",
                    Diameter = 51118,
                    Mass = 14.5f,
                    DistanceFromSun = new Tuple<long, long>(2720000000, 3000000000),
                    Gas = new List<string>() {"Hydrogen", "Helium"},
                    Picture = "https://upload.wikimedia.org/wikipedia/commons/c/c9/Uranus_as_seen_by_NASA%27s_Voyager_2_%28remastered%29_-_JPEG_converted.jpg"
                },
                new GasGiant
                {
                    Name = "Neptune",
                    Description = "Neptune, the enigmatic blue jewel of our solar system, captivates us with its violent storms, icy winds, and the allure of a hidden world waiting to be explored.",
                    Diameter = 49528,
                    Mass = 17.1f,
                    DistanceFromSun = new Tuple<long, long>(4460000000, 4550000000),
                    Gas = new List<string>() {"Hydrogen", "Helium"},
                    Picture = "https://upload.wikimedia.org/wikipedia/commons/6/63/Neptune_-_Voyager_2_%2829347980845%29_flatten_crop.jpg",
                }
            };
        }

        internal static SolarSystem GetSolarSystem()
        {
            return new SolarSystem
            {
                Planets = GetSolarSystemPlanets(),
            };
        }
    }
}
