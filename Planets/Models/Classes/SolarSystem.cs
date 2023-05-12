using Planets.Models.AbstractClasses;

namespace Planets.Models.Classes
{
    public class SolarSystem
    {
        public List<InterstarPlanet> Planets { get; set; } = new List<InterstarPlanet>();
    }
}
