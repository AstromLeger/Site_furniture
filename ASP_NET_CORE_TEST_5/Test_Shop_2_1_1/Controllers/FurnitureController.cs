using Microsoft.AspNetCore.Mvc;
using Test_Shop_2_1.Interfaces;
using Test_Shop_2_1.mocks;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
using Dapper;
using Test_Shop_2_1.ViewModels;



namespace Test_Shop_2_1.Controllers
{
    public class FurnitureController : Controller
    {

        private IAllFurnitures _allFurnitures;
        private IFurnitureCategory _allFurnitureCategories;

        //отсюда до следующего комита тестовое для подключения SQL

        //private readonly ILogger<FurnitureController> _logger;
        //private readonly IConfiguration _config;

        //public FurnitureController(ILogger<FurnitureController> logger, IConfiguration config )
        //{
        //    _logger = logger;
        //    _config = config;
        //}

        //public IDbConnection Connection
        //{
        //    get
        //    {
        //        return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
        //    }
        //}

        //public class Furnitures
        //{
        //    public int Id{get; set; }
        //    public string name{get; set; }
        //    public string form_type{get; set; }
        //}

        //private List<Furnitures> GetFurnituresNames()
        //{
        //    using (IDbConnection db = Connection)
        //    {
        //        var result = db.Query<Furnitures>("SELECT * FROM Cushioned_furniture").ToList();
        //        return result;
        //    }
        //}

        //здесь конец тестовового подключения 


        //Это способ базовый вариант 1
        //public ViewResult Index()
        //{
        //    if (_allFurnitures == null)
        //    {
        //        _allFurnitures = new MockFurnitures();
        //    }
        //    if (_allFurnitureCategories == null)
        //    {
        //        _allFurnitureCategories = new MockFurnitureCategory();
        //    }
        //    var furniture = _allFurnitures.Furnitures;
        //    return View(furniture);
        //}

        //Это второй способ вывода товаров вариант 2
        public ViewResult Index()
        {
            if (_allFurnitures == null)
            {
                _allFurnitures = new MockFurnitures();
            }
            if (_allFurnitureCategories == null)
            {
                _allFurnitureCategories = new MockFurnitureCategory();
            }

            FurnituresListViewModel obj = new FurnituresListViewModel();
            obj.AllFurnitures = _allFurnitures.Furnitures;
            obj.currCategory = "Мебель";
            return View(obj);
        }







    }
}
