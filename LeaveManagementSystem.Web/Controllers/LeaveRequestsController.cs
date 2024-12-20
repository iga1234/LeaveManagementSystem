﻿using LeaveManagementSystem.Web.Models.LeaveRequests;
using LeaveManagementSystem.Web.Services.LeaveRequests;
using LeaveManagementSystem.Web.Services.LeaveTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeaveManagementSystem.Web.Controllers;

public class LeaveRequestsController(ILeaveTypesService _leaveTypesService, ILeaveRequestsService _leaveRequestsService) : Controller
{
	[Authorize]
	public async Task<IActionResult> Index()
	{
		var model = await _leaveRequestsService.GetEmployeeLeaveRequests();
        return View(model);
	}

	public async Task<IActionResult> Create(int? leaveTypeId)
	{

		var leaveTypes = await _leaveTypesService.GetAllAsync();
		var leaveTypeList = new SelectList(leaveTypes, "Id", "Name", leaveTypeId);
		var model = new LeaveRequestCreateVM
		{
			StartDate = DateOnly.FromDateTime(DateTime.Now),
			EndDate = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
			LeaveTypes = leaveTypeList
		};
        return View(model);
	}

	[HttpPost]
	[ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(LeaveRequestCreateVM model)
	{
		//Validate thet the days don't excees the allocation
		if (await _leaveRequestsService.RequestDatesExceedAllocation(model))
        {
            ModelState.AddModelError(string.Empty, "You have exceeded your allocation.");
            ModelState.AddModelError(nameof(model.EndDate), "The number of days requested is invalid.");
        }

        if (ModelState.IsValid)
        {
            await _leaveRequestsService.CreateLeaveRequest(model);
            return RedirectToAction(nameof(Index));
        }
        var leaveTypes = await _leaveTypesService.GetAllAsync();
        model.LeaveTypes = new SelectList(leaveTypes, "Id", "Name");
        return View(model);
	}

	[HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Cancel(int id)
	{
        await _leaveRequestsService.CancelLeaveRequest(id);
        return RedirectToAction(nameof(Index));
	}

    [Authorize(Policy = "AdminSupervisorOnly")]
    public async Task<IActionResult> ListRequests()
	{
        var model = await _leaveRequestsService.AdminGetAllLeaveRequests();
        return View(model);
	}

	public async Task<IActionResult> Review(int id)
	{
		var model = await _leaveRequestsService.GetLeaveRequestForReview(id);
        return View(model);
	}

	[HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Review(int id, bool approved)
	{
		await _leaveRequestsService.ReviewLeaveRequest(id, approved);
		return RedirectToAction(nameof(ListRequests));
	}
}

