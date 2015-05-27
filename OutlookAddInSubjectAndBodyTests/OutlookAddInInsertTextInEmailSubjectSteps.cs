using System;
using TechTalk.SpecFlow;

namespace OutlookAddInSubjectAndBodyTests
{
    [Binding]
    public class OutlookAddInInsertTextInEmailSubjectSteps
    {
        [Given(@"Outlook is running")]
public void GivenOutlookIsRunning()
{
    ScenarioContext.Current.Pending();
}

        [Given(@"I compose a new email")]
public void GivenIComposeANewEmail()
{
    ScenarioContext.Current.Pending();
}

        [When(@"I click send")]
public void WhenIClickSend()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the text ""(.*)"" is inserted into the email's subject")]
public void ThenTheTextIsInsertedIntoTheEmailSSubject(string p0)
{
    ScenarioContext.Current.Pending();
}
    }
}
