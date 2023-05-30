using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class Canvas : Products, ICompositeProducts
    {
        public static List<Products> productList = new List<Products>();

        Dress dress = new Dress();
        Tshirt tshirt = new Tshirt();
        Pants pants = new Pants();

        public Canvas()
            : base()
        {

        }

        public Canvas(int UserId, int ID, String brand, int amount, String color, String productsType,
            String Patterns, String Bodys, String FabricType)
            : base(UserId, ID, brand, amount, color, productsType, Patterns, Bodys, FabricType)
        {

        }

        public override void ProductAdd()
        {
            Products.ProductAddd();
        }

        public override void ProductDelete()
        {
            dress.ProductDelete();
            tshirt.ProductDelete();
            pants.ProductDelete();  
        }

        public List<Products> GetProducts()
        {
            return productList;
        }

        public void ProductsList()
        {
            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine(productList[i]);
            }
        }

        public void ProductsListAdd(Products products)
        {
            productList.Add(products);
        }

        public void ProductsListRemove(Products products)
        {
            productList.Remove(products);
        }

        public void SellerProductsList()
        {
            List<Products> result = productList.Where(x => x.UserID == User.USERID).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i].UserID == User.USERID)
                Console.WriteLine(result[i]);
            }
        }
    }
}
