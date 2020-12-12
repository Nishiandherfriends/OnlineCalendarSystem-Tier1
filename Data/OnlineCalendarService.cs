using OnlineCalendarSystem_Tier1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using OnlineCalendarSystem_Tier1.Login;
using System.Text;

namespace OnlineCalendarSystem_Tier1.Data
{
    /// <summary>
    /// This is class is used for communicating with the second tier.
    /// It has all the methods to communicate with the Web Service.
    /// </summary>
    public class OnlineCalendarService
    {
        /// <summary>
        /// Allows the user to login.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <returns>A user object if the login is successful.</returns>
        public async Task<User> login(string username, string password)
        {
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().GetAsync("/user?username=" + username + "&password=" + password))
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

        /// <summary>
        /// Allows the user to create an account.
        /// </summary>
        /// <param name="username">The new username of the user.</param>
        /// <param name="password">The new password of the user.</param>
        /// <returns>A string with a success or error message.</returns>
        public static async Task<string> createUser(string username, string password)
        {
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().PostAsJsonAsync("/user?username=" + username + "&password=" + password, ""))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<string>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        /// <summary>
        /// Allows the user to change the details of its own account.
        /// </summary>
        /// <param name="username">The new/old username depending on the wishes of the user.</param>
        /// <param name="password">The new/old password depending on the wishes of the user.</param>
        /// <param name="id">The id of the user that is changing its details.</param>
        /// <returns>A string with a success or error message.</returns>
        public async Task<string> updateUser(string username, string password, int id) 
        {
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().PutAsJsonAsync("/user?username=" + username + "&password=" + password + "&id=" + id, ""))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<string>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        /// <summary>
        /// Deletes the user.
        /// </summary> 
        /// <param name="userID">The id of the user that is going to be deleted.</param>
        /// <returns>A string with a success or error message.</returns>
        public async Task<string> deleteUser(int userID)
        {
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().DeleteAsync("/user?userID=" + userID))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<string>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        /// <summary>
        /// Gets the events that the user is participating in.
        /// </summary>
        /// <param name="userID">The id of the user.</param>
        /// <returns>A list of events.</returns>
        public async Task<List<Event>> getEvents(int userID) 
        {
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().GetAsync("/event?userID=" + userID))
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

        /// <summary>
        /// Allows the user to create an event.
        /// </summary>
        /// <param name="userID">The username of the user creating the event.</param>
        /// <param name="evt">The event that is going to be created (the id does not matter because it will be overwritten by the database.)</param>
        /// <returns>A string with a success or error message.</returns>
        public async Task<string> createEvent(int userID, Event evt) 
        {
            var jsonEvent = Newtonsoft.Json.JsonConvert.SerializeObject(evt);
            var eventToSend = new StringContent(jsonEvent, Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().PostAsJsonAsync("/event?userID=" + userID + "&event=" + eventToSend, ""))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<string>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        /// <summary>
        /// Allows the user to update an event (the id needs to be the same so the correct user is overwritten and no errors happen in the database).
        /// </summary>
        /// <param name="evt">The new event object that is going to overwrite the one on the database.</param>
        /// <returns>A string with a success or error message.</returns>
        public async Task<string> updateEvent(Event evt) 
        {
            var jsonEvent = Newtonsoft.Json.JsonConvert.SerializeObject(evt);
            var eventToSend = new StringContent(jsonEvent, Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().PutAsJsonAsync("/event?event=" + eventToSend, ""))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<string>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        /// <summary>
        /// Allows the user to delete an event (in which he is participating).
        /// </summary>
        /// <param name="eventID">The id of the event that is going to be deleted.</param>
        /// <returns>A string with a success or error message.</returns>
        public async Task<string> deleteEvent(int eventID)
        {
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().DeleteAsync("/event?eventID=" + eventID))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<string>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        /// <summary>
        /// Gets all the participants in a certain event.
        /// </summary>
        /// <param name="eventID">The id of the event all participants are participating.</param>
        /// <returns>An ArrayList with all the participants usernames.</returns>
        public async Task<List<string>> getParticipants(int eventID) 
        {
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().GetAsync("/event2?eventID=" + eventID))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<string>>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        /// <summary>
        /// Allows the user to delete someone from an event.
        /// </summary>
        /// <param name="username">The username of the user that is going to be deleted from the event.</param>
        /// <param name="eventID">The id of the event.</param>
        /// <returns>A string with a success or error message.</returns>
        public async Task<string> removePersonFromEvent(String username, int eventID)
        {
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().DeleteAsync("/event2?username=" + username + "&eventID=" + eventID))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<string>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        /// <summary>
        /// Gets the invites to the events the user was invited to.
        /// </summary>
        /// <param name="userID">The id of the user.</param>
        /// <returns>A list of invites.</returns>
        public async Task<Invite> getInvites(int userID)
        {
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().GetAsync("/invite?userID=" + userID))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<Invite>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        /// <summary>
        /// Allows the user to invite someone to an event.
        /// </summary>
        /// <param name="userInvitedUsername">The username of the user that is being invited.</param>
        /// <param name="userInvitingID">The id of the user that is inviting the other one.</param>
        /// <param name="eventID">The id of the event.</param>
        /// <returns>A string with a success or error message.</returns>
        public async Task<string> invitePersonToEvent(String userInvitedUsername, int userInvitingID, int eventID)
        {
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().PostAsJsonAsync("/invite?userInvitedUsername=" + userInvitedUsername + "&userInvitingID" + userInvitingID + "&eventID=" + eventID, ""))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<string>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        /// <summary>
        /// Adds the person to the event after they accept the invite.
        /// </summary>
        /// <param name="id">The id of the user that accepted the invite.</param>
        /// <param name="eventID">The id of the event.</param>
        /// <returns>A string with a success or error message.</returns>
        public async Task<string> addPersonToEvent(int id, int eventID)
        {
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().PutAsJsonAsync("/invite?id=" + id + "&eventID=" + eventID, ""))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<string>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        /// <summary>
        /// Deletes an invite.
        /// </summary>
        /// <param name="userID">The id of the user that was invited.</param>
        /// <param name="eventID">The id of the event to which the user was invited.</param>
        /// <returns>A string with a success or error message.</returns>
        public async Task<string> deleteInvite(int userID, int eventID)
        {
            using (HttpResponseMessage response = await ApiHelper.GetApiClient().DeleteAsync("/invite?userID=" + userID + "&eventID=" + eventID))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<string>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
