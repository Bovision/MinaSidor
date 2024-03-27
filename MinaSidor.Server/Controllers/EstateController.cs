using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Bvadmin.Interfaces;
using Core.Models;
namespace MinaSidor.Server.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class EstateController : ControllerBase
        {
        private IEstate _estate;

        [HttpGet]
        public async Task<ActionResult<List<int>>> GetEstates()
            {
            return await _estate.getEstates(34);
            }

        }
    }
