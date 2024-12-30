namespace LeaveManagementSystem.Application.Services.LeaveAllocations;

public interface ILeaveAllocationsService
{
    Task AllocateLeave(string employeeId);
    Task EditAllocation(LeaveAllocationEditVM allocationEditVm);
    Task<EmployeeAllocationVM> GetEmployeeAllocations(string? userId);
    Task<LeaveAllocationEditVM> GetEmployeeAllocation(int allocationId);
    Task<LeaveAllocation> GetCurrentAllocation(int leaveTypeId, string employeeId);
    Task<List<EmployeeListVM>> GetEmployees();
}