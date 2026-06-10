namespace MarsRover.Console
{
    public class Plateau
    {
        public PlateauSize Size { get; set; }
        public List<Rover> Rovers { get; set; }

        public Plateau(PlateauSize size)
        {
            Size = size;
            Rovers = new List<Rover>();
        }

        public void AddRover(Position position)
        {
            Rovers.Add(new Rover(position));
        }

        public void MoveRover(int roverIndex, List<Instruction> instructions)
        {
            Rover rover = Rovers[roverIndex];
            foreach (Instruction instruction in instructions)
            {
                if (instruction == Instruction.M)
                    rover.MoveForward(Size);
                else
                    rover.Rotate(instruction);
            }
        }
    }
}