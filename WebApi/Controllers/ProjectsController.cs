using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("Getting all projects");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Getting project {id}");
        }

        [HttpGet]
        [Route("/api/projects/{pid}/tickets")]
        public IActionResult GetProjetTicket(int pid, [FromQuery] int tid)
        {
            if (tid == 0)
            {
                return Ok($"Reading all records for Pid: {pid}");
            }
            return Ok($"Reading project #{pid}, ticket number #{tid}");
        }

        [HttpPost]
        public IActionResult Create()
        {
            return Ok("Creating a project");
        }

        [HttpPut]
        public IActionResult Update()
        {
            return Ok("Updating a project");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            return Ok($"Deleting project {id}");
        }
    }
}
