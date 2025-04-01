public class AsyncDemo
{
    public static async Task RunAsync()
    {
        int[] result = await Task.WhenAll([
            Addition(2, 2),
            Subtraction(3, 1),
            Multiplication(5, 5)
        ]);

        await Addition(3, 3);

        Console.WriteLine(result[0]);
        Console.WriteLine(result[1]);
        Console.WriteLine(result[2]);
    }

    public static async Task<int> Addition(int a, int b)
    {
        await Task.Delay(5000);
        Console.WriteLine("Job 1 completed!");
        return a + b;
    }
    public static async Task<int> Subtraction(int a, int b)
    {
        await Task.Delay(5000);
        Console.WriteLine("Job 2 completed!");
        return a - b;
    }
    public static async Task<int> Multiplication(int a, int b)
    {
        await Task.Delay(5000);
        Console.WriteLine("Job 3 completed!");
        return a * b;
    }
}