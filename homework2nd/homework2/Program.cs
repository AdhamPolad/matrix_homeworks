namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 35;
            int num2 = 26;
            int resultAdd = Add(num1, num2);
            int resultSubstract = Substract(num1, num2);
            int resultDivision = Division(num1, num2);
            int resultMultiplication = Multiplication(num1, num2);
            Console.WriteLine("First number is " + num1 + ", " + "Second number is " + num2);
            Console.WriteLine("Sum is: " + resultAdd);
            Console.WriteLine("Substraction is: " + resultSubstract);
            Console.WriteLine("Multiplication is: " + resultMultiplication);
            Console.WriteLine("Division is: " + resultDivision);
        }
        static int Add(int num1, int num2)
        {
            int result;
            result = num1 + num2;
            return result;
        }

        static int Substract(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }


        static int Multiplication(int num1, int num2)
        {
            int result;
            result = num1 * num2;
            return result;
        }

        static int Division(int num1, int num2)
        {
            int result = num1 / num2;
            return (int)result;
        }






    }
}
