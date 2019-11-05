using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksAndRecAPI.Models;
using ParksAndRecAPI.ViewModels;

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

    public ActionResult<PublicReturnModel> GetRandom()
    {
      var query = _db.Parks.AsQueryable();
      Random rand = new Random();
      int randomId = rand.Next(query.Count<Park>());
      return query.FirstOrDefault(p => p.ParkId == randomId).ConvertToPublicViewModel();
    }
    [HttpGet]
    public ActionResult<IEnumerable<PublicReturnModel>> Get(int parkId, int departmentId, string parkList)
    {
      var query = _db.Parks.AsQueryable();
      if (parkId != 0)
      {
        query.Where(p => p.ParkId == parkId);

        // if (departmentId != 0) {
        //     query.Where (p => p.DepartmentId == departmentId);
      }
      if (parkList != null)
      {
        parkList = parkList.ToLower();
        string[] parkArray = parkList.Split(",");
        query = query.Where(p => parkArray.Contains(p.Name));
      }
      return query
      .Select(p => new PublicReturnModel
      {
        Name = p.Name,
        Address = p.Address,
        City = p.City,
        ZipCode = p.ZipCode,
        Acres = p.Acres,
        YearFounded = p.YearFounded
      }).ToList();

    }


    // GET api/park/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      var query = _db.Parks.AsQueryable();
      return query.FirstOrDefault(p => p.ParkId == id).ToString();
    }

    // POST api/park
    [HttpPost]
    public void Post([FromBody] Park newPark)
    {
      _db.Add(newPark);
      _db.SaveChanges();
    }

    // PUT api/park/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Park editPark)
    {
      _db.Entry(editPark).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/park/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
      _db.Parks.Remove(parkToDelete);
      _db.SaveChanges();
    }


  }
}