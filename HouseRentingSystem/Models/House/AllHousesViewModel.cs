using HouseRentingSystemProject.Models.Query;

namespace HouseRentingSystemProject.Models.House
{
    public class AllHousesViewModel
    {
        public QueryViewModel Query { get; set; } = new QueryViewModel();
        public List<HousesViewModel> Houses { get; set; } = new List<HousesViewModel>();
        public List<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();
    }
}
