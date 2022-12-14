using Data.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class ReservationsViewModel : IValidatableObject
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Invalid email")]
        public string Email { get; set; }
        
        public int PassengersEconomyCount { get; set; }
        public int PassengersBusinessCount { get; set; }
        public ICollection<PassengerViewModel> Passengers { get; set; }
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if(PassengersBusinessCount==0 && PassengersEconomyCount==0)
            {
                yield return new ValidationResult("You cannot make an reservation with no passengers!");
            }
            if(PassengersBusinessCount<0 || PassengersEconomyCount<0)
            {
                yield return new ValidationResult("You cannot order fewer that zero tickets!");
            }
        }
    }
}
