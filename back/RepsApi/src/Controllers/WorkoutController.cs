using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using RepsApi.Models;

namespace RepsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutController : ControllerBase
    {
        private readonly WorkoutDayContext _context;
        public WorkoutController(WorkoutDayContext context)
        {
            _context = context;
            if (_context.WorkoutDays.Count() == 0)
            {
                _context.WorkoutDays.Add(new WorkoutDay { Date = new System.DateTime(), Description = " A new workout" }); _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<WorkoutDay>> GetAll()
        {
            return _context.WorkoutDays.ToList();
        }

        [HttpGet("{id}", Name = "GetWorkout")]
        public ActionResult<WorkoutDay> GetById(long id)
        {
            var item = _context.WorkoutDays.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
}