using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\nEternal Quest Program");
            manager.DisplayScore();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Select Goal Type:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");

                int type = int.Parse(Console.ReadLine());

                Console.Write("Goal Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == 1)
                {
                    manager.AddGoal(new SimpleGoal(name, desc, points));
                }
                else if (type == 2)
                {
                    manager.AddGoal(new EternalGoal(name, desc, points));
                }
                else if (type == 3)
                {
                    Console.Write("Target Count: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus: ");
                    int bonus = int.Parse(Console.ReadLine());

                    manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }

            else if (choice == 2)
            {
                manager.ListGoals();
            }

            else if (choice == 3)
            {
                manager.ListGoals();
                Console.Write("Which goal did you accomplish? ");
                int index = int.Parse(Console.ReadLine()) - 1;

                manager.RecordGoal(index);
            }

            else if (choice == 4)
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();
                manager.SaveGoals(file);
            }

            else if (choice == 5)
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();
                manager.LoadGoals(file);
            }

            else if (choice == 6)
            {
                break;
            }
        }
    }
}