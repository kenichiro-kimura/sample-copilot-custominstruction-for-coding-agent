namespace FizzBuzz;

public class Program
{
    private const int DEFAULT_MAX_VALUE = 100;

    public static void Main(string[] args)
    {
        var maxValue = GetMaxValue(args);
        var results = GenerateFizzBuzz(maxValue);
        
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }

    public static int GetMaxValue(string[] args)
    {
        if (args.Length == 0)
            return DEFAULT_MAX_VALUE;

        var input = args[0];
        if (string.IsNullOrWhiteSpace(input))
            return DEFAULT_MAX_VALUE;

        if (!int.TryParse(input, out var value))
            return DEFAULT_MAX_VALUE;

        if (value <= 0 || value > 100)
            return DEFAULT_MAX_VALUE;

        return value;
    }

    public static IEnumerable<string> GenerateFizzBuzz(int maxValue)
    {
        for (var i = 1; i <= maxValue; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                yield return "FizzBuzz";
            else if (i % 3 == 0)
                yield return "Fizz";
            else if (i % 5 == 0)
                yield return "Buzz";
            else
                yield return i.ToString();
        }
    }
}
