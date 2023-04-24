using API_models.Models;
using RestSharp;

namespace API_Services.Qase_Api.Case_service;

public class CaseService : BaseService
{
    public RestResponse CreateCase(CaseModel caseModel, ProjectModel projectModel)
    {
        var request = new RestRequest(BaseUrl + "/case/{code}/1", Method.Post);
        request.AddUrlSegment("code", projectModel.Code.ToUpper());
        request.AddJsonBody(caseModel);
        var response = RClient.Execute(request);
        return response;
    }

    public RestResponse GetCaseByCode(ProjectModel model)
    {
        var request = new RestRequest(BaseUrl + "/case/{code}");
        request.AddUrlSegment("code", model.Code.ToUpper());
        var response = RClient.Execute(request);
        return response;
    }
}