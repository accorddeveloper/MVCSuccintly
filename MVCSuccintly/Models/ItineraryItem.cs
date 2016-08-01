using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSuccintly.Models
{
    [MetadataType(typeof(ItineraryItemAttributes))] // dice al framework dove trovare gli altri attributi, il codice risulta più leggibile
    public class ItineraryItem
    {
        public DateTime? When { get; set; } // ? significa nullable value type, cioè a When può essere assegnato il valore null
        public string Description { get; set; }
        public int? Duration { get; set; }
        public bool IsActive { get; set; }
        public bool? Confirmed { get; set; }
    }
}