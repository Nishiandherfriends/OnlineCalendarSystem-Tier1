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
        private List<users> users;
        private string userFile = "users.json";
        protected readonly ApplicationDbContext _dbContext;

        public UserService(ApplicationDbContext _db){
            string content = File.ReadAllText(userFile);
            users = JsonSerializer.Deserialize<List<users>>(content);
            _dbContext = _db;
        }
        private void writeUserToFile(List<users> user){
            string userAsJson = JsonSerializer.Serialize(user);
            File.WriteAllText(userFile, userAsJson);
        }

        public users ValidateUser(string username, string password)
        {
            users first =  users.FirstOrDefault(user => user.username.Equals(username));
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

        public async Task<users> AddUser(users user)
        {
            users.Add(user);
            writeUserToFile(users);
            return user;
        }

        public async Task<IList<users>> getUsers()
        {
            return users;
        }

        public async Task RemoveUser(users toRemove)
        {
            users toBeRemoved = users.First(t => t.username == toRemove.username);
            users.Remove(toRemove);
            writeUserToFile(users);
        }
        public List<users> displayUsers()
        {
            return _dbContext.users.ToList();
        }
    }
}