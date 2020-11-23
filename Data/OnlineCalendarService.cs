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

        public async Task<string> createUser(string username, string password)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsJsonAsync("/user", ""))
            {
                if (response.IsSuccessStatusCode)
                {
                    return "Success";
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        //public async Task<string> updateUser(User user) {}

        //public async Task<ArrayList<Event>> getEvents(int userID) {}
        //public async Task<string> createEvent(Event event) {}
        //public async Task<string> updateEvent(Event event) {}

        //public async Task<Invite> getInvites(int userID) {}
        //public async Task<string> invitePersonToEvent(String username, Event event) {}
        //public async Task<string> addPersonToEvent(int id, Event event) {}
        //public async Task<string> removePersonFromEvent(String username, Event event) {}
    }
}
