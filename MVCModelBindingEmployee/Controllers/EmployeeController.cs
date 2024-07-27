using Microsoft.AspNetCore.Mvc;
using MVCModelBindingEmployee.Models;

namespace MVCModelBindingEmployee.Controllers
{
	public class EmployeeController : Controller
	{
		//GET: /Employee/CreateEmployee
		[HttpGet]
		public IActionResult CreateEmployee()
		{
			return View();
		}

		[HttpPost] //This action is hit after the user submits form data
		public IActionResult CreateEmployee(Employee e)
		{
			//Validate Data
			if (ModelState.IsValid)
			{
				//Add to database
				return RedirectToAction("Index", "Home");
			}

			//If the model state is not valid
			//show the user the same web page , with validation
			//errors

			//return view
			return View();
		}

		[HttpGet]
		public IActionResult UserProfile()
		{
			return View();
		}
	}
}
