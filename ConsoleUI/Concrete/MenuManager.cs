using ConsoleUI.Abstract;
using System;

namespace ConsoleUI.Concrete
{
    public class MenuManager : IMenuManager
    {
        public void Menu()
        {
            Console.WriteLine("Ana Menüye Hoşgeldiniz");
            Console.WriteLine("1. Araçları Listele");
            Console.WriteLine("2. Markaları getir");
            Console.WriteLine("3.Kategorileri getir");
            Console.WriteLine("4.Renkleri getir");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ProductManager carManager = new ProductManager();
                    carManager.GetsCar();
                    break;

                case "2":
                    ProductManager brandsManager = new ProductManager();
                    brandsManager.GetsBrand();
                    break;

                case "3":
                    ProductManager categoryManager = new ProductManager();
                    categoryManager.GetsCategory();
                    break;

                case "4":
                    ProductManager colorManager = new ProductManager();
                    colorManager.GetsCColor();
                    break;
            }
        }
    }
}