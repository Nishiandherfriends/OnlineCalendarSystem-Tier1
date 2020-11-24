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
        // This method will return a Task<User> that can be parsed into a User
        // You just need to copy this " User user = await login(username, password); "
        // The user class will already have an ID and a Security level
        public async Task<User> login(string username, string password)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("/user?username=" + username + "&password=" + password))
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

        // This method will return a Task<string> that can be parsed into a string if the request is successful
        // You just need to copy this " String string = await createUser(username, password); "
        // The user class will always have a level two security exept for the admin which has already been created
        public async Task<string> createUser(string username, string password)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsJsonAsync("/user?username=" + username + "&password=" + password, ""))
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

        // This method will return a Task<string> that can be parsed into a string if the request is successful
        // You just need to copy this " String string = await updateUser(username, password, id); "
        // This method should only alter the user details from the user that's logged in
        // You should put the details even if you don't want to change them
        // The id can't change because it'll be used to find the user in the database
        public async Task<string> updateUser(string username, string password, int id) 
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsJsonAsync("/user?username=" + username + "&password=" + password + "&id=" + id, ""))
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

        // This method will return all Events for a given user when it's id is inputed
        // You just need to copy this " List<Event> eventList = await getEvents(userID); "
        // You should only allow the user in cache to use it's own id
        // I'm not sure if the List and ArrayList will have incompatiblities text me if it doesn't work - Bernardo
        public async Task<List<Event>> getEvents(int userID) 
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("/user?userID=" + userID))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<Event>>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        //public async Task<string> createEvent(Event event) { return null; }
        //public async Task<string> updateEvent(Event event) { return null; }


        //public async Task<Invite> getInvites(int userID) { return null; }
        //public async Task<string> invitePersonToEvent(String username, Event event) { return null; }
        //public async Task<string> addPersonToEvent(int id, Event event) { return null; }
        //public async Task<string> removePersonFromEvent(String username, Event event) { return null; }
    }
}
