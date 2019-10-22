// I, Xiaoyu Wu, student number 000732947, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1A.Data;
using Lab1A.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab1A.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealershipApiController : ControllerBase
    {

        private readonly CarContext _context;
        private readonly DealershipMgr _dealership;


        public DealershipApiController()
        {
            _dealership = new DealershipMgr();
            _dealership.Add();
        }

        // GET: api/DealershipApi
        [HttpGet]
        public IEnumerable<Dealership> GetDearlership()
        {
            return _dealership.GetDearlership();
        }

        // GET: api/DealershipApi/5
        [HttpGet("{id}")]
        public ActionResult<Dealership> GetDearlership(int id)
        {

            return _dealership.GetDearlership(id);
        }

        // PUT: api/DealershipApi
        [HttpPut("{id}")]
        public IActionResult PutDearlership(int id, Dealership dealership)
        {
            if (id != dealership.Id)
            {
                return BadRequest();
            }

            _dealership.PutDearlership(id, dealership);

            return NoContent();
        }

        // POST: api/DealershipApi/5
        [HttpPost]
        public ActionResult<Dealership> PostDealership(Dealership dealership)
        {
            _dealership.PostDearlership(dealership);

            return CreatedAtAction("GetCar", new { id = dealership.Id }, dealership);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<Dealership> DeleteDealership(int id)
        {
            _dealership.DeleteDealership(id);

            return NoContent();
        }

    }
}
