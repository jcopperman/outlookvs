﻿using System;
using TechTalk.SpecFlow;

namespace OutlookAddInSubjectAndBodyTests
{
    [Binding]
    public class OutlookAddInInsertTextInEmailBodySteps
    {
        [Then(@"the text ""(.*)"" is inserted into the email's body")]
public void ThenTheTextIsInsertedIntoTheEmailSBody(string p0)
{
    ScenarioContext.Current.Pending();
}
    }
}
