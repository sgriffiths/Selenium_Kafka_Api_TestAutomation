using System;
using RestSharp;
using TechTalk.SpecFlow;

namespace Web_Kafka_API_Automation.Features.Steps
{
    [Binding]
    public class CreateUserViaApiSteps
    {
        [Given(@"I request a new user from the account service")]
        public void GivenIRequestANewUserFromTheAccountService()
        {
            var randomUsername = Guid.NewGuid().ToString();
            var client = new RestClient("http://services.uat.prod.sbet.com.au/account/v2/Account");

            var request = new RestRequest("http://services.uat.prod.sbet.com.au/account/v2/Account", Method.POST);
            request.AddParameter("username", randomUsername);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);
            var content = response.Content;

            

            //IRestResponse<Person> response2 = client.Execute<Person>(request);
            //var name = response2.Data;

        }

        [Then(@"A new user will be returned")]
        public void ThenANewUserWillBeReturned()
        {
            ScenarioContext.Current.Pending();
        }
    }

    //public class Person
    //{
    //}
}
