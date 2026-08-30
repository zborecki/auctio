using System.Runtime.CompilerServices;

namespace Domain.Common;

public static class StringGuard
{
    public static void ThrowIfNullOrWhiteSpace(string value, [CallerArgumentExpression(nameof(value))] string? parameterName = null)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException($"{parameterName} cannot be empty.", parameterName);
        }
    }

    public static void ThrowIfLengthOutOfRange(string value, int minLength, int maxLength,
        [CallerArgumentExpression(nameof(value))] string? parameterName = null)
    {
        if (value.Length < minLength)
        {
            throw new ArgumentException($"{parameterName} must contain at least {minLength} characters.", parameterName);
        }

        if (value.Length > maxLength)
        {
            throw new ArgumentException($"{parameterName} cannot contain more than {maxLength} characters.", parameterName);
        }
    }
}