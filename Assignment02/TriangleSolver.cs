using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public static class TriangleSolver
    {


        public static String Analyze(int firstSide, int secondSide, int thirdSide)
        {


            if ((firstSide + secondSide) > thirdSide && (firstSide + thirdSide) > secondSide && (secondSide + thirdSide) > firstSide)
            {
                string result;

                //equal sides
                if (firstSide == secondSide && firstSide == thirdSide)
                {

                    result = "The triangle they form is an Equilateral triangle.";
                }

                //only two sides are equal
                else if (firstSide == secondSide || firstSide == thirdSide || secondSide == thirdSide)
                {

                    result = "The triangle they form is an Isosceles triangle.";
                }

                //different sides
                else
                {
                    result = "The triangle they form is a Scalene triangle.";

                }

                return "The three sides you entered form a triangle.\n" + result;

            }


            else { return "The three sides you entered don't form a triangle!"; }




        }

    }
}
