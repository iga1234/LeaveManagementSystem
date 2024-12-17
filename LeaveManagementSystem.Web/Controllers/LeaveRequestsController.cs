using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers;

public class LeaveRequestsController : Controller
{
	public async Task<IActionResult> Index()
	{
		return View();
	}

	public async Task<IActionResult> Create()
	{
		return View();
	}

	[HttpPost]
	public async Task<IActionResult> Create(int create /*Use VM*/)
	{
		return View();
	}

	[HttpPost]
	public async Task<IActionResult> Cancel(int leaveRequestId)
	{
		return View();
	}

	public async Task<IActionResult> ListRequests()
	{
		return View();
	}

	public async Task<IActionResult> Rewiev(int leaveRequestId)
	{
		return View();
	}

	[HttpPost]
	public async Task<IActionResult> Review(/*Use VM*/)
	{
		return View();
	}
}

