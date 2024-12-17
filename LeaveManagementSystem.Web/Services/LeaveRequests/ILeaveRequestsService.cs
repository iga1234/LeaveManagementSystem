using LeaveManagementSystem.Web.Data;
using LeaveManagementSystem.Web.Models.LeaveRequests;

namespace LeaveManagementSystem.Web.Services.LeaveRequests
{
    public interface ILeaveRequestsService
	{
		Task CreateLeaveRequest(LeaveRequestCreateVM model);
		Task<EmployeeLeaveRequestListVM> GetEmployeeLeeveRequests();
        Task<LeaveRequestListVM> GetAllLeaveRequests();
		Task CancelLeaveRequest(int leaveRequestId);
		Task RewievLeaveRequest(ReviewLeaveRequestVM model);
    }
}