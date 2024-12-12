using Test_Shop_2_1.Models;

namespace Test_Shop_2_1.Interfaces
{
    public interface IAllFurnitures
    {
        IEnumerable<Furniture>? Furnitures { get; }
        IEnumerable<Furniture>? getFavFurnitures { get; set; }
        Furniture getObjectfurniture(int furnitureId);
    }
}
