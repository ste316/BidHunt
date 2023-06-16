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
       
        /*
        //GET
        [HttpGet]
        public IEnumerable<Offerta> GetAllOfferta() 
        {
            return _dbContext.offerte;
        }*/

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.offerte);
        }
        /*
        //GET
        [HttpGet("{id}")]
        public Offerta GetOffertaById(int id_offerta)
        {
            var offerta = _dbContext.offerte.FirstOrDefault(x => x.id_offerta == id_offerta);
            return offerta;
        }
        */

        [HttpGet("{id}")]
        public IActionResult GetOfferta(int id)
        {
            var offerta = _dbContext.offerte.FirstOrDefault(x => x.id_offerta == id);

            return Ok(offerta);
        }

        /*
        //POST
        [HttpPost]
        public void AggiungiOfferta([FromBody] Offerta offerta)
        {
            _dbContext.Add(offerta);
            _dbContext.SaveChanges();
        }
        */

        [HttpPost]
        //[Authorize]
        public IActionResult AggiungiOfferta([FromBody] Offerta offerta
            )
        {
            _dbContext.Add(offerta);
            _dbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }
        /*
        //UPDATE
        [HttpPut("{id}")]
        public void UpdateOfferta(int id, [FromBody] Offerta updatedOfferta)
        {
            var offerta = _dbContext.offerte.Find(id);
            if (offerta != null) 
            {
                offerta.offerta = updatedOfferta.offerta;

            }
            _dbContext.SaveChanges();
        }
        */

        [HttpPut("{id}")]
        public IActionResult UpdatedOfferta(int id, [FromBody] Offerta updatedOfferta)
        {
           var offerta = _dbContext.offerte.Find(id);
            if (offerta == null)
            {
                return BadRequest("Offerta non aggiornabile!");
            }
                else
            {
                offerta.offerta = updatedOfferta.offerta;
                _dbContext.SaveChanges();
                return Ok();
            }
        }
        /*
        //DELETE
        [HttpDelete("{id}")]
        public IActionResult DeleteOfferta(int id)
        {
            var offerta = _dbContext.offerte.Find(id);
            if(offerta == null)
            {
                return BadRequest(new { errorCode = 4, errorDescription = "Offerta non trovata"});

            }
            else
            {
                _dbContext.Remove(offerta);
                _dbContext.SaveChanges();
                return Ok();
            }
        */

        [HttpDelete("{id}")]
        public IActionResult DeleteOfferta(int id)
        {
            var offerta = _dbContext.offerte.Find(id);
            if (offerta == null)
            {
                return BadRequest(new { errorCode = 4, errorDescription = "Offerta non trovato" });
            }
            else
            {
                _dbContext.Remove(offerta);
                _dbContext.SaveChanges();
                return Ok();
            }

        }
    }
}
