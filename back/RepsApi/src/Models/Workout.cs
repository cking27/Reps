using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepsApi.Models
{
    public class Workout
    {
        public long WorkoutId {get;set;}
        
        [ForeignKey("WorkoutDay")]     
        public long WorkoutDayFK { get; set; }

        public virtual ICollection<StationSet> StationSets{ get; set; }
    }
}