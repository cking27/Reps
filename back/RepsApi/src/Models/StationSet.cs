using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepsApi.Models
{
    public class StationSet
    {
        public long StationSetId {get;set;}
        
        [ForeignKey("Station")]     
        public long StationFK { get; set; }
        public Set[] Sets {get;set;}
    }
}