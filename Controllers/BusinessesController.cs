using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LocalBusinessLookup.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalBusinessLookup.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessesController : ControllerBase
    {
        private LocalBusinessLookupContext _db;

        public BusinessesController(LocalBusinessLookupContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Business>> Get(string name, string address, string phoneNumber, string website)
        {
            var query = _db.Businesses.AsQueryable();

            if(name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }

            if(address != null)
            {
                query = query.Where(entry => entry.Address == address);
            }

            if(phoneNumber != null)
            {
                query = query.Where(entry => entry.PhoneNumber == phoneNumber);
            }

            if(website != null)
            {
                query = query.Where(entry => entry.Website == website);
            }

            return query.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Business> Get(int id)
        {
            return _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
        }

        [HttpPost]
        public void Post([FromBody] Business business)
        {
            _db.Businesses.Add(business);
            _db.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Business business)
        {
                business.BusinessId = id;
                _db.Entry(business).State = EntityState.Modified;
                _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var BusinessToDelete = _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
            _db.Businesses.Remove(BusinessToDelete);
            _db.SaveChanges();
        }
    }
}
