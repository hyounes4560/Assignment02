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

                if (firstSide == secondSide && firstSide == thirdSide)
                {

                    result = "The traingle they form is an Equilateral triangle.\n";
                }

                else if (firstSide == secondSide || firstSide == thirdSide || secondSide == thirdSide)
                {

                    result = "The traingle they form is an Isosceles traingle.\n";
                }

                else
                {
                    result = "The traingle they form is a Scalene traingle.\n";

                }

                return "The three sides you entered form a traingle.\n" + result + "Press any key to go back to the main menu and try again.";

            }


            else { return "The three sides you entered don't form a traingle!\nPress any key to go back to the main menu and try again."; }




        }

    }
}
