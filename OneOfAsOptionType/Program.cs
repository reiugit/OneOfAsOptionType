using OneOfAsOptionType;
using OneOfAsOptionType.Extensions;
using OneOfAsOptionType.Keyhandler;

Console.WriteLine("\n'OneOf' used as 'Option Type':\n");

PositiveNumberChecker
    .Create(1)
    .Print()
    .GetPositiveNumberOrNone() // returns 'OneOf<int, None>' (which is similar to 'Option<int>')
    .Match(
        pInt => $"{pInt} - Positive number",
        none => "None - No positive number")
    .Print();

PositiveNumberChecker
    .Create(-1)
    .Print()
    .GetPositiveNumberOrNone()
    .Match(
        pInt => $"{pInt} - Positive number",
        none => "None - No positive number")
    .Print();


KeyHandler.WaitForKey();
