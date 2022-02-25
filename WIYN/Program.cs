/* Create a program that when I run it, it will ask me: "What is your name?"          check
The program will wait for me to type in a name.                                       check
The program will reply with "Hi, name! Do you want to play a game? Y/N"               check
The program will wait for me to type in "Y" or "N"
If I reply with N, the program will say "Okay, name" and then terminate.
If I reply with Y, the program will ask me "Please enter in two numbers:"
If I reply with anything else, the program will say "Invalid input! Please try again!"
After I enter in two numbers, the program will display:
"number1 + number2 = " the sum
"number1 - number2 = " the difference
"number1 x number2 = " the product
"number1 / number2 = " the quotient
"number1^number2 = " number1 to the power of number2
Afterwards, the program will wait for me to press any key to close.

The program should never crash no matter what input I give it. */



// I need to use Operators and Strings
namespace WIYN
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string username = Console.ReadLine();
            Console.WriteLine("Hi, " + username + "! " + " Do you want to play a game? Y/N");
                
                
            }
        }
    }

//How make sure application doesn't crash when answered with a string, yes/no prompt, 