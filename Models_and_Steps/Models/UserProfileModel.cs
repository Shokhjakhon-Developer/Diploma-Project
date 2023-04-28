namespace Models_and_Steps.Models;

public class UserProfileModel
{
    public string Name { get; init; }
    public string Position { get; init; }

    public override bool Equals(object obj)
    {
        var other = (UserProfileModel)obj;
        return LEquals(other);
    }

    protected bool LEquals(UserProfileModel other)
    {
        var result = Name == other.Name && Position == other.Position;
        if (result == false)
        {
            Console.WriteLine($"Expected: {this}\nActual: {other}");
        }

        return result;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Position);
    }

    public override string ToString()
    {
        return $"Name: {Name}, Position: {Position}";
    }
}