namespace FizzBuzz
{
    public class FizzBuzz
    {
        public Dictionary<int, string> conditions = new Dictionary<int, string>
        {
            {3,"Fizz" },
            {5,"Buzz" },
            {7,"Whizz" },
            {11,"Bang" },
            {10, "Tizz" }
        };


        public string GenerateFizzBuzz(int number)
        {
            var fizzBuzzNumber = conditions
                .Where(condition => number % condition.Key == 0)
                .Select(condition => condition.Value)
                .DefaultIfEmpty(number.ToString())
                .ToArray();

            return String.Join("", fizzBuzzNumber);
        }
    }
}
