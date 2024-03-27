using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Bvadmin.Services
    {
    public class EstateService: Interfaces.IEstate  
        {
        public readonly ApplicationDbContext _applicationDbContext;


        public EstateService(ApplicationDbContext applicationDbContext)
            {
            _applicationDbContext = applicationDbContext;
            }

        public Task<List<int>> getEstates(int UserId)
            {
           var res= _applicationDbContext.Database.ExecuteSqlRaw("SELECT L_OBJEKTNR FROM Bostad WHERE N_MAKLARID = {0}", UserId);
            return null;

            }
        }
    }
