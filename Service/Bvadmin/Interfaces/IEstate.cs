using Core.DataCore;
using Core.Models;
namespace Service.Bvadmin.Interfaces
{
    public interface IEstate
        {
        Task<List<BostadViewModel>> getEstates(int UserId);
        }
    }