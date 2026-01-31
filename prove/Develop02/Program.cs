using System;
using System.Collections.Generic;

namespace WebAppProjectProposal
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectProposal proposal = ProjectData.BuildProposal();
            proposal.Display();
        }
    }

    // =========================
    // Core Proposal Classes
    // =========================

    class ProjectProposal
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string TargetAudience { get; set; }
        public List<string> Features { get; set; }
        public List<Wireframe> Wireframes { get; set; }
        public Requirements Requirements { get; set; }

        public void Display()
        {
            Console.WriteLine($"Project Name: {ProjectName}\n");
            Console.WriteLine("Description:");
            Console.WriteLine(Description + "\n");

            Console.WriteLine("Target Audience:");
            Console.WriteLine(TargetAudience + "\n");

            Console.WriteLine("Features:");
            Features.ForEach(f => Console.WriteLine($"- {f}"));

            Console.WriteLine("\nWireframes:");
            Wireframes.ForEach(w => w.Display());

            Console.WriteLine("\nRequirements Coverage:");
            Requirements.Display();
        }
    }

    class Wireframe
    {
        public string ViewType { get; set; }
        public string Description { get; set; }

        public void Display()
        {
            Console.WriteLine($"\n{ViewType} View:");
            Console.WriteLine(Description);
        }
    }

    class Requirements
    {
        public string DetailedForm { get; set; }
        public string LocalStorage { get; set; }
        public string DataSource { get; set; }
        public string DropdownUsage { get; set; }
        public string CssAnimations { get; set; }
        public string ResponsiveDesign { get; set; }
        public string Accessibility { get; set; }
        public string UrlParameters { get; set; }
        public string Modules { get; set; }

        public void Display()
        {
            Console.WriteLine($"Detailed Form: {DetailedForm}");
            Console.WriteLine($"Local Storage: {LocalStorage}");
            Console.WriteLine($"Data Source: {DataSource}");
            Console.WriteLine($"Drop-downs / Modals: {DropdownUsage}");
            Console.WriteLine($"CSS Animations: {CssAnimations}");
            Console.WriteLine($"Responsive Design: {ResponsiveDesign}");
            Console.WriteLine($"Accessibility: {Accessibility}");
            Console.WriteLine($"URL Parameters: {UrlParameters}");
            Console.WriteLine($"Modules: {Modules}");
        }
    }

    // =========================
    // Data Builder
    // =========================

    static class ProjectData
    {
        public static ProjectProposal BuildProposal()
        {
            return new ProjectProposal
            {
                ProjectName = "HabitForge",
                Description = "HabitForge is a responsive web application designed to help users create, track, and maintain daily habits. " +
                              "The app focuses on clean UI, strong UX, persistence through local storage, and modular JavaScript architecture.",
                TargetAudience = "Students, young professionals, and individuals interested in productivity and self-improvement.",
                Features = new List<string>
                {
                    "Create and manage daily habits",
                    "Track habit completion",
                    "View progress summaries",
                    "Persistent data using local storage",
                    "Motivational feedback and animations"
                },
                Wireframes = new List<Wireframe>
                {
                    new Wireframe
                    {
                        ViewType = "Mobile",
                        Description = "Header with app title, vertical habit cards, floating add button, bottom navigation."
                    },
                    new Wireframe
                    {
                        ViewType = "Wide Screen",
                        Description = "Sidebar navigation, dashboard layout with habit cards, progress panel."
                    }
                },
                Requirements = new Requirements
                {
                    DetailedForm = "Used to add and edit habits with validation for required fields.",
                    LocalStorage = "Stores user habits, completion history, and preferences.",
                    DataSource = "Motivational quotes loaded from a local JSON file.",
                    DropdownUsage = "Habit frequency and priority selection.",
                    CssAnimations = "Progress bar animation and button hover effects.",
                    ResponsiveDesign = "Mobile-first layout using Flexbox, Grid, and media queries.",
                    Accessibility = "Semantic HTML, keyboard navigation, and ARIA labels.",
                    UrlParameters = "habit-details.html?id=3 used to load habit details.",
                    Modules = "Separate modules for storage, UI rendering, data handling, and forms."
                }
            };
        }
    }
}