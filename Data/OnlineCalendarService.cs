using OnlineCalendarSystem_Tier1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using OnlineCalendarSystem_Tier1.Login;
namespace OnlineCalendarSystem_Tier1.Data
{
    public class OnlineCalendarService
    {
        public async Task<User> login(string username, string password)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("/user"))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<User>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async void createUser(string username, string password)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsJsonAsync("/user", ""))
            {

            }
        }

        public async void updateUser(User user)
        {
            /*using (HttpResponseMessage response = await ApiHelper.ApiClient.PatchAsync("/user"))
            {

            }*/
        }

        /* This is just a model method to know how stuff should be done
         
        public async Task loadInfo()
        {
            string url = "";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    // Class class = await reponse.Content.ReadAsAsync<Class>();
                    return null; //return the information
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        */
    }
}
