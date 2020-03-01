using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DepartmentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        [HttpGet("GetDepartment")]
        public async Task<Department> GetAsync()
        {
            Employee employee;
            using (var httpClient = new HttpClient())
            {
                using var response = await httpClient.GetAsync("http://localhost:52448/api/employee/GetEmployee");
                string apiResponse = await response.Content.ReadAsStringAsync();
                employee = JsonConvert.DeserializeObject<Employee>(apiResponse);
            }

            return new Department { Id = 1, Name = "IT", Employees = new List<Employee> { employee } };
        }
    }
}