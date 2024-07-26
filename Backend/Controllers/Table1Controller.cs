using Business.Interfaces;
using Entities.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Table1Controller : ControllerBase
    {
        readonly ITable1Business _table1Business;

        public Table1Controller(ITable1Business table1Business)
        {
            _table1Business = table1Business;
        }

        // GET api/<Table1Controller>/
        [HttpGet]
        public IActionResult Get() {
            var result = _table1Business.Get();
            return Ok(result);
        }

        // GET api/<Table1Controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _table1Business.Get(id);
            return Ok(result);
        }

        // POST api/<Table1Controller>
        [HttpPost]
        public IActionResult Post([FromBody] Table1DTO table1) => Ok(_table1Business.Post(table1));

        // PUT api/<Table1Controller>
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Table1DTO table1) => Ok(_table1Business.Update(id, table1));

        // DELETE api/<Table1Controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) => Ok(_table1Business.Delete(id));
    }
}
