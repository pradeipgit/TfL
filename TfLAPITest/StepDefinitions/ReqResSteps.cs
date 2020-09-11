using System;
using TechTalk.SpecFlow;

namespace TfLAPITest.StepDefinitions
{
    [Binding]
    public class ReqResSteps
    {
        [Given(@"I have an end point for POST user request")]
        public void GivenIHaveAnEndPointForPOSTUserRequest()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have an end point for GET user request")]
        public void GivenIHaveAnEndPointForGETUserRequest()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have an end point for GET list of users")]
        public void GivenIHaveAnEndPointForGETListOfUsers()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have an end point for PUT request")]
        public void GivenIHaveAnEndPointForPUTRequest()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I made a request to create a user with name ""(.*)"" and job ""(.*)""")]
        public void WhenIMadeARequestToCreateAUserWithNameAndJob(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I made a request to get an user with user id ""(.*)""")]
        public void WhenIMadeARequestToGetAnUserWithUserId(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I made a request to get all users list")]
        public void WhenIMadeARequestToGetAllUsersList()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I made a request to update the user name to ""(.*)"" for user id ""(.*)""")]
        public void WhenIMadeARequestToUpdateTheUserNameToForUserId(string p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the response should be successful")]
        public void ThenTheResponseShouldBeSuccessful()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the new user should be created")]
        public void ThenTheNewUserShouldBeCreated()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the response should return all the user details")]
        public void ThenTheResponseShouldReturnAllTheUserDetails()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the response should return all the available users")]
        public void ThenTheResponseShouldReturnAllTheAvailableUsers()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the user name should be updated")]
        public void ThenTheUserNameShouldBeUpdated()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the response code should be ""(.*)""")]
        public void ThenTheResponseCodeShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
