namespace CzechMapGame.Shared
{
    public class Area
    {
        public Area()
        {
        }

        public Area(string name, string svgCoords, string question = null, string answer = null, uint points = 0, string defaultCssColor = null)
        {
            Name = name;
            SvgCoords = svgCoords;
            DefaultCssColor = defaultCssColor;
            Question = question;
            Answer = answer;
            Points = points;
        }

        public string Name { get; set; }

        public AreaType Type { get; set; } = AreaType.Region;

        public string Question { get; }

        public string Answer { get; }

        public uint Points{ get; set; }

        public bool? Solved { get; set; }

        public string DefaultCssColor { get; }

        public string SvgCoords { get; }
    }
}
