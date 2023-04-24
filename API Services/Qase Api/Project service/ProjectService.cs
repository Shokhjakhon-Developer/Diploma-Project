using API_models.Models;
using RestSharp;

namespace API_Services.Qase_Api.Project_service;

public class ProjectService : BaseService
{
    public RestResponse CreateProject(ProjectModel model)
    {
        var request = new RestRequest(BaseUrl + "/project", Method.Post);
        request.AddJsonBody(model);
        var response = RClient.Execute(request);
        return response;
    }

    public RestResponse GetProjectByCode(ProjectModel model)
    {
        var request = new RestRequest(BaseUrl + "/project/{code}");
        request.AddUrlSegment("code", model.Code.ToUpper());
        var response = RClient.Execute(request);
        return response;
    }


    public RestResponse DeleteProjectByCode(ProjectModel model)
    {
        var request = new RestRequest(BaseUrl + "/project/{code}");
        request.AddUrlSegment("code", model.Code.ToUpper());
        var response = RClient.Execute(request, Method.Delete);
        return response;
    }
}