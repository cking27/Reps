using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using RepsApi.Models;
using Microsoft.AspNetCore.Cors;


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
                _context.WorkoutDays.Add(new WorkoutDay { Date = new System.DateTime(), Description = " A new workout" }); 
            }

            if (_context.Stations.Count() == 0)
            {
                _context.Stations.Add(new Station { Name="Bicep Curl"}); _context.SaveChanges();
                _context.Stations.Add(new Station { Name="Tricep "}); _context.SaveChanges();
                
            }
           


            _context.SaveChanges();
        }

        [HttpGet]
        public ActionResult<List<WorkoutDay>> GetAlls()
        {
            return _context.WorkoutDays.ToList();
        }

        [HttpGet("GetStations", Name = "GetStations")]

        public ActionResult<List<Station>> GetStations()
        {
            return _context.Stations.ToList();
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