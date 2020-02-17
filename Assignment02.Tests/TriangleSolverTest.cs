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
        
        private const string expectedNotTriangle = "The three sides you entered don't form a triangle!";
        private const string expectedEquilateralTriangle = "The three sides you entered form a triangle.\nThe triangle they form is an Equilateral triangle.";
        private const string expectedIsoscelesTriangle = "The three sides you entered form a triangle.\nThe triangle they form is an Isosceles triangle.";
        private const string expectedScaleneTriangle= "The three sides you entered form a triangle.\nThe triangle they form is a Scalene triangle.";


        /*Please note that the Analyze method only accepts numbers so letters, floating numbers, 
         * special characters, or empty entries cause a compile error and the code won't run */


        [Test]
        /*1-This test case tests if 3 sides form a triangle or not. 
         If they do form a triangle, return the type of the triangle.  
         In this test, the sides (1,2,3) don't form a triangle.*/
        public void Analyze_Input1and2and3_ReturnNotTriangle()
        {

            string result = TriangleSolver.Analyze(1, 2, 3);
            StringAssert.AreEqualIgnoringCase(expectedNotTriangle, result);

        }

        [Test]
        /*2-This test case tests if 3 sides form a triangle or not. 
         If they do form a triangle, return the type of the triangle.  
         In this test, the sides (2,1,3) don't form a triangle.*/
        public void Analyze_Input2and1and3_ReturnNotTriangle()
        {

            string result = TriangleSolver.Analyze(2, 1, 3);
            StringAssert.AreEqualIgnoringCase(expectedNotTriangle, result);

        }


        [Test]
        /*3-This test case tests if 3 sides form a triangle or not. 
         If they do form a triangle, return the type of the triangle.  
         In this test, the sides (3,1,2) don't form a triangle.*/
        public void Analyze_Input3and1and2_ReturnNotTriangle()
        {

            string result = TriangleSolver.Analyze(3, 1, 2);
            StringAssert.AreEqualIgnoringCase(expectedNotTriangle, result);

        }


        [Test]
        /*4- This test case tests if 3 sides form a triangle or not. 
         If they do form a triangle, return the type of the triangle.  
         In this test, the sides (0,10,0) don't form a triangle.*/
        public void Analyze_Input0and10and0_ReturnNotlTriangle()
        {

            string result = TriangleSolver.Analyze(0, 10, 0);
            StringAssert.AreEqualIgnoringCase(expectedNotTriangle, result);

        }


        [Test]
        /*5- This test case tests if 3 sides form a triangle or not. 
         If they do form a triangle, return the type of the triangle.  
         In this test, the sides (-6,-6,-6) don't form a triangle.*/
        public void Analyze_InputNegativeNumbers_ReturnNotlTriangle()
        {

            string result = TriangleSolver.Analyze(-6, -6, -6);
            StringAssert.AreEqualIgnoringCase(expectedNotTriangle, result);

        }

        [Test]
        /*6- This test case tests if 3 sides form a triangle or not. 
         If they do form a triangle, return the type of the triangle.  
         In this test, the sides (8,-1,0) don't form a triangle.*/
        public void Analyze_Input8and0andNegativeNumber_ReturnNotlTriangle()
        {

            string result = TriangleSolver.Analyze(8, -1 , 0 );
            StringAssert.AreEqualIgnoringCase(expectedNotTriangle, result);

        }

        [Test]
        /*7- This test case tests if 3 sides form a triangle or not. 
         If they do form a triangle, return the type of the triangle.  
         In this test, the sides (4,4,4) form an Equilateral triangle.*/
        public void Analyze_Input4and4and4_ReturnEquilateralTriangle()
        {

            string result = TriangleSolver.Analyze(4, 4, 4);
            StringAssert.AreEqualIgnoringCase(expectedEquilateralTriangle, result);

        }


        [Test]
        /*8- This test case tests if 3 sides form a triangle or not. 
         If they do form a triangle, return the type of the triangle. 
         In this test, the sides (4,5,5) form an Isosceles triangle.*/
        public void Analyze_Input4and5and5_ReturnIsoscelesTriangle()
        {
            string result = TriangleSolver.Analyze(4, 5, 5);
            StringAssert.AreEqualIgnoringCase(expectedIsoscelesTriangle, result);

        }


        [Test]
        /*9- This test case tests if 3 sides form a triangle or not. 
         If they do form a triangle, return the type of the triangle. 
         In this test, the sides (6,5,8) form an Scalene triangle.*/
        public void Analyze_Input6and5and8_ReturnScaleneTriangle()
        {
            string result = TriangleSolver.Analyze(6, 5, 8);
            StringAssert.AreEqualIgnoringCase(expectedScaleneTriangle, result);

        }


        [Test]
        /*8-This test case tests if 3 sides form a triangle or not. 
         If they do form a triangle, return the type of the triangle.  
         In this test, the sides (100,1,100) don't form a triangle.*/
        public void Analyze_Input100and1and100_ReturnNotTriangle()
        {

            string result = TriangleSolver.Analyze(100, 1, 100);
            StringAssert.AreEqualIgnoringCase(expectedIsoscelesTriangle, result);

        }






    }
}
