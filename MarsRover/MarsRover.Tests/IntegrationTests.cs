using MarsRover.Console;
using NUnit.Framework;

namespace MarsRover.Tests
{
    public class IntegrationTests
    {
        private InputParser parser;

        [SetUp]
        public void SetUp()
        {
            parser = new InputParser();
        }

        [Test]
        public void Rover1_ReachesCorrectFinalPosition()
        {
            PlateauSize plateau = parser.ParsePlateauSize("5 5");
            Position rover1Position = parser.ParsePosition("1 2 N");
            List<Instruction> rover1Instructions = parser.ParseInstructions("LMLMLMLMM");

            Plateau plateauObj = new Plateau(plateau);
            plateauObj.AddRover(rover1Position);
            plateauObj.MoveRover(0, rover1Instructions);

            Assert.That(plateauObj.Rovers[0].Position.X, Is.EqualTo(1));
            Assert.That(plateauObj.Rovers[0].Position.Y, Is.EqualTo(3));
            Assert.That(plateauObj.Rovers[0].Position.Facing, Is.EqualTo(CompassDirection.N));
        }

        [Test]
        public void Rover2_ReachesCorrectFinalPosition()
        {
            PlateauSize plateau = parser.ParsePlateauSize("5 5");
            Position rover2Position = parser.ParsePosition("3 3 E");
            List<Instruction> rover2Instructions = parser.ParseInstructions("MMRMMRMRRM");

            Plateau plateauObj = new Plateau(plateau);
            plateauObj.AddRover(rover2Position);
            plateauObj.MoveRover(0, rover2Instructions);

            Assert.That(plateauObj.Rovers[0].Position.X, Is.EqualTo(5));
            Assert.That(plateauObj.Rovers[0].Position.Y, Is.EqualTo(1));
            Assert.That(plateauObj.Rovers[0].Position.Facing, Is.EqualTo(CompassDirection.E));
        }

        [Test]
        public void BothRovers_ReachCorrectFinalPositions()
        {
            PlateauSize plateau = parser.ParsePlateauSize("5 5");
            Position rover1Position = parser.ParsePosition("1 2 N");
            List<Instruction> rover1Instructions = parser.ParseInstructions("LMLMLMLMM");
            Position rover2Position = parser.ParsePosition("3 3 E");
            List<Instruction> rover2Instructions = parser.ParseInstructions("MMRMMRMRRM");

            Plateau plateauObj = new Plateau(plateau);
            plateauObj.AddRover(rover1Position);
            plateauObj.AddRover(rover2Position);
            plateauObj.MoveRover(0, rover1Instructions);
            plateauObj.MoveRover(1, rover2Instructions);

            Assert.That(plateauObj.Rovers[0].Position.X, Is.EqualTo(1));
            Assert.That(plateauObj.Rovers[0].Position.Y, Is.EqualTo(3));
            Assert.That(plateauObj.Rovers[0].Position.Facing, Is.EqualTo(CompassDirection.N));
            Assert.That(plateauObj.Rovers[1].Position.X, Is.EqualTo(5));
            Assert.That(plateauObj.Rovers[1].Position.Y, Is.EqualTo(1));
            Assert.That(plateauObj.Rovers[1].Position.Facing, Is.EqualTo(CompassDirection.E));
        }
    }
}