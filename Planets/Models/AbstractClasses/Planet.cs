namespace Planets.Models.AbstractClasses
{
    public abstract class Planet
    {
        public string Name { get; set; } = "";
        public int Diameter { get; set; }
        public float Mass { get; set; }
        public string? Picture { get; set; }
    }
}
