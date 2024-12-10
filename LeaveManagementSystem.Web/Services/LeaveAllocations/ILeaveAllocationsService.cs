
using LeaveManagementSystem.Web.Models.LeaveAllocations;

namespace LeaveManagementSystem.Web.Services.LeaveAllocations;

public interface ILeaveAllocationsService
{
    Task AllocateLeave(string employeeId);
	Task EditAllocation(LeaveAllocationEditVM allocationEditVm);
	Task<EmployeeAllocationVM> GetEmployeeAllocations(string? userId);
	Task<LeaveAllocationEditVM> GetEmployeeAllocation(int allocationId);

	Task<List<EmployeeListVM>> GetEmployees();
}