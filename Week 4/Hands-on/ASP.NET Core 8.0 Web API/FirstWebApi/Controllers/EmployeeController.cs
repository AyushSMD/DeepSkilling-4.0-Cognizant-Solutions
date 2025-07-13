using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using FirstWebApi.Models; 

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,POC")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = GetStandardEmployeeList();

        // GET: api/employee
        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        // PUT: api/employee/2
        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee updatedEmployee)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);
            if (existingEmployee == null)
                return BadRequest("Invalid employee id");

            // Update employee fields
            existingEmployee.Name = updatedEmployee.Name;
            existingEmployee.Salary = updatedEmployee.Salary;
            existingEmployee.Permanent = updatedEmployee.Permanent;
            existingEmployee.Department = updatedEmployee.Department;
            existingEmployee.Skills = updatedEmployee.Skills;
            existingEmployee.DateOfBirth = updatedEmployee.DateOfBirth;

            return Ok(existingEmployee);
        }

        private static List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "John",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "HR" },
                    Skills = new List<Skill> {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "SQL" }
                    },
                    DateOfBirth = new DateTime(1990, 01, 01)
                },
                new Employee
                {
                    Id = 2,
                    Name = "Jane",
                    Salary = 60000,
                    Permanent = true,
                    Department = new Department { Id = 2, Name = "IT" },
                    Skills = new List<Skill> {
                        new Skill { Id = 1, Name = "JavaScript" }
                    },
                    DateOfBirth = new DateTime(1992, 04, 20)
                }
            };
        }
    }
}
