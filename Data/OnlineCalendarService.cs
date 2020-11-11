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
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("user")) // Alter this when API is working
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
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsJsonAsync("/user", "change this"))
            {

            }
        }

        public async void updateUser(User user)
        {
            /*using (HttpResponseMessage response = await ApiHelper.ApiClient.PatchAsync("/user"))
            {

            }*/
        }
    }
}
