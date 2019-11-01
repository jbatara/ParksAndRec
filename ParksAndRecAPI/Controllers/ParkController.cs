using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParksAndRecAPI.Models;

namespace ParksAndRecAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkController : ControllerBase
    {
        private ParksAndRecDbContext _db;

        public ParkController(ParksAndRecDbContext db)
        {
            _db = db;
        }

        // GET api/park
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var query = _db.Words.AsQueryable();
            var returnObject = new Object(){};
            returnObject.Parks = query.ToList();
            return new string[] { "value1", "value2" };
        }

        // GET api/park/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/park
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/park/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/park/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
