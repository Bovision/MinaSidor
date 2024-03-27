using Core.DataCore;
using Data;
using Microsoft.Data.SqlClient;
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

        public async Task<List<BostadViewModel>> getEstates(int UserId)
            {
            var res = await _applicationDbContext.BostadViewModel.Where(x => x.N_MAKLARID == UserId).ToListAsync(); 

            return res;
            }
        }
    }
