using API_models.Models;
using API_Services.Qase_Api.Defect_service;
using API_Services.Qase_Api.Project_service;
using RestSharp;

namespace API_test_steps.Steps;

public class DefectCreationSteps
{
    private readonly ProjectService _projectService;
    private readonly DefectService _defectService;


    public DefectCreationSteps()
    {
        _defectService = new DefectService();
        _projectService = new ProjectService();
    }

    public void CreateDefect(ProjectModel projectModel, DefectModel defectModel)
    {
        _projectService.CreateProject(projectModel);
        _defectService.CreateDefect(defectModel, projectModel.Code.ToUpper());
    }

    public RestResponse GetCaseByCode(ProjectModel model)
    {
        var response = _defectService.FindDefectByCode(model.Code.ToUpper());
        return response;
    }

    public void CleanUp(ProjectModel model)
    {
        _projectService.DeleteProjectByCode(model);
    }
}