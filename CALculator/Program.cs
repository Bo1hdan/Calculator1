using System;

namespace Calculator
{
    class Calculator
    {
        static void Main(string [] args)
        {
            int result = 0;
            
            Console.WriteLine("Enter first num");
            string firstNum = Console.ReadLine();
            int firstNumInt = int.Parse(firstNum);
            Console.WriteLine("First number is " + firstNumInt);

            Console.WriteLine("Please enter your operator");
            string oper = Console.ReadLine();
            Console.WriteLine("Your operator is:"+ oper);

            Console.WriteLine("Enter second num");
            string secondNum = Console.ReadLine();
            int secondNumInt = int.Parse(secondNum);
            Console.WriteLine("Second number is " + secondNumInt);
           
            
            
            if (oper=="+")
            {
                result = firstNumInt + secondNumInt;
            }
            else if (oper=="-")
            {
                result = firstNumInt - secondNumInt;
            }
            else if (oper == "*")
            {
                result = firstNumInt * secondNumInt;
            }
            else if(oper == "/")
            {
                result = firstNumInt / secondNumInt;
            }
            else {
                Console.WriteLine("ebanant");
                
                
            }

            Console.WriteLine("Your result is: " + result);



        }
    }
}