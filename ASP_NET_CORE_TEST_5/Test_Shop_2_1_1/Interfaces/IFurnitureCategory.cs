using Test_Shop_2_1.Models;

namespace Test_Shop_2_1.Interfaces
{
    public interface IFurnitureCategory
    {
            IEnumerable<FurnitureCategory>? AllFurnitureCategories { get; }
    }
}
