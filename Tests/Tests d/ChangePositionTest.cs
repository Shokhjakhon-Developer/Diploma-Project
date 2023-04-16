using Models_and_Steps.Steps;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace Tests.Tests_d;

[AllureFeature("Profile settings feature")]
public class ChangePositionTest : BaseTest
{
    private ChangePositionSteps _changePositionSteps;

    [SetUp]
    public void SetUpTest()
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
        _changePositionSteps.ChangePosition();

        Assert.That(_changePositionSteps.IsPositionChanged(), Is.True, "Position in profile settings is not changed.");
    }
}