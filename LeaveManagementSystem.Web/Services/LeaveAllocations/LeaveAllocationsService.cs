using AutoMapper;
using LeaveManagementSystem.Web.Models.LeaveAllocations;
using Microsoft.EntityFrameworkCore;
using LeaveManagementSystem.Web.Data;
using Microsoft.CodeAnalysis.CodeFixes;

namespace LeaveManagementSystem.Web.Services.LeaveAllocations;

public class LeaveAllocationsService(ApplicationDbContext _context, IHttpContextAccessor
    _httpContextAccessor, UserManager<ApplicationUser> _userManager, IMapper _mapper) : ILeaveAllocationsService
{
    public async Task AllocateLeave(string employeeId)
    {
        // get all the leave type
        var leaveTypes = await _context.LeaveTypes
            .Where(q => !q.LeaveAllocations.Any(x => x.EmployeeId == employeeId))
            .ToListAsync();


        // get the current period based on the year
        var currentDate = DateTime.Now;
        var period = await _context.Periods.SingleAsync(q => q.EndDate.Year == currentDate.Year);
        var monthsRemaining = Math.Max(1, period.EndDate.Month - currentDate.Month); ;

        // calculate leave based on number of the months left in the period

        // foreach leave type, create an allocation
        foreach (var leaveType in leaveTypes)
        {
            //Works, but not best practice
            //var allocationExists = await AllocationExists(employeeId, period.Id, leaveType.Id)
            //if(allocationExists) continue;
			var accuralRate = decimal.Divide(leaveType.NumberOfDays, 12);
             var leaveAllocation = new LeaveAllocation
            {
                EmployeeId = employeeId,
                LeaveTypeId = leaveType.Id,
                PeriodId = period.Id,
                Days = (int)Math.Ceiling(accuralRate * monthsRemaining)
            };
            _context.Add(leaveAllocation);
        }
        await _context.SaveChangesAsync();
    }

    public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string? userId)
    {
        var user = string.IsNullOrEmpty(userId) ? await _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User) : await _userManager.FindByIdAsync(userId);
			var allocations = await GetAllocations(user.Id);
        var allocationsVmList = _mapper.Map<List<LeaveAllocation>, List<LeaveAllocationVM>>(allocations);
        var leaveTypesCount = await _context.LeaveTypes.CountAsync();

		var employeeVm = new EmployeeAllocationVM
        {
            DateOfBirth = user.DateOfBirth,
            Email = user.Email,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Id = user.Id,
            LeaveAllocations = allocationsVmList,
            IsCompletedAllocation = leaveTypesCount == allocations.Count
		};
        return employeeVm;

    }
    public async Task<List<EmployeeListVM>> GetEmployees()
    {
        var users = await _userManager.GetUsersInRoleAsync(Roles.Employee);
        var employees = _mapper.Map<List<ApplicationUser>, List<EmployeeListVM>>(users.ToList());

    return employees;
	}

	public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int allocationId)
	{
		var allocation = await _context.LeaveAllocations
			.Include(q => q.LeaveType)
			.Include(q => q.Employee)
			.FirstOrDefaultAsync(q => q.Id == allocationId);

        var model = _mapper.Map<LeaveAllocationEditVM>(allocation);

        return model;
	}
	public async Task EditAllocation(LeaveAllocationEditVM allocationEditVm)
	{
		//var leaveAllocation = await GetEmployeeAllocations(allocationEditVm.Id);
  //      if(leaveAllocation == null) throw new Exception("Leave Allocation record doesn not exist");
  //      leaveAllocation.Days = allocationEditVm.Days;
		//option 1: _context.Update(leaveAllocation);
		//option2: _context.Entry(leaveAllocation).State = EntityState.Modified;
		// _context.SaveChanges();

        await _context.LeaveAllocations
            .Where(x => x.Id == allocationEditVm.Id)
            .ExecuteUpdateAsync(s => s.SetProperty(x => x.Days, allocationEditVm.Days));
	}

	private async Task<List<LeaveAllocation>> GetAllocations(string? userId)
	{
		var currentDate = DateTime.Now;
		//var period = await _context.Periods.SingleAsync(q => q.EndDate.Year == currentDate.Year);
		//var leaveAllocations = await _context.LeaveAllocations
		//    .Include(q => q.LeaveType)
		//    .Include(q => q.Period)
		//    .Where(q => q.EmployeeId == user.Id && q.PeriodId == period.Id)
		//    .ToListAsync();

		var leaveAllocations = await _context.LeaveAllocations
			.Include(q => q.LeaveType)
			.Include(q => q.Period)
			.Where(q => q.EmployeeId == userId && q.Period.EndDate.Year == currentDate.Year)
			.ToListAsync();

		return leaveAllocations;
	}

    private async Task<bool> AllocationExists(string userId, int periodId, int leaveTypeId)
    {
        var exist =await _context.LeaveAllocations.AnyAsync
            (q => q.EmployeeId == userId 
            && q.PeriodId == periodId 
            && q.LeaveTypeId == leaveTypeId
        );
        return exist;
	}
}
