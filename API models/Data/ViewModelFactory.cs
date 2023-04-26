using System.Net;
using API_models.Views;

namespace API_models.Data;

public class ViewModelFactory
{
    public static readonly GeneralViewModel ExpectedProjectViewModel = new()
    {
        StatusCode = HttpStatusCode.OK,
        Model = AProjectModelFactory.Model
    };

    public static readonly GeneralViewModel ExpectedDefectViewModel = new()
    {
        StatusCode = HttpStatusCode.OK,
        Model = ADefectModelFactory.Model
    };

    public static readonly GeneralViewModel ExpectedCaseViewModel = new()
    {
        StatusCode = HttpStatusCode.OK,
        Model = ACaseModelFactory.Model
    };
}