using HouseRentingSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    public class HouseController : Controller
    {
        private List<HouseViewModel> houses = new List<HouseViewModel>
        {
            new HouseViewModel
            {
                Name = "Beach house",
                Description = "Miami, Florida",
                ImageUrl = "https://robbreport.com/wp-content/uploads/2017/06/miami-grove-house-backyard-pool.jpg?w=1000"
            },
            new HouseViewModel
            {
                Name = "House 2",
                Description = "Description for House 2",
                ImageUrl = "https://example.com/house2.jpg"
            },
            new HouseViewModel
            {
                Name = "House 3",
                Description = "Description for House 3",
                ImageUrl = "https://example.com/house3.jpg"
            }
        };
        public IActionResult AllHouses()
        {
            return View();
        }
    }
}
