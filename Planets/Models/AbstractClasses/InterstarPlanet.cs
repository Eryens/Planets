namespace Planets.Models.AbstractClasses
{
    // Note - Interstar planet are part of a solar system - as opposite to exostar planets
    public abstract class InterstarPlanet : Planet
    {
        public Tuple<long, long> DistanceFromSun { get; set; } = Tuple.Create((long)0, (long)0);
    }
}
