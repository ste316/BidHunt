using BidHunt.Data;
using BidHunt.Migrations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BidHunt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AstaController : ControllerBase
    {
        ApiDbContextcs _dbContext = new ApiDbContextcs();

        /*//GET
        [HttpGet]
        public IEnumerable<Asta> Get()
        {
            return _dbContext.Asta;
        }*/

        //GET
        [HttpGet("{id}")]
        public Asta GetAsta(int id) 
        {
            var asta = _dbContext.Asta.FirstOrDefault(x => x.Id == id);

            return asta;
        }

    }
}
