namespace StoryBuilder
{
    public class SupportingCharacter : Character
    {
        public SupportingCharacter(string name) : base(name) { }

        public override string Describe()
        {
            return $"Supporting Character: {Name}";
        }

        public override string PerformAction()
        {
            return $"{Name} helps the protagonist.";
        }
    }
}