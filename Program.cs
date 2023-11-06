namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print();
        }

        public static void Print(int start = 1)
        {
            FizzBuzz f = new FizzBuzz();

            var lastValue = String.Join("", f.conditions.Select(x => x.Value).ToArray());

            var currentValue = f.GenerateFizzBuzz(start);

            while (currentValue != lastValue)
            {
                currentValue = f.GenerateFizzBuzz(start);
                Console.WriteLine(currentValue);
                start++;
            }
        }
    }
}