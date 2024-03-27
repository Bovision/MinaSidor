using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Bvadmin.Interfaces;
using Core.Models;
using Core.DataCore;
namespace MinaSidor.Server.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class EstateController : ControllerBase
        {
        private IEstate _estate;
        public EstateController(IEstate estate)
            {
            _estate = estate;
            }   

        [HttpGet]
        public async Task<ActionResult<List<BostadViewModel>>> GetEstates(int AgentId)
            {
            return await _estate.getEstates(AgentId);
            }

        }
    }
