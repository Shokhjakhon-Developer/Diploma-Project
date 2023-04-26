using Models_and_Steps.Data;
using Models_and_Steps.Models;
using Models_and_Steps.Steps;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace Tests.Tests.UI_Tests;

[AllureFeature("Profile settings feature")]
public class ChangePositionTest : BaseTest
{
    private ChangePositionSteps _changePositionSteps;

    [SetUp]
    public void TestSetUp()
    {
        _changePositionSteps = new ChangePositionSteps(Driver);
    }

    [Test]
    [AllureDescription("Changing position in profile settings.")]
    [Category("Acceptance Test")]
    [AllureStory("Checking if we can change the position in out account.")]
    [AllureSeverity]
    public void TestChangePosition()
    {
        UserProfileModel profileModel = UserProfileModelFactory.UserProfile1;

        _changePositionSteps.ChangePositionAndName(profileModel);
        var actualModel = _changePositionSteps.GetActualModel();
        var expectedModel = profileModel;

        Assert.That(actualModel, Is.EqualTo(expectedModel), "Position or name in profile settings is not changed.");
    }
}