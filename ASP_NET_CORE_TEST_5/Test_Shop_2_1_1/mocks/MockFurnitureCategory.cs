using Test_Shop_2_1.Interfaces;
using Test_Shop_2_1.Models;

namespace Test_Shop_2_1.mocks
{
    public class MockFurnitureCategory : IFurnitureCategory
    {
        public IEnumerable<FurnitureCategory> AllFurnitureCategories
        {
            get {
                return new List<FurnitureCategory>
                {
                   new FurnitureCategory {categoryName = "Диван", desc = "Для груповых посиделок"},
                   new FurnitureCategory {categoryName = "Кресло", desc = "Для одиночных посиделок"}
                };
            }
        }
    }
}
