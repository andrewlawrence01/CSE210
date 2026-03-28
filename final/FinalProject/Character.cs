namespace StoryBuilder
{
    public class Character
    {
        public string Name { get; set; }

        public Character(string name)
        {
            Name = name;
        }

        public virtual string Describe()
        {
            return $"Character: {Name}";
        }

        public virtual string PerformAction()
        {
            return $"{Name} takes an action.";
        }
    }
}