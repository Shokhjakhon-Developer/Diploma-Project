using API_models.Models;
using RestSharp;

namespace API_Services.Qase_Api.Defect_service;

public class DefectService : BaseService
{
    public RestResponse CreateDefect(DefectModel model, string code)
    {
        var request = new RestRequest(BaseUrl + "/defect/{code}", Method.Post);
        request.AddUrlSegment("code", code.ToUpper());
        request.AddJsonBody(model);
        var response = RClient.Execute(request);
        return response;
    }

    public RestResponse FindDefectByCode(string code)
    {
        var request = new RestRequest(BaseUrl + "/defect/{code}/1");
        request.AddUrlSegment("code", code.ToUpper());
        var response = RClient.Execute(request);
        return response;
    }
}