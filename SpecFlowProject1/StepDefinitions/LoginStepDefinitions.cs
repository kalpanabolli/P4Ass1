namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class LoginStepDefinations
    {
        [Given(@"the user is on the login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            // Navigate to the login page or perform setup actions.
        }

        [When(@"the user enters valid credentials \(username ""(.*)"" and password ""(.*)""\)")]
        public void WhenTheUserEntersValidCredentials(string username, string password)
        {
            // Enter valid credentials in the login form.
        }

        [When(@"clicks the login button")]
        public void WhenClicksTheLoginButton()
        {
            // Click the login button.
        }

        [Then(@"the user should be redirected to the dashboard")]
        public void ThenTheUserShouldBeRedirectedToTheDashboard()
        {
            // Validate that the user is on the dashboard page.
        }

        [When(@"the user enters invalid credentials \(username ""(.*)"" and password ""(.*)""\)")]
        public void WhenTheUserEntersInvalidCredentials(string username, string password)
        {
            // Enter invalid credentials in the login form.
        }

        [Then(@"an error message should be displayed")]
        public void ThenAnErrorMessageShouldBeDisplayed()
        {
            // Validate that an error message is displayed.
        }
    }
}