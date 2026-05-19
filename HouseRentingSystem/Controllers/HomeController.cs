
using HouseRentingSystemProject.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

public class HomeController(IStatisticsService service) : Controller
{
    public IActionResult Index()
    {
        this.ViewBag.TotalRequests = service.TotalRequests;
        return this.View();
    }

    public IActionResult Error(int statusCode)
    {
        if (statusCode == 401)
        {
            return this.View("Unauthorized");
        }

        return this.View("NotFound");
    }

    public IActionResult Crash()
        => throw new Exception("Test exception");

    public IActionResult ServerError()
        => this.View();
}
