using System.Net;
using API_models.Models;
using Models.Models;
using Newtonsoft.Json;
using OpenQA.Selenium;
using RestSharp;
using Utilities.Utilities;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace API_Services.QaseApi.CaseService;

public class CaseService : BaseService
{
    public (HttpStatusCode, string) CreateCase(Case caseModel, AProjectModel projectModel)
    {
        var request = new RestRequest(BaseUrl + "/case/{code}", Method.Post);
        request.AddUrlSegment("code", projectModel.Code.ToUpper());
        string jsonCase = JsonSerializer.Serialize(caseModel);
        Console.WriteLine(jsonCase);
        request.AddJsonBody(jsonCase);
        var response = RClient.Execute(request);
        return (response.StatusCode, response.Content);
    }

    public (HttpStatusCode, Case, string) GetCaseByCode(AProjectModel model)
    {
        var request = new RestRequest(BaseUrl + "/case/{code}/1");
        request.AddUrlSegment("code", model.Code.ToUpper());
        var response = RClient.Execute(request);
        var content = ApiHelper.GetJsonObject(response.Content);
        Case? deserializedCase = JsonConvert.DeserializeObject<Case>(content.result.ToString());
        Console.WriteLine(deserializedCase);
        var actualModel = new ACaseModel
        {
            Title = content.result.title.ToString(),
        };

        return (response.StatusCode, deserializedCase, response.Content);
    }
}