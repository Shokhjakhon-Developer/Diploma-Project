using API_models.Models;
using API_Services.Qase_Api.Case_service;
using API_Services.Qase_Api.Project_service;
using RestSharp;

namespace API_test_steps.Steps;

public class CaseCreationSteps
{
    private readonly CaseService _caseService;
    private readonly ProjectService _projectService;


    public CaseCreationSteps()
    {
        _caseService = new CaseService();
        _projectService = new ProjectService();
    }

    public void CreateCase(ProjectModel projectModel, CaseModel caseModel)
    {
        _projectService.CreateProject(projectModel);
        _caseService.CreateCase(caseModel, projectModel);
    }

    public RestResponse GetCaseByCode(ProjectModel model)
    {
        var response = _caseService.GetCaseByCode(model);
        return response;
    }

    public void CleanUp(ProjectModel model)
    {
        _projectService.DeleteProjectByCode(model);
    }
}