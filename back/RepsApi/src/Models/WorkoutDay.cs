using System;

namespace RepsApi.Models
{
    public class WorkoutDay
    {
        public long Id {get;set;}
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
    }
}