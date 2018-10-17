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
            // James - I like the naming convention you use here, good stuff!, typically when naming 
            // bools we name them just like this, we named them assuming if it's true, take this action
            // ex: isReady, doAgain, willFail.. etc etc
            bool doAgain = true;
            // James - so a conditional statement will always look for true, so what this means is you can just put the 
            // variable name inside of the while loop, so (doAgain) and it will do the same thing as doAgain==true.
            while (doAgain == true)
            {
                // James - You are using a try catch which is really cool, but typically we use error handling 
                // when we the developer cannot completely control the flow of the program, like getting a 400 or 500
                // error when making a http request, which means either a network connection issue or 
                // a server error... this is out of the devvelopers hand, we can't help if the other end does not give 
                // us something, so we throw and error.  also error handling is commonly used for logging errors, like to 
                // a file or a third party service. if you have any questions about what I left here, by all means, let me 
                // know :) overall I still liked that you used it, it's something different.
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
                    // James - if you want to see the error that is being thrown, you can do something like
                    // catch (Exception e)
                    // {
                    //      Console.WriteLine($"I'm sorry user. I do not recognize that input., error thrown {e.Message}");
                    // }
                    Console.WriteLine("I'm sorry user. I do not recognize that input.");
                }
                Console.Write("Would you like to run this program again? Y or N: ");

                // James - this is interesting, converting it into a character, I think this is pretty cool.
                // however the reason I would avoid converting into a char because it takes computation to 
                // do the conversion, and ReadLine() already returns a string, and a string has the 
                // string.Equals() method which will let you check for lower case without having to check
                // both instances of 'y', and 'Y'.  but don't get me wrong, I still like that you used a 
                // char, you are thinking creativly. 
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
