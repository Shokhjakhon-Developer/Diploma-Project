namespace Models_and_Steps.Models;

public class ProjectModel
{
    public string ProjectName { get; init; }
    public string ProjectCode { get; init; }

    public override bool Equals(object obj)
    {
        var other = (ProjectModel)obj;
        return LEquals(other);
    }

    private bool LEquals(ProjectModel other)
    {
        var result = ProjectName == other.ProjectName && ProjectCode == other.ProjectCode;
        if (result == false)
        {
            Console.WriteLine($"Expected: {this}\nActual: {other}");
        }

        return result;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ProjectName, ProjectCode);
    }

    public override string ToString()
    {
        return $"Project name: {ProjectName}, Project code: {ProjectCode}.";
    }
}