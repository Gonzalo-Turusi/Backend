using Business.Interfaces;
using Entities.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Table2Controller : ControllerBase
    {
        readonly ITable2Business _table2Business;

        public Table2Controller(ITable2Business table2Business)
        {
            _table2Business = table2Business;
        }

        // GET api/<Table1Controller>/
        [HttpGet]
        public IActionResult Get()
        {
            var result = _table2Business.Get();
            return Ok(result);
        }

        // GET api/<Table1Controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _table2Business.Get(id);
            return Ok(result);
        }

        // POST api/<Table1Controller>
        [HttpPost]
        public IActionResult Post([FromBody] Table2DTO table2) => Ok(_table2Business.Post(table2));

        // PUT api/<Table1Controller>
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Table2DTO table2) => Ok(_table2Business.Update(id, table2));

        // DELETE api/<Table1Controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) => Ok(_table2Business.Delete(id));
    }
}
