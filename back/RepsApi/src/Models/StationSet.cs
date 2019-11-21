using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepsApi.Models
{
    public class StationSet
    {
        public long StationSetId {get;set;}
        
        [ForeignKey("Station")]     
        public long StationFK { get; set; }
        public virtual ICollection<Set> Sets {get;set;}
    }
}