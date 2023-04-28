using System.Net;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace Tests.Tests.API_Tests;

public class CreateProjectTest : BaseTest
{
    [Test]
    [AllureDescription("Creating a project using api.")]
    [Category("API Test")]
    [AllureStory("Checking if we can create a project using api.")]
    public void TestCreateProject()
    {
        var (statusCodeGetProject, actualModel, getProjectResponseContent) =
            ProjectService.GetProjectByCode(ProjectModel);

        Assert.That(statusCodeGetProject, Is.EqualTo(HttpStatusCode.OK), $"{getProjectResponseContent}");
        Assert.That(actualModel, Is.EqualTo(ProjectModel), "Actual project model is not the same as expected one");
    }
}