using BidHunt.Data;
using BidHunt.Migrations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BidHunt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AstaController : ControllerBase
    {
        ApiDbContextcs _dbContext = new ApiDbContextcs();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Asta);
        }

        /*//GET
        [HttpGet]
        public IEnumerable<Asta> Get()
        {
            return _dbContext.Asta;
        }*/

        //GET
        [HttpGet("{id}")]
        public IActionResult GetAsta(int id)
        {
            var asta = _dbContext.Asta.FirstOrDefault(x => x.Id == id);

            return Ok(asta);
        }

        [HttpPost]
        [Authorize]
        public IActionResult AggiungiAsta([FromBody] Asta asta
            )
        {
            _dbContext.Add(asta);
            _dbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatedAsta(int id, [FromBody] Asta updatedAsta)
        {
            var asta = _dbContext.Asta.Find(id);
            if (asta == null)
            {
                return BadRequest("Asta non aggiornabile!");
            }
            else
            {
                asta.DataInizio = updatedAsta.DataInizio;
                asta.DataFine = updatedAsta.DataFine;
                asta.Nome_prodotto = updatedAsta.Nome_prodotto;
                asta.Descrizione_prodotto = updatedAsta.Descrizione_prodotto;
                asta.Prezzo_iniziale_prod = updatedAsta.Prezzo_iniziale_prod;

                _dbContext.SaveChanges();
                return Ok();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAsta(int id)
        {
            var asta = _dbContext.Asta.Find(id);
            if (asta == null)
            {
                return BadRequest(new { errorCode = 4, errorDescription = "Asta non trovato" });
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
