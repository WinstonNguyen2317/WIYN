/* Create a program that when I run it, it will ask me: "What is your name?"              check
The program will wait for me to type in a name.                                           check
The program will reply with "Hi, name! Do you want to play a game? Y/N"                   check
The program will wait for me to type in "Y" or "N"                                        check
If I reply with N, the program will say "Okay, name" and then terminate.                  check
If I reply with Y, the program will ask me "Please enter in two numbers:"                 check
If I reply with anything else, the program will say "Invalid input! Please try again!"    check
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

            string answer;
            Console.WriteLine("What is your name?");
            string username = Console.ReadLine();
            Console.WriteLine("Hi, " + username + "! " + " Do you want to play a game? Y/N");
            answer = Console.ReadLine();


            do
            {
                Console.WriteLine("Hi, " + username + "! " + " Do you want to play a game? Y/N");
                answer = Console.ReadLine();
                if (answer == "N")
                {
                    Console.WriteLine("Okay, " + username);
                    return;
                }
                else if (answer == "Y")
                {
                    string[] tokens = string[10]
                    double first, second, result;
                    Console.WriteLine("Please enter two numbers:");
                    first = Convert.ToInt32(Console.ReadLine());
                    second = Convert.ToInt32(Console.ReadLine());

                    
                    int a = int.Parse(tokens[0]);
                    int b = int.Parse(tokens[1]);
                    tokens[0] = answer;

                    result = first + second;
                    Console.WriteLine("{0} + {1} = {2}", first, second, result);
                    result = first - second;
                    Console.WriteLine("{0} - {1} = {2}", first, second, result);
                    result = first * second;
                    Console.WriteLine("{0} * {1} = {2}", first, second, result);
                    result = first / second;
                    Console.WriteLine("{0} % {1} = {2}", first, second, result);
                }
                else
                {
                    Console.WriteLine("Invalid input! Please try again!");
                } 
               
            }
             while(answer != "N" || answer != "Y");
            
        }
    }

}


