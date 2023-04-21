namespace Models_and_Steps.Models;

public class DefectModel
{
    public string DefectTitle { get; init; }
    public string ActualResult { get; init; }

    public override bool Equals(object obj)
    {
        var other = (DefectModel)obj;
        return LEquals(other);
    }

    private bool LEquals(DefectModel other)
    {
        var result = DefectTitle == other.DefectTitle && ActualResult == other.ActualResult;
        if (result == false)
        {
            Console.WriteLine($"Expected: {this}\nActual: {other}");
        }

        return result;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(DefectTitle, ActualResult);
    }

    public override string ToString()
    {
        return $"Defect title: {DefectTitle}, Actual result: {ActualResult}";
    }
}