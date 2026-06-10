using MarsRover.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Tests
{
    public class InPutParserTests
    {
        
            private InputParser parser;

            [SetUp]
            public void SetUp()
            {
                parser = new InputParser();
            }
            

            [Test]
            public void ParsePlateauSize_GivesCorrectWidth()
            {
                PlateauSize result = parser.ParsePlateauSize("5 5");
                Assert.That(result.Width, Is.EqualTo(5));
            }

            [Test]
            public void ParsePlateauSize_GivesCorrectHeight()
            {
                PlateauSize result = parser.ParsePlateauSize("5 5");
                Assert.That(result.Height, Is.EqualTo(5));
            }

            [Test]
            public void ParsePlateauSize_WorksWithDifferentNumbers()
            {
                PlateauSize result = parser.ParsePlateauSize("10 20");
                Assert.That(result.Width, Is.EqualTo(10));
                Assert.That(result.Height, Is.EqualTo(20));
            }

            
            
            

            [Test]
            public void ParsePosition_GivesCorrectX()
            {
                Position result = parser.ParsePosition("1 2 N");
                Assert.That(result.X, Is.EqualTo(1));
            }

            [Test]
            public void ParsePosition_GivesCorrectY()
            {
                Position result = parser.ParsePosition("1 2 N");
                Assert.That(result.Y, Is.EqualTo(2));
            }

            [Test]
            public void ParsePosition_FacingNorth()
            {
                Position result = parser.ParsePosition("1 2 N");
                Assert.That(result.Facing, Is.EqualTo(CompassDirection.N));
            }

            [Test]
            public void ParsePosition_FacingSouth()
            {
                Position result = parser.ParsePosition("1 2 S");
                Assert.That(result.Facing, Is.EqualTo(CompassDirection.S));
            }

            [Test]
            public void ParsePosition_FacingEast()
            {
                Position result = parser.ParsePosition("1 2 E");
                Assert.That(result.Facing, Is.EqualTo(CompassDirection.E));
            }

            [Test]
            public void ParsePosition_FacingWest()
            {
                Position result = parser.ParsePosition("1 2 W");
                Assert.That(result.Facing, Is.EqualTo(CompassDirection.W));
            }

            
            
            

            [Test]
            public void ParseInstructions_GivesCorrectCount()
            {
                List<Instruction> result = parser.ParseInstructions("LMRM");
                Assert.That(result.Count, Is.EqualTo(4));
            }

            [Test]
            public void ParseInstructions_FirstInstructionIsCorrect()
            {
                List<Instruction> result = parser.ParseInstructions("LMRM");
                Assert.That(result[0], Is.EqualTo(Instruction.L));
            }

            [Test]
            public void ParseInstructions_InstructionsAreInOrder()
            {
                List<Instruction> result = parser.ParseInstructions("LMR");
                Assert.That(result[0], Is.EqualTo(Instruction.L));
                Assert.That(result[1], Is.EqualTo(Instruction.M));
                Assert.That(result[2], Is.EqualTo(Instruction.R));
            }

            [Test]
            public void ParseInstructions_InvalidLettersAreIgnored()
            {
                List<Instruction> result = parser.ParseInstructions("LMRBBB");
                Assert.That(result.Count, Is.EqualTo(3));
            }

            [Test]
            public void ParseInstructions_EmptyStringGivesEmptyList()
            {
                List<Instruction> result = parser.ParseInstructions("");
                Assert.That(result.Count, Is.EqualTo(0));
            }
        }
    }



