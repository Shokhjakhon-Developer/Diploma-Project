using API_models.Models;
using API_models.Views;
using RestSharp;
using Utilities.Utilities;

namespace API_Services.QaseApi.CaseService;

public class CaseService : BaseService
{
    public void CreateCase(ACaseModel caseModel, AProjectModel projectModel)
    {
        var request = new RestRequest(BaseUrl + "/case/{code}", Method.Post);
        request.AddUrlSegment("code", projectModel.Code.ToUpper());
        request.AddJsonBody(caseModel);
        RClient.Execute(request);
    }

    public GeneralViewModel GetCaseByCode(AProjectModel model)
    {
        var request = new RestRequest(BaseUrl + "/case/{code}/1");
        request.AddUrlSegment("code", model.Code.ToUpper());
        var response = RClient.Execute(request);
        var content = Helper.GetJsonObject(response.Content);

        var actualViewModel = new GeneralViewModel
        {
            StatusCode = response.StatusCode,
            Model = new ACaseModel
            {
                Title = content.result.title.ToString(),
            }
        };
        return actualViewModel;
    }
}