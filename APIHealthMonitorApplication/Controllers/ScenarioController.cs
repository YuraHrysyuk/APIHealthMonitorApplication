﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace APIHealthMonitorApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScenarioController : Controller
    {
        [HttpGet]
        public IEnumerable<Scenario> Get()
        {
            return new List<Scenario>() {
                new Scenario() { 
                    Id = 1,
                    Name = "First Test Group",
                    Description = "Some Long Description Here 1"
                },
                new Scenario() {
                    Id = 2,
                    Name = "Second Test Group",
                    Description = "Some Long Description Here 2"
                },
                new Scenario() {
                    Id = 3,
                    Name = "Third Test Group",
                    Description = "Some Long Description Here 3"
                }
            };
        }
    
        [HttpDelete]
        [Route("{scenarioId}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}