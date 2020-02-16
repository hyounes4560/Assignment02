using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment02;
using NUnit.Framework;

namespace Assignment02.Tests
{

    [TestFixture]
   public class TriangleSolverTest
    {



        [Test]
        public void Analyze_Input3and3and3_ReturnEquilateralTriangle()
        {

            string result = TriangleSolver.Analyze(3, 3, 3);

            StringAssert.Contains("triangle", result);

        }


    }
}
