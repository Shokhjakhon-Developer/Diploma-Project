using API_models.Models;
using API_Services.Qase_Api.Project_service;
using RestSharp;

namespace API_test_steps.Steps;

public class ApiProjectCreationSteps
{
    private readonly ProjectService _projectService;

    public ApiProjectCreationSteps()
    {
        _projectService = new ProjectService();
    }

    public void CreateProject(ProjectModel model)
    {
        _projectService.CreateProject(model);
    }

    public RestResponse GetProjectByCode(ProjectModel model)
    {
        var response = _projectService.GetProjectByCode(model);
        return response;
    }

    public void DeleteProjectByCode(ProjectModel model)
    {
        _projectService.DeleteProjectByCode(model);
    }
    
}