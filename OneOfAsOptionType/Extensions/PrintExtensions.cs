namespace OneOfAsOptionType.Extensions;

internal static class PrintExtensions
{
    public static PositiveNumberChecker Print(this PositiveNumberChecker positiveNumberChecker)
    {
        Console.WriteLine($"\nNumber: {positiveNumberChecker.Number}");

        return positiveNumberChecker;
    }

    public static void Print<T>(this T value)
    {
        Console.WriteLine($"Value:  {value}");
    }
}
