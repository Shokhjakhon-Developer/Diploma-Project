using System.Net;
using API_models.Models;

namespace API_models.Views;

public class GeneralViewModel : BaseView
{
    public override HttpStatusCode StatusCode { get; set; }
    public override IModel Model { get; set; }

    public override bool Equals(object? obj)
    {
        var other = obj as GeneralViewModel;
        return LEquals(other);
    }

    protected bool LEquals(GeneralViewModel other)
    {
        return StatusCode == other.StatusCode && Model.Equals(other.Model);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine((int)StatusCode, Model);
    }

    public override string ToString()
    {
        return $"Status code: {StatusCode}\n\tModel: {Model}";
    }
}