using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doAgain = true;
            while (doAgain == true)
            {
                try
                {
                    Console.Write("Hello user! Please enter your length measurement in feet: ");
                    string userInputOne = Console.ReadLine();
                    Console.Write("Thank you! Please enter your width measurement in feet: ");
                    string userInputTwo = Console.ReadLine();
                    Console.Write("Thank you! Lastly, please enter your height measurement in feet: ");
                    string userInputThree = Console.ReadLine();

                    float inputOne = float.Parse(userInputOne), inputTwo = float.Parse(userInputTwo), inputThree = float.Parse(userInputThree);

                    float roomArea = inputOne * inputTwo, roomPerimeter = 2 * (inputOne + inputTwo), roomVolume = inputOne * inputTwo * inputThree;

                    Console.WriteLine("Area: {0}", roomArea);
                    Console.WriteLine("Perimeter: {0}", roomPerimeter);
                    Console.WriteLine("Room volume: {0}", roomVolume);
                }
                catch (Exception)
                {
                    Console.WriteLine("I'm sorry user. I do not recognize that input.");
                }
                Console.Write("Would you like to run this program again? Y or N: ");
                char repeat = Convert.ToChar(Console.ReadLine());
                if (repeat == 'Y' || repeat == 'y')
                {
                    doAgain = true;
                }
                else
                {
                    doAgain = false;
                }
                Console.WriteLine(" ");
            }
        }
    }
}
