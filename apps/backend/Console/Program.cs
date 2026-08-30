using Domain.Entities;
using Domain.ValueObjects;

var username = new Username("Bobby45");
var user = new User(username);
Console.WriteLine(user.Username);