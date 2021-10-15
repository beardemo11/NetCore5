using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCore5.Dtos;
using NetCore5.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCore5.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {
        private readonly TodoContext _db;

        public TodoItemController(TodoContext context)
        {
            _db = context;
        }

        // GET: api/<TodoItemController>
        [HttpGet]
        public IEnumerable<TodoListSelectDto> Get()
        {
            var result = _db.TodoLists
                .Include(x => x.UpdateEmployee)
                .Include(x => x.InsertEmployee)
                .Select(x => new TodoListSelectDto
                {
                    Enable = x.Enable,
                    InsertEmployeeName = x.InsertEmployee.Name,
                    InsertTime = x.InsertTime,
                    Name = x.Name,
                    Orders = x.Orders,
                    TodoId = x.TodoId,
                    UpdateEmployeeName = x.UpdateEmployee.Name,
                    UpdateTime = x.UpdateTime
                });
            return result;
        }

        // GET api/<TodoItemController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TodoItemController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TodoItemController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TodoItemController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
