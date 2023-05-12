using Planets.Models.AbstractClasses;

namespace Planets.Models.Classes
{
    public class RockyPlanet : InterstarPlanet
    {
        public List<string> RockTypes { get; set; } = new List<string>();
    }
}
