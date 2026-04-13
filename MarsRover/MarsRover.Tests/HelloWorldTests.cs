using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace MarsRover.Tests;

public class HelloWorldTests
{
    [Test]
    public void Successfully_runs_a_test()
    {
        Assert.That(true, Is.True);
    }
}


