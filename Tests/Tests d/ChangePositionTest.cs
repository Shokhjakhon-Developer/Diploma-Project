using Models_and_Steps.Steps;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace Tests.Tests_d;

[AllureFeature("Profile Settings Feature")]
public class ChangePositionTest : BaseTest
{
    [Test]
    [Obsolete("Obsolete")]
    [AllureDescription("Changing position in profile settings.")]
    [Category("Acceptance Test")]
    [AllureStory("Checking if we can change the position in out account.")]
    [AllureSeverity]
    public void TestChangingPosition()
    {
        var changePositionSteps = new ChangePositionSteps();

        Allure.WrapInStep(() => { changePositionSteps.Login(); }, "Logging in to the website");

        Allure.WrapInStep(() => { Assert.That(changePositionSteps.AreWeLoggedIn()); },
            "Checking if we are logged in");

        Allure.WrapInStep(() => { changePositionSteps.ChangePosition(); }, "Changing position in profile settings");

        Allure.WrapInStep(() => { Assert.That(changePositionSteps.IsPositionChanged()); },
            "Checking if the position is changed");
    }
}