using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace TfLAPITest
{
    public class DTOHelper
    {
        public ListOfUsersDTO GetUsers(string endpoint)
        {
            var user = new APIHelper<ListOfUsersDTO>();
            var url = user.SetUrl(endpoint);
            var request = user.CreateGetRequest();
            var response = user.GetResponse(url, request);
            ListOfUsersDTO content = user.GetContent<ListOfUsersDTO>(response);
           
            return content;
        }

        public GetUserDTO GetUser(string endpoint)
        {
            var user = new APIHelper<ListOfUsersDTO>();
            var url = user.SetUrl(endpoint);
            var request = user.CreateGetRequest();
            var response = user.GetResponse(url, request);
            GetUserDTO content = user.GetContent<GetUserDTO>(response);

            return content;
        }

        public UpdateUserDTO UpdateUser(string endpoint, String payload)
        {
            var user = new APIHelper<ListOfUsersDTO>();
            var url = user.SetUrl(endpoint);
            var request = user.CreatePutRequest(payload);
            var response = user.GetResponse(url, request);
            UpdateUserDTO content = user.GetContent<UpdateUserDTO>(response);

            return content;
        }

    }
}
