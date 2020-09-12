using NUnit.Framework;
using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace TfLAPITest.StepDefinitions
{
    [Binding]
    public class ReqResSteps
    {
        ListOfUsersDTO listOfUsersDTO;
        UpdateUserDTO updateUserDTO;
        GetUserDTO getUserDTO;
        CreateUserDTO createUserDTO;

        IRestResponse restResponse;

        [Given(@"I made a request to create a user")]
        public void GivenIMadeARequestToCreateAUser()
        {
            String payloadCreateUser = @"{
                                    ""name"": ""morpheus"",
                                    ""job"": ""leader""
                                }";

            createUserDTO = DTOHelper.createUser(payloadCreateUser);
        }
        
        [Given(@"I made a request to get an user with user id ""(.*)""")]
        public void GivenIMadeARequestToGetAnUserWithUserId(int userId)
        {
            var dtoHelper = new TfLAPITest.DTOHelper();
            getUserDTO = dtoHelper.GetUser("/api/users/"+userId);
        }

        [Given(@"I made a request to get an user with invlid user id ""(.*)""")]
        public void GivenIMadeARequestToGetAnUserWithInvlidUserId(int userId)
        {
            var dtoHelper = new TfLAPITest.DTOHelper();
            restResponse = dtoHelper.GetInvildUser("/api/users/" + userId);
        }


        [Given(@"I made a request to get all users list")]
        public void GivenIMadeARequestToGetAllUsersList()
        {
            var dtoHelper = new TfLAPITest.DTOHelper();
            listOfUsersDTO = dtoHelper.GetUsers("/api/users/");
        }
        
        [Given(@"I made a request to update the user")]
        public void GivenIMadeARequestToUpdateTheUser()
        {
            String payloadCreateUser = @"{
                                    ""name"": ""pradeep"",
                                    ""job"": ""leader""
                                }";
            String payloadUpdate = @"{
                                    ""name"": ""name.updated"",
                                    ""job"": ""job.updated""
                                }";
            var dtoHelper = new TfLAPITest.DTOHelper();
            createUserDTO = DTOHelper.createUser(payloadCreateUser);
            updateUserDTO = dtoHelper.UpdateUser("/api/users/" + createUserDTO.Id, payloadUpdate);
        }
        
      
        [Then(@"the new user should be created")]
        public void ThenTheNewUserShouldBeCreated()
        {
            Assert.NotNull(createUserDTO.Id);
            Assert.AreEqual("morpheus", createUserDTO.Name);
            Assert.AreEqual("leader", createUserDTO.Job);
        }
        
        [Then(@"the response should return all the user details")]
        public void ThenTheResponseShouldReturnAllTheUserDetails()
        {
            Assert.AreEqual(2, getUserDTO.Data.Id);
            Assert.AreEqual("Janet", getUserDTO.Data.FirstName);
            Assert.AreEqual("janet.weaver@reqres.in", getUserDTO.Data.Email);
            Assert.AreEqual("StatusCode Weekly", getUserDTO.Ad.Company);
        }
        
        [Then(@"the response should return all the available users")]
        public void ThenTheResponseShouldReturnAllTheAvailableUsers()
        {
            Assert.AreEqual(1, listOfUsersDTO.Page);
            Assert.AreEqual(2, listOfUsersDTO.TotalPages);
            Assert.AreEqual(12, listOfUsersDTO.Total);
        }
        
        [Then(@"the user name should be updated")]
        public void ThenTheUserNameShouldBeUpdated()
        {
            Assert.AreEqual("name.updated", updateUserDTO.Name);
            Assert.AreEqual("job.updated", updateUserDTO.Job);
        }
        
        [Then(@"the response code should be Not Found")]
        public void ThenTheResponseCodeShouldBeNotFound()
        {
            Assert.AreEqual(restResponse.StatusCode, HttpStatusCode.NotFound);
        }
    }
}
