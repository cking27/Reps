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

        [HttpPost("CreateWorkoutDay", Name = "CreateWorkoutDay")]
        public ActionResult<int> CreateWorkoutDay(WorkoutDay workoutDay)
        {
           System.Console.WriteLine("Hello from Mac");   

            var savedWorkoutDay = _context.WorkoutDays.Add(workoutDay);

            var stations  = _context.Stations;

            var workout = new Workout(){
                WorkoutDayFK = savedWorkoutDay.Entity.Id,
                StationSets  =new List<StationSet>(){
                    new StationSet{
                         StationFK = 1,
                        Sets =  new List<Set>(){
                            new Set{
                            Reps = 10,
                            Weight = 80
                            }
                        }
                    }
                }};

                _context.Workouts.Add(workout);



            var result = _context.SaveChanges();

            return 1;
    
        }

        [HttpGet("{id}", Name = "GetWorkoutById")]
        public ActionResult<Workout> GetBGetWorkoutByIdyId(long id)
        {
            var item = _context.Workouts.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
}