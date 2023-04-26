using API_models.Models;
using API_models.Views;
using RestSharp;
using Utilities.Utilities;

namespace API_Services.QaseApi.ProjectService;

public class ProjectService : BaseService
{
    public void CreateProject(AProjectModel model)
    {
        var request = new RestRequest(BaseUrl + "/project", Method.Post);
        request.AddJsonBody(model);
        RClient.Execute(request);
    }

    public GeneralViewModel GetProjectByCode(AProjectModel model)
    {
        var request = new RestRequest(BaseUrl + "/project/{code}");
        request.AddUrlSegment("code", model.Code.ToUpper());
        var response = RClient.Execute(request);
        var content = Helper.GetJsonObject(response.Content);
        var actualProjectViewModel = new GeneralViewModel
        {
            StatusCode = response.StatusCode,
            Model = new AProjectModel
            {
                Title = content.result.title.ToString(),
                Code = content.result.code.ToString()
            }
        };
        return actualProjectViewModel;
    }


    public void DeleteProjectByCode(AProjectModel model)
    {
        var request = new RestRequest(BaseUrl + "/project/{code}");
        request.AddUrlSegment("code", model.Code.ToUpper());
        RClient.Execute(request, Method.Delete);
    }
}