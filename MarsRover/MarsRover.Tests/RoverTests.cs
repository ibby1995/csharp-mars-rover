using MarsRover.Console;
using NUnit.Framework;

namespace MarsRover.Tests
{
    public class RoverTests
    {
        [Test]
        public void Rotate_FacingNorth_RotateRight_FacesEast()
        {
            Rover rover = new Rover(new Position(0, 0, CompassDirection.N));
            rover.Rotate(Instruction.R);
            Assert.That(rover.Position.Facing, Is.EqualTo(CompassDirection.E));
        }

        [Test]
        public void Rotate_FacingNorth_RotateLeft_FacesWest()
        {
            Rover rover = new Rover(new Position(0, 0, CompassDirection.N));
            rover.Rotate(Instruction.L);
            Assert.That(rover.Position.Facing, Is.EqualTo(CompassDirection.W));
        }

        [Test]
        public void Rotate_FacingEast_RotateRight_FacesSouth()
        {
            Rover rover = new Rover(new Position(0, 0, CompassDirection.E));
            rover.Rotate(Instruction.R);
            Assert.That(rover.Position.Facing, Is.EqualTo(CompassDirection.S));
        }

        [Test]
        public void Rotate_FacingEast_RotateLeft_FacesNorth()
        {
            Rover rover = new Rover(new Position(0, 0, CompassDirection.E));
            rover.Rotate(Instruction.L);
            Assert.That(rover.Position.Facing, Is.EqualTo(CompassDirection.N));
        }

        [Test]
        public void Rotate_FacingSouth_RotateRight_FacesWest()
        {
            Rover rover = new Rover(new Position(0, 0, CompassDirection.S));
            rover.Rotate(Instruction.R);
            Assert.That(rover.Position.Facing, Is.EqualTo(CompassDirection.W));
        }

        [Test]
        public void Rotate_FacingSouth_RotateLeft_FacesEast()
        {
            Rover rover = new Rover(new Position(0, 0, CompassDirection.S));
            rover.Rotate(Instruction.L);
            Assert.That(rover.Position.Facing, Is.EqualTo(CompassDirection.E));
        }

        [Test]
        public void Rotate_FacingWest_RotateRight_FacesNorth()
        {
            Rover rover = new Rover(new Position(0, 0, CompassDirection.W));
            rover.Rotate(Instruction.R);
            Assert.That(rover.Position.Facing, Is.EqualTo(CompassDirection.N));
        }

        [Test]
        public void Rotate_FacingWest_RotateLeft_FacesSouth()
        {
            Rover rover = new Rover(new Position(0, 0, CompassDirection.W));
            rover.Rotate(Instruction.L);
            Assert.That(rover.Position.Facing, Is.EqualTo(CompassDirection.S));
        }
        [Test]
        public void MoveForward_FacingNorth_YIncreasesByOne()
        {
            Rover rover = new Rover(new Position(0, 0, CompassDirection.N));
            PlateauSize plateau = new PlateauSize(5, 5);
            rover.MoveForward(plateau);
            Assert.That(rover.Position.Y, Is.EqualTo(1));
        }

        [Test]
        public void MoveForward_FacingSouth_YDecreasesByOne()
        {
            Rover rover = new Rover(new Position(0, 2, CompassDirection.S));
            PlateauSize plateau = new PlateauSize(5, 5);
            rover.MoveForward(plateau);
            Assert.That(rover.Position.Y, Is.EqualTo(1));
        }

        [Test]
        public void MoveForward_FacingEast_XIncreasesByOne()
        {
            Rover rover = new Rover(new Position(0, 0, CompassDirection.E));
            PlateauSize plateau = new PlateauSize(5, 5);
            rover.MoveForward(plateau);
            Assert.That(rover.Position.X, Is.EqualTo(1));
        }

        [Test]
        public void MoveForward_FacingWest_XDecreasesByOne()
        {
            Rover rover = new Rover(new Position(2, 0, CompassDirection.W));
            PlateauSize plateau = new PlateauSize(5, 5);
            rover.MoveForward(plateau);
            Assert.That(rover.Position.X, Is.EqualTo(1));
        }

        [Test]
        public void MoveForward_HitsNorthBoundary_StaysInPlace()
        {
            Rover rover = new Rover(new Position(0, 5, CompassDirection.N));
            PlateauSize plateau = new PlateauSize(5, 5);
            rover.MoveForward(plateau);
            Assert.That(rover.Position.Y, Is.EqualTo(5));
        }

        [Test]
        public void MoveForward_HitsEastBoundary_StaysInPlace()
        {
            Rover rover = new Rover(new Position(5, 0, CompassDirection.E));
            PlateauSize plateau = new PlateauSize(5, 5);
            rover.MoveForward(plateau);
            Assert.That(rover.Position.X, Is.EqualTo(5));
        }

        [Test]
        public void MoveForward_HitsSouthBoundary_StaysInPlace()
        {
            Rover rover = new Rover(new Position(0, 0, CompassDirection.S));
            PlateauSize plateau = new PlateauSize(5, 5);
            rover.MoveForward(plateau);
            Assert.That(rover.Position.Y, Is.EqualTo(0));
        }

        [Test]
        public void MoveForward_HitsWestBoundary_StaysInPlace()
        {
            Rover rover = new Rover(new Position(0, 0, CompassDirection.W));
            PlateauSize plateau = new PlateauSize(5, 5);
            rover.MoveForward(plateau);
            Assert.That(rover.Position.X, Is.EqualTo(0));
        }
    }
}