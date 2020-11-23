using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineCalendarSystem_Tier1.Login;
using OnlineCalendarSystem_Tier1.Models;

namespace OnlineCalendarSystem_Tier1.Login
{
    public interface IUser
    {
        User ValidateUser(string username, string password);
        Task<User>  AddUser(User user);
        Task<IList<User>> getUsers();
        Task RemoveUser(User toRemove);
    }
}