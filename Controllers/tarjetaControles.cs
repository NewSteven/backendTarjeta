﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backendTarjeta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tarjetaControles : ControllerBase
    {
        private readonly aplicationDBContext _dbContext;

        //creo controlador
        public tarjetaControles( aplicationDBContext context )
        {
            _dbContext = context;
        }

        // GET: api/<tarjetaControles>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // GET api/<tarjetaControles>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<tarjetaControles>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<tarjetaControles>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<tarjetaControles>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
