
using LeaveManagementSystem.Web.Models.LeaveAllocations;

namespace LeaveManagementSystem.Web.Services.LeaveAllocations
{
    public interface ILeaveAllocationsService
    {
        Task AllocateLeave(string emploeeId);
        Task<List<LeaveAllocation>> GetAllocations();
        Task<EmployeeAllocationVM> GetEmployeeAllocations();
    }
}