namespace Test_Shop_2_1.Models
{
    public class FurnitureCategory
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public string desc { get; set; }
        public List<Furniture> Furnitures { get; set; }
    }
}
