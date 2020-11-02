using OnlineCalendarSystem_Tier1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OnlineCalendarSystem_Tier1.Data
{
    public class OnlineCalendarService
    {
        public async Task<User> login(string username, string password)
        {
            //Task<User> users;
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("Adults")) // Alter this when API is working
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

        public void createUser(string username, string password)
        {

        }
    }
}
