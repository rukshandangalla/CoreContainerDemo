using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("GetEmployee")]
        public Employee Get()
        {
            return new Employee { Id = 1, Epf = "9784", Name = "Rukshan Dangalla", Department = "IT" };
        }
    }
}