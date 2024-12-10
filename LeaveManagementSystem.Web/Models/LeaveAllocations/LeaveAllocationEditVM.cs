using LeaveManagementSystem.Web.Models.LeaveTypes;
using LeaveManagementSystem.Web.Models.Period;

namespace LeaveManagementSystem.Web.Models.LeaveAllocations
{
	public class LeaveAllocationEditVM : LeaveAllocationVM
    {
        public EmployeeListVM? Employee { get; set; }
	}
}
