using Test_Shop_2_1.Models;


namespace Test_Shop_2_1.ViewModels
{
    public class FurnituresListViewModel
    {
        public IEnumerable<Furniture>? AllFurnitures{set; get;}

        public string currCategory { get; set;}
    }


}
