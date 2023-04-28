using System.Net;
using API_models.Models;
using RestSharp;
using Utilities.Utilities;

namespace API_Services.QaseApi.ProjectService;

public class ProjectService : BaseService
{
    public (HttpStatusCode, string) CreateProject(AProjectModel model)
    {
        var request = new RestRequest(BaseUrl + "/project", Method.Post);
        request.AddJsonBody(model);
        var response = RClient.Execute(request);
        return (response.StatusCode, response.Content);
    }

    public (HttpStatusCode, IModel, string) GetProjectByCode(AProjectModel model)
    {
        var request = new RestRequest(BaseUrl + "/project/{code}");
        request.AddUrlSegment("code", model.Code.ToUpper());
        var response = RClient.Execute(request);
        var content = ApiHelper.GetJsonObject(response.Content);

        AProjectModel actualModel = new AProjectModel
        {
            Title = content.result.title.ToString(),
            Code = content.result.code.ToString()
        };

        return (response.StatusCode, actualModel, response.Content);
    }


    public void DeleteProjectByCode(AProjectModel model)
    {
        var request = new RestRequest(BaseUrl + "/project/{code}");
        request.AddUrlSegment("code", model.Code.ToUpper());
        RClient.Execute(request, Method.Delete);
    }
}