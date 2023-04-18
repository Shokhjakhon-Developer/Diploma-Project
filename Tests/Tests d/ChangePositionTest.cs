using Models_and_Steps.Data;
using Models_and_Steps.Models;
using Models_and_Steps.Steps;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace Tests.Tests_d;

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
    public void TestChangingPosition()
    {
        UserProfileModel profile = UserProfileModelFactory.UserProfile1;

        _changePositionSteps.ChangePosition(profile.Position);
        var actualPosition = _changePositionSteps.GetActualPosition();
        var expected = profile.Position;

        Assert.That(actualPosition, Is.EqualTo(expected), "Position in profile settings is not changed.");
    }
}