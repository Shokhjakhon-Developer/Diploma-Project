using System.Net;
using API_models.Models;
using RestSharp;
using Utilities.Utilities;

namespace API_Services.QaseApi.CaseService;

public class CaseService : BaseService
{
    public (HttpStatusCode, string) CreateCase(ACaseModel caseModel, AProjectModel projectModel)
    {
        var request = new RestRequest(BaseUrl + "/case/{code}", Method.Post);
        request.AddUrlSegment("code", projectModel.Code.ToUpper());
        request.AddJsonBody(caseModel);
        var response = RClient.Execute(request);
        return (response.StatusCode, response.Content);
    }

    public (HttpStatusCode, IModel, string) GetCaseByCode(AProjectModel model)
    {
        var request = new RestRequest(BaseUrl + "/case/{code}/1");
        request.AddUrlSegment("code", model.Code.ToUpper());
        var response = RClient.Execute(request);
        var content = ApiHelper.GetJsonObject(response.Content);

        var actualModel = new ACaseModel
        {
            Title = content.result.title.ToString(),
        };

        return (response.StatusCode, actualModel, response.Content);
    }
}