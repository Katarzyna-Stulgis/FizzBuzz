namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 100; i++)
            {
                Console.WriteLine(GenerateFizzBuzz(i));
            }
        }

        public static string GenerateFizzBuzz(int number)
        {
            var result = String.Empty;

            if (number % 3 == 0)
            {
                result += "Fizz";
            }
            if (number % 5 == 0)
            {
                result += "Buzz";
            }
            if(result.Length == 0)
            {
                result = number.ToString();
            }

            return result;
        }
    }
}