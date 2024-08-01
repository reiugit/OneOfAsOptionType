using OneOf;
using OneOf.Types;

namespace OneOfAsOptionType;

internal class PositiveNumberChecker
{
    private readonly int _number;

    private PositiveNumberChecker(int number)
    {
        _number = number;
    }

    public int Number => _number;

    public static PositiveNumberChecker Create(int number)
    {
        return new(number);
    }

    public OneOf<int, None> GetPositiveNumberOrNone()
    {
        return _number > 0
            ? _number
            : new None();
    }
}
