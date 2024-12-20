﻿using LeaveManagementSystem.Web.Data;
using LeaveManagementSystem.Web.Models.LeaveRequests;

namespace LeaveManagementSystem.Web.Services.LeaveRequests
{
	public interface ILeaveRequestsService
	{
		Task CreateLeaveRequest(LeaveRequestCreateVM model);
		Task<EmployeeLeaveRequestListVM> AdminGetAllLeaveRequests();
        Task<List<LeaveRequestReadOnlyVM>> GetEmployeeLeaveRequests();
		Task CancelLeaveRequest(int leaveRequestId);
		Task ReviewLeaveRequest(int leaveRequestId, bool approved);
		Task<bool> RequestDatesExceedAllocation(LeaveRequestCreateVM model);
		Task<ReviewLeaveRequestVM> GetLeaveRequestForReview(int id);
    }
}