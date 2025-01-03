﻿namespace LeaveManagementSystem.Application.Services.LeaveTypes;

public interface ILeaveTypesService
{
    Task<bool> CheckIfLeaveTypeNameExists(string name);
    Task<bool> CheckIfLeaveTypeNameExistsForEdit(LeaveTypeEditVM leaveTypeEdit);
    Task Create(LeaveTypeCreateVM model);
    Task<bool> DaysExceedMaximum(int leaveTypeId, int days);
    Task Edit(LeaveTypeEditVM model);
    Task<List<LeaveTypeReadOnlyVM>> GetAllAsync();
    Task<T?> GetAsync<T>(int id) where T : class;
    bool LeaveTypeExists(int id);
    Task Remove(int id);
}