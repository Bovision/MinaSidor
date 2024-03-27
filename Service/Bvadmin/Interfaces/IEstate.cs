using Core.Models;
namespace Service.Bvadmin.Interfaces
{
    public interface IEstate
        {
        Task<List<int>> getEstates(int UserId);
        }
    }