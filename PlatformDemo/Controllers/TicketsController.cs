using Microsoft.AspNetCore.Mvc;
using PlatformDemo.Filters;
using PlatformDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformDemo.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Reading all the tickets.");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Reading tickets {id}.");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Ticket ticket)
        {

            return Ok(ticket);
        }

        [HttpPost]
        [Route("/api/v2/{controller}")]
        [Ticket_EnsureEnteredDate]
        public IActionResult PostV2([FromBody] Ticket ticket)
        {

            return Ok(ticket);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Ticket ticket)
        {
            return Ok(ticket);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleting a ticket {id}.");
        }
    }
}
