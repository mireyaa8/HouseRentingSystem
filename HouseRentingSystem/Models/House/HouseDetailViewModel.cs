namespace HouseRentingSystemProject.Models.House
{
    public class HouseDetailViewModel : HousesViewModel
    {
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
    }
}
