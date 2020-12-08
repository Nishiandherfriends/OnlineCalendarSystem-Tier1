using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using OnlineCalendarSystem_Tier1.Models;

namespace OnlineCalendarSystem_Tier1.Login
{
    public class UserService : IUser
    {
        private List<User> users;
        private string userFile = "users.json";

        public UserService(){
            string content = File.ReadAllText(userFile);
            users = JsonSerializer.Deserialize<List<User>>(content);
        }
        private void writeUserToFile(List<User> user){
            string userAsJson = JsonSerializer.Serialize(user);
            File.WriteAllText(userFile, userAsJson);
        }

        public async Task<User> ValidateUser(string username, string password)
        {
            User first =  users.FirstOrDefault(user => user.username.Equals(username));
            if (first == null)
            {
                throw new Exception("user not found");
            }

            if (!first.password.Equals(password))
            {
                throw new Exception("Password is incorrect");
            }

            return first;
        }

        public async Task<User> AddUser(string username, string password)
        {
            User user = new User(username, password);
            users.Add(user);
            writeUserToFile(users);
            return user;
        }

        public async Task<IList<User>> getUsers()
        {
            return users;
        }

        public async Task RemoveUser(User toRemove)
        {
            User toBeRemoved = users.First(t => t.username == toRemove.username);
            users.Remove(toRemove);
            writeUserToFile(users);
        }
    }
}