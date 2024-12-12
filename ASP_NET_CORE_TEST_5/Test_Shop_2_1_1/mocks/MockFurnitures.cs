using Test_Shop_2_1.Interfaces;
using Test_Shop_2_1.Models;

namespace Test_Shop_2_1.mocks
{
    public class MockFurnitures : IAllFurnitures
    {
        private readonly IFurnitureCategory _CategoryFurniture = new MockFurnitureCategory();
        public IEnumerable<Furniture> Furnitures {
            get {
                return new List<Furniture> {
                    new Furniture {
                        name = "Армада",
                        shortDesc = "Мягкий и удобный",
                        longDesc = "Для просмотра телевизора в семейном кругу",
                        img = "",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _CategoryFurniture.AllFurnitureCategories.First()
                    },
                    new Furniture{
                        name = "Аврора",
                        shortDesc = "Широкий и мягкий",
                        longDesc = "Для просмотра телевизора в семейном кругу",
                        img = "",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = _CategoryFurniture.AllFurnitureCategories.First()
                    },
                    new Furniture{
                        name = "Каминный",
                        shortDesc = "Мягкий и расслабляющий",
                        longDesc = "Для просмотра телевизора в семейном кругу",
                        img = "",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _CategoryFurniture.AllFurnitureCategories.First()
                    },
                    new Furniture{
                        name = "Бруклин",
                        shortDesc = "Уютный и большой",
                        longDesc = "Для просмотра телевизора в семейном кругу",
                        img = "",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = _CategoryFurniture.AllFurnitureCategories.First()
                    },
                    new Furniture{
                        name = "Бали",
                        shortDesc = "Большой и мягкий",
                        longDesc = "Для просмотра телевизора в семейном кругу",
                        img = "",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _CategoryFurniture.AllFurnitureCategories.Last()
                    }
                };
            }
        }

        public IEnumerable<Furniture> getFavFurnitures { get; set; }

        public Furniture getObjectfurniture(int furnitureId)
        {
            throw new NotImplementedException();
        }
    }
}
