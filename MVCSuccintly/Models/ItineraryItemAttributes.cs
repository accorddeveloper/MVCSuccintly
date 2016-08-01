using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; // per utilizzare gli attributi di validazione

namespace MVCSuccintly.Models
{
    public class ItineraryItemAttributes
    {
        [Required(ErrorMessage = "You must specify when the event will occur")] // attributo di validazione
        public object When { get; set; } // ? significa nullable value type, cioè a When può essere assegnato il valore null
        [DataType(DataType.MultilineText)] // specifico un editor appropriato per la proprietà When
        [Required(ErrorMessage = "You must enter a description")] // aggiungo attributi di validazione per la proprietà descrizione
        [MaxLength(140, ErrorMessage = "The description must be less than 140 characters")]
        public object Description { get; set; }
        [Required(ErrorMessage = "You must specify how long the event will last")]
        [Range(1, 120, ErrorMessage = "Events should last between one minute and 2 hours")]
        [RegularExpression(@"\d{1,3}", ErrorMessage = "Only numbers are allowed in the duration")]
        public object Duration { get; set; }
    }
}