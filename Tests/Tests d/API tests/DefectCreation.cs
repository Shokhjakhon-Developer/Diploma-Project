using API_models.Data;
using API_models.Models;
using API_test_steps.Steps;
using NUnit.Framework;

namespace Tests.Tests_d.API_tests;

public class DefectCreationTest
{
    private DefectCreationSteps _defectCreationSteps;
    private ProjectModel _projectModel;
    private DefectModel _defectModel;

    [SetUp]
    public void SetUp()
    {
        _defectCreationSteps = new DefectCreationSteps();
        _projectModel = ApiProjectModelFactory.Model;
        _defectModel = ApiDefectModelFactory.Model;
    }

    [Test]
    public void TestDefectCreation()
    {
        _defectCreationSteps.CreateDefect(_projectModel,_defectModel);
        var response = _defectCreationSteps.GetCaseByCode(_projectModel);
        Console.WriteLine(response.Content);
    }

    [TearDown]
    public void TearDown()
    {
        
        _defectCreationSteps.CleanUp(_projectModel);
    }
}