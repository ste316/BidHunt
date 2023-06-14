using BidHunt.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BidHunt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class offertaController : ControllerBase
    {
        ApiDbContextcs _dbContext = new ApiDbContextcs();

        //GET
        [HttpGet]
        public IEnumerable<Offerta> Get() 
        {
            return _dbContext.offerte;
        }
        //GET
        [HttpGet("{id_offerta}")]
        public Offerta GetOfferta(int id_offerta)
        {
            var offerta = _dbContext.offerte.FirstOrDefault(x => x.id_offerta == id_offerta)
            return offerta;
        }
    }
}
