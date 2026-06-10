namespace MarsRover.Console
{
    public class Rover
    {
        public Position Position { get; set; }

        public Rover(Position position)
        {
            Position = position;
        }

        public void Rotate(Instruction instruction)
        {
            if (instruction == Instruction.R)
            {
                if (Position.Facing == CompassDirection.N) Position.Facing = CompassDirection.E;
                else if (Position.Facing == CompassDirection.E) Position.Facing = CompassDirection.S;
                else if (Position.Facing == CompassDirection.S) Position.Facing = CompassDirection.W;
                else if (Position.Facing == CompassDirection.W) Position.Facing = CompassDirection.N;
            }
            else if (instruction == Instruction.L)
            {
                if (Position.Facing == CompassDirection.N) Position.Facing = CompassDirection.W;
                else if (Position.Facing == CompassDirection.W) Position.Facing = CompassDirection.S;
                else if (Position.Facing == CompassDirection.S) Position.Facing = CompassDirection.E;
                else if (Position.Facing == CompassDirection.E) Position.Facing = CompassDirection.N;
            }
        }
        public void MoveForward(PlateauSize plateau)
        {
            if (Position.Facing == CompassDirection.N && Position.Y < plateau.Height)
                Position.Y++;
            else if (Position.Facing == CompassDirection.S && Position.Y > 0)
                Position.Y--;
            else if (Position.Facing == CompassDirection.E && Position.X < plateau.Width)
                Position.X++;
            else if (Position.Facing == CompassDirection.W && Position.X > 0)
                Position.X--;
        }
    }
}