namespace Planets.Models.AbstractClasses
{
    // Note - Interstar planet are part of a solar system - as opposite to exostar planets
    public abstract class InterstarPlanet : Planet
    {
        public Tuple<int, int> DistanceFromSun { get; set; } = Tuple.Create(0, 0);
    }
}
