namespace Planets.Models.AbstractClasses
{
    public abstract class Planet
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Diameter { get; set; }
        public float Mass { get; set; }
        public string? Picture { get; set; }
    }
}
