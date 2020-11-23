using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineCalendarSystem_Tier1.Login;
namespace OnlineCalendarSystem_Tier1.Login
{
    public interface IUser
    {
        users ValidateUser(string username, string password);
        Task<users>  AddUser(users user);
        Task<IList<users>> getUsers();
        Task RemoveUser(users toRemove);
    }
}