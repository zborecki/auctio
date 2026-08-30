using Domain.Common;

namespace Domain.ValueObjects;

public class Username
{
    private string Value { get; }

    public Username(string username)
    {
        Validate(username);
        Value = username; 
    }

    private static void Validate(string username)
    {
        StringGuard.ThrowIfNullOrWhiteSpace(username);
        StringGuard.ThrowIfLengthOutOfRange(username, 3, 32);
    }

    public override string ToString()
    {
        return Value;
    }
}