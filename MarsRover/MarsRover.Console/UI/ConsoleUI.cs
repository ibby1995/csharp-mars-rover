namespace MarsRover.Console.UI
{
    public class ConsoleUI
    {
        public void DisplayWelcome()
        {
            System.Console.WriteLine("Welcome to Mars Rover!");
            System.Console.WriteLine("----------------------");
        }

        public string PromptForPlateauSize()
        {
            System.Console.WriteLine("Enter the plateau size (e.g. 5 5):");
            return System.Console.ReadLine();
        }

        public string PromptForRoverLandingPosition()
        {
            System.Console.WriteLine("Enter the rover landing position (e.g. 1 2 N):");
            return System.Console.ReadLine();
        }

        public string PromptForRoverInstructions()
        {
            System.Console.WriteLine("Enter the rover instructions (e.g. LMLMLMLMM):");
            return System.Console.ReadLine();
        }

        public void DisplayPlateau(Plateau plateau)
        {
            System.Console.WriteLine("\n-- Final Rover Positions --");
            foreach (Rover rover in plateau.Rovers)
            {
                System.Console.WriteLine($"{rover.Position.X} {rover.Position.Y} {rover.Position.Facing}");
            }
        }
    }
}
