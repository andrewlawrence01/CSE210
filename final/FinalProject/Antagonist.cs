namespace StoryBuilder
{
    public class Antagonist : Character
    {
        public Antagonist(string name) : base(name) { }

        public override string Describe()
        {
            return $"Antagonist: {Name}";
        }

        public override string PerformAction()
        {
            return $"{Name} causes conflict!";
        }
    }
}