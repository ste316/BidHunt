﻿using BidHunt.Data;
using BidHunt.Migrations;
using BidHunt.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BidHunt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ApiDbContextcs _dbContext = new ApiDbContextcs();

        private IConfiguration _config;
        public UserController(IConfiguration _config) 
        {
            _config = _config;
        }

        [HttpPost("[action]")]
        //[Authorize]
        public IActionResult Login([FromBody] User user)
        {

            var userAttuale = _dbContext.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);

            if (userAttuale == null)
            {
                return NotFound();
            }
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Key"]));
            var credenziali = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);//hash per la chiave
            var claims = new[]
            {
                new Claim(ClaimTypes.Email, user.Email)
            };

            var token = new JwtSecurityToken(issuer: _config["JWT:Issuer"], audience: _config["JWT:Audience"], claims = claims,
                expires: DateTime.Now.AddMinutes(20),
                signingCredentials: credenziali);


            var jwt = new JwtSecurityTokenHandler().WriteToken(token); // converte il token in una stringa

            return Ok(jwt);
            //return Ok("Loggato");
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Id == id);

            return Ok(user);
        }

        [HttpPost]
       //[Authorize]
        public IActionResult AggiungiUsers([FromBody] User user
           )
        {
            _dbContext.Add(user);
            _dbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatedUsers(int id, [FromBody] User updatedUser)
        {
            var user = _dbContext.Users.Find(id);
            if (user == null)
            {
                return BadRequest("User non aggiornabile!");
            }
            else
            {
                user.Nome = updatedUser.Nome;
                user.Cognome = updatedUser.Cognome;
                user.DataNascita = updatedUser.DataNascita;
                user.Email = updatedUser.Email;
                user.Password = updatedUser.Password;
                user.PayPal_mail = updatedUser.PayPal_mail;
               _dbContext.SaveChanges();
                return Ok();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = _dbContext.Users.Find(id);
            if (user == null)
            {
                return BadRequest(new { errorCode = 4, errorDescription = "User non trovato" });
            }
            else
            {
                _dbContext.Remove(user);
                _dbContext.SaveChanges();
                return Ok();
            }

        }
    }
}
