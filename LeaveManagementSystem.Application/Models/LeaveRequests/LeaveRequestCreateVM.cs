using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeaveManagementSystem.Application.Models.LeaveRequests
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
        [Display(Name = "Start Date")]
        [Required]
        public DateOnly StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required]
        public DateOnly EndDate { get; set; }

        [Display(Name = "Desire Leave Type")]
        [Required]
        public int LeaveTypeId { get; set; }

        [Display(Name = "Additional Information")]
        [StringLength(300)]
        public string? RequestComments { get; set; }

        public SelectList? LeaveTypes { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartDate >= EndDate)
            {
                yield return new ValidationResult("The start date must be before the end date", [nameof(StartDate), nameof(EndDate)]);
            }


        }
    }
}