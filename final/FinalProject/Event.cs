namespace StoryBuilder
{
    public class Event
    {
        public string Description { get; set; }

        public Event(string description)
        {
            Description = description;
        }

        public string DescribeEvent()
        {
            return Description;
        }
    }
}