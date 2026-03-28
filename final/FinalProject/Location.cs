namespace StoryBuilder
{
    public class Location
    {
        public string Name { get; set; }

        public Location(string name)
        {
            Name = name;
        }

        public string DescribeLocation()
        {
            return $"Location: {Name}";
        }
    }
}