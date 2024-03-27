
using Core.DataCore;
using MinaSidor.Server.Models;

namespace Service.UserModel
{
    public interface IUserModel
    {
        public Task<Customer> GetfullUser(int UserId);
    }
}
