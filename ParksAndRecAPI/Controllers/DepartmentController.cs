using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksAndRecAPI.Models;

namespace ParksAndRecAPI.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase {
        private ParksAndRecDbContext _db;

        public DepartmentController (ParksAndRecDbContext db) {
            _db = db;
        }

        // GET api/park
        [HttpGet]
        public ActionResult<IEnumerable<Department>> Get (int parkId, int departmentId, string departmentList) {
            var query = _db.Departments.AsQueryable ();
            if (parkId != 0) {
                Park searchedPark = _db.Parks.FirstOrDefault (p => p.ParkId == parkId);
                query.Where (d => d.Parks.Contains (searchedPark));
            }
            if (departmentId != 0) {
                query.Where (d => d.DepartmentId == departmentId);
            }
            if (departmentList != null) {
                departmentList = departmentList.ToLower ();
                string[] departmentArray = departmentList.Split (",");
                query = query.Where (d => departmentArray.Contains (d.DepartmentName));
            }
            return query.ToList ();
        }

        // GET api/park/5
        [HttpGet ("{id}")]
        public ActionResult<string> Get (int id) {
            var query = _db.Departments.AsQueryable ();
            return query.FirstOrDefault (d => d.DepartmentId == id).ToString ();
        }

        // POST api/park
        [HttpPost]
        public void Post ([FromBody] Department newDepartment) {
            _db.Add (newDepartment);
            _db.SaveChanges ();
        }

        // PUT api/park/5
        [HttpPut ("{id}")]
        public void Put (int id, [FromBody] Department editDepartment) {
            _db.Entry (editDepartment).State = EntityState.Modified;
            _db.SaveChanges ();
        }

        // DELETE api/park/5
        [HttpDelete ("{id}")]
        public void Delete (int id) {
            var departmentToDelete = _db.Departments.FirstOrDefault (entry => entry.DepartmentId == id);
            _db.Departments.Remove (departmentToDelete);
            _db.SaveChanges ();
        }
    }
}