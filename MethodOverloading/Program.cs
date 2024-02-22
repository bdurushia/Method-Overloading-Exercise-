namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Add(45, 8)}");
            Console.WriteLine($"{Add(67.5m, 13.2m)}");

            var userNum1 = 0;
            var userNum2 = 0;

            Console.Write("\nInput a number: ");
            var isNum1True = int.TryParse(Console.ReadLine(), out userNum1);
            Console.Write("\nInput another number: ");
            var isNum2True = int.TryParse(Console.ReadLine(), out userNum2);

            if (isNum1True && isNum2True)
            {
                Console.WriteLine($"{Add(userNum1, userNum2, isNum1True)}");
            }
            else
            {
                Console.WriteLine("Sorry, that is not a valid number input.");
            }
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isNum1True)
        {
            var sum = num1 + num2;
            var sumMessage = (isNum1True = true && sum > 1) ? $"{sum} dollars" : $"{sum} dollar";
            return sumMessage;
        }
    }
}