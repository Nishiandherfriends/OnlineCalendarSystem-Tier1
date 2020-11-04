using System.Collections.Generic;
using OnlineCalendarSystem_Tier1.Login;
namespace OnlineCalendarSystem_Tier1.Login{
    public interface IUser{
        User ValidateUser(string username, string password);
        void AddUser(int id ,string username, string password, int securityRole);
        List<User> getUsers();
        void RemoveUser(User toRemove);
    }
}