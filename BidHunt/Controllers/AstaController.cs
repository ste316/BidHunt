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

        [HttpPost]
        public void AggiungiAsta([FromBody] Asta asta) 
        {
            _dbContext.Add(asta);
            _dbContext.SaveChanges();
        }

        [HttpPut("{id}")]
        public void UpdateAsta(int id, [FromBody] Asta updateAsta) 
        {
            var asta = _dbContext.Asta.Find(id);
            if (asta != null)
            {
                asta.TempoRimanente = updateAsta.TempoRimanente;
                
            }
            _dbContext.SaveChanges();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAsta(int id) 
        {
            var asta = _dbContext.Asta.Find(id);
            if (asta == null) 
            {
                return BadRequest(new { errorCode=4, errorDescription= "Asta non trovata!"});
            }
            else 
            {
                _dbContext.Remove(asta);
                _dbContext.SaveChanges();
                return Ok();
            }
        }
    }
}
