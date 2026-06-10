namespace MarsRover.Console
{
    public class InputParser
    {
        public PlateauSize ParsePlateauSize(string input)
        {
            try
            {
                string[] parts = input.Split(' ');
                if (parts.Length != 2) return null;
                int width = int.Parse(parts[0]);
                int height = int.Parse(parts[1]);
                return new PlateauSize(width, height);
            }
            catch
            {
                return null;
            }
        }

        public Position ParsePosition(string input)
        {
            try
            {
                string[] parts = input.Split(' ');
                if (parts.Length != 3) return null;
                int x = int.Parse(parts[0]);
                int y = int.Parse(parts[1]);
                string direction = parts[2];
                CompassDirection facing;
                if (direction == "N") facing = CompassDirection.N;
                else if (direction == "S") facing = CompassDirection.S;
                else if (direction == "E") facing = CompassDirection.E;
                else if (direction == "W") facing = CompassDirection.W;
                else return null;
                return new Position(x, y, facing);
            }
            catch
            {
                return null;
            }
        }

        public List<Instruction> ParseInstructions(string input)
        {
            List<Instruction> instructions = new List<Instruction>();
            foreach (char letter in input)
            {
                if (letter == 'L') instructions.Add(Instruction.L);
                else if (letter == 'R') instructions.Add(Instruction.R);
                else if (letter == 'M') instructions.Add(Instruction.M);
            }
            return instructions;
        }
    }
}