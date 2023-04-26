using API_models.Models;
using API_models.Views;
using RestSharp;
using Utilities.Utilities;

namespace API_Services.QaseApi.DefectService;

public class DefectService : BaseService
{
    public void CreateDefect(ADefectModel model, string code)
    {
        var request = new RestRequest(BaseUrl + "/defect/{code}", Method.Post);
        request.AddUrlSegment("code", code.ToUpper());
        request.AddJsonBody(model);
        RClient.Execute(request);
    }

    public GeneralViewModel GetDefectByCode(string code)
    {
        var request = new RestRequest(BaseUrl + "/defect/{code}/1");
        request.AddUrlSegment("code", code.ToUpper());
        var response = RClient.Execute(request);
        var content = Helper.GetJsonObject(response.Content);

        var actualViewModel = new GeneralViewModel
        {
            StatusCode = response.StatusCode,
            Model = new ADefectModel
            {
                ActualResult = content.result.actual_result.ToString(),
                Title = content.result.title.ToString()
            }
        };

        return actualViewModel;
    }
}