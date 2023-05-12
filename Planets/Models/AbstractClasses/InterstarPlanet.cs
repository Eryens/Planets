namespace Planets.Models.AbstractClasses
{
    public abstract class InterstarPlanet : Planet
    {
        public Tuple<int, int> DistanceFromSun { get; set; } = Tuple.Create(0, 0);
    }
}
