namespace StoryBuilder
{
    public class Protagonist : Character
    {
        public Protagonist(string name) : base(name) { }

        public override string Describe()
        {
            return $"Protagonist: {Name}";
        }

        public override string PerformAction()
        {
            return $"{Name} fights for good!";
        }
    }
}