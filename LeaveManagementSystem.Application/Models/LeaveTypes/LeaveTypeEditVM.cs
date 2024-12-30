﻿namespace LeaveManagementSystem.Application.Models.LeaveTypes
{
    public class LeaveTypeEditVM : BaseLeaveTypeVM
    {
        [Required]
        [Length(3, 150, ErrorMessage = "You have violented the length requirements")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Range(1, 90)]
        [Display(Name = "Number of Days")]
        public int NumberOfDays { get; set; }
    }
}
