using Domain.Common;
using Domain.ValueObjects;

namespace Domain.Entities;

public class User(Username username) : Entity
{
    public Username Username { get; } = username;
}