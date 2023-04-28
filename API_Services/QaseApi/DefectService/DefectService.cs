using System.Net;
using API_models.Models;
using RestSharp;
using Utilities.Utilities;

namespace API_Services.QaseApi.DefectService;

public class DefectService : BaseService
{
    public (HttpStatusCode, string) CreateDefect(ADefectModel model, string code)
    {
        var request = new RestRequest(BaseUrl + "/defect/{code}", Method.Post);
        request.AddUrlSegment("code", code.ToUpper());
        request.AddJsonBody(model);
        var response = RClient.Execute(request);
        return (response.StatusCode, response.Content);
    }

    public (HttpStatusCode, IModel, string) GetDefectByCode(string code)
    {
        var request = new RestRequest(BaseUrl + "/defect/{code}/1");
        request.AddUrlSegment("code", code.ToUpper());
        var response = RClient.Execute(request);
        var content = ApiHelper.GetJsonObject(response.Content);

        ADefectModel actualModel = new ADefectModel
        {
            ActualResult = content.result.actual_result.ToString(),
            Title = content.result.title.ToString()
        };

        return (response.StatusCode, actualModel, response.Content);
    }
}