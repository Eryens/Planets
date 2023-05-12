using Planets.Models.AbstractClasses;

namespace Planets.Models.Classes
{
    public class GasGiant : InterstarPlanet
    {
        public List<string> Gas { get; set; } = new List<string>();
    }
}
