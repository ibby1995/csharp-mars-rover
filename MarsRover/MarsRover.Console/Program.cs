using MarsRover.Console.UI;

namespace MarsRover.Console
{
    internal class Program
    {
        enum AppState
        {
            Welcome,
            PromptForPlateau,
            PromptForLanding,
            PromptForInstructions,
            DisplayPlateau
        }

        static void Main(string[] args)
        {
            ConsoleUI ui = new ConsoleUI();
            InputParser parser = new InputParser();

            AppState currentState = AppState.Welcome;
            PlateauSize plateauSize = null;
            Plateau plateau = null;
            Position landingPosition = null;

            try
            {
                while (true)
                {
                    switch (currentState)
                    {
                        case AppState.Welcome:
                            ui.DisplayWelcome();
                            currentState = AppState.PromptForPlateau;
                            break;

                        case AppState.PromptForPlateau:
                            string plateauInput = ui.PromptForPlateauSize();
                            plateauSize = parser.ParsePlateauSize(plateauInput);
                            if (plateauSize == null)
                            {
                                System.Console.WriteLine("Invalid plateau size, please try again.");
                            }
                            else
                            {
                                plateau = new Plateau(plateauSize);
                                currentState = AppState.PromptForLanding;
                            }
                            break;

                        case AppState.PromptForLanding:
                            string landingInput = ui.PromptForRoverLandingPosition();
                            landingPosition = parser.ParsePosition(landingInput);
                            if (landingPosition == null)
                            {
                                System.Console.WriteLine("Invalid landing position, please try again.");
                            }
                            else
                            {
                                plateau.AddRover(landingPosition);
                                currentState = AppState.PromptForInstructions;
                            }
                            break;

                        case AppState.PromptForInstructions:
                            string instructionsInput = ui.PromptForRoverInstructions();
                            List<Instruction> instructions = parser.ParseInstructions(instructionsInput);
                            plateau.MoveRover(plateau.Rovers.Count - 1, instructions);
                            currentState = AppState.DisplayPlateau;
                            break;

                        case AppState.DisplayPlateau:
                            ui.DisplayPlateau(plateau);
                            currentState = AppState.PromptForLanding;
                            break;

                        default:
                            throw new InvalidOperationException("Unknown application state");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                System.Console.WriteLine("Restarting the application...");
                Main(args);
            }
        }
    }
}