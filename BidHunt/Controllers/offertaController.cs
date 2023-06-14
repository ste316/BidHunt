﻿using BidHunt.Data;
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
        public IEnumerable<Offerta> GetAllOfferta() 
        {
            return _dbContext.offerte;
        }
        //GET
        [HttpGet("{id}")]
        public Offerta GetOffertaById(int id_offerta)
        {
            var offerta = _dbContext.offerte.FirstOrDefault(x => x.id_offerta == id_offerta);
            return offerta;
        }
        //POST
        [HttpPost]
        public void AggiungiOfferta([FromBody] Offerta offerta)
        {
            _dbContext.Add(offerta);
            _dbContext.SaveChanges();
        }
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
    }
}
