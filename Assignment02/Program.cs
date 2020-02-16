using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {

        static void Main(string[] args)
        {


            int firstSide;
            int secondSide;
            int thirdSide;
            string sideString = "";
            string option = "";
            bool flag = false;

            try
            {



                do
                {

                    do
                    {
                        Console.WriteLine("\nChoose one option from the following two options:");
                        Console.WriteLine("1.Enter triangle dimensions\n" +
                                           "2.Exit\n");

                        option = Console.ReadLine();

                    } while (!int.TryParse(option, out int userOption) || (userOption < 1 || userOption > 2));

                    //to keep showing the main menu 
                    flag = true;

                    switch (option)
                    {
                        case "1":

                            do
                            {
                                Console.WriteLine("Please enter the first side of the traingle");
                                sideString = Console.ReadLine();

                            } while ((!int.TryParse(sideString, out firstSide) || firstSide < 1));

                            do
                            {
                                Console.WriteLine("Please enter the second side of the traingle");
                                sideString = Console.ReadLine();

                            } while ((!int.TryParse(sideString, out secondSide) || secondSide < 1));

                            do
                            {

                                Console.WriteLine("Please enter the third side of the traingle");
                                sideString = Console.ReadLine();

                            } while ((!int.TryParse(sideString, out thirdSide) || thirdSide < 1));




                            string result = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);
                            Console.WriteLine(result);
                            Console.ReadKey();

                            break;


                        case "2":
                            Console.WriteLine("Sorry to see you leave! GoodBye....");

                            //to stop showing the main menu and exit the application
                            flag = false;
                            break;

                        default:
                            Console.WriteLine("Something went wrong");
                            break;

                    }
                } while (flag);




            }
            catch
            {

                throw new NotImplementedException();

            }





        }
    }
}
