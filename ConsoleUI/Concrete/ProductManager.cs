using Business.Concrete;
using ConsoleUI.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI.Concrete
{
    public class ProductManager : IProductManager
    {
        public void GetsCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.GetCars();

            foreach (var cars in carManager.GetCars())
            {
                Console.WriteLine("{0},{1}", cars.CarId, cars.CarName);
            }
        }

        public void GetsBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.GetBrands();
            foreach (var brands in brandManager.GetBrands())
            {
                Console.WriteLine("{0},{1}", brands.BrandId, brands.BrandName);
            }
        }

        public void GetsCColor()
        {
            CColorManager colorManager = new CColorManager(new EfCColorDal());
            colorManager.GetsColors();
            foreach (var colors in colorManager.GetsColors())
            {
                Console.WriteLine("{0},{1}", colors.ColorId + colors.ColorName);
            }
        }

        public void GetsCategory()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            categoryManager.GetCategories();
            foreach (var categories in categoryManager.GetCategories())
            {
                Console.WriteLine("{0},{1}", categories.CategoryId, categories.CategoryName);
            }
        }
    }
}