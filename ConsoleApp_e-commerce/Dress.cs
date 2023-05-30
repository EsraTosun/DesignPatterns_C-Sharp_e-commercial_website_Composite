using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    class Dress : Products //Elbise
    {     
        public Dress()
            : base()
        {

        }

        public Dress(int UserId, int ID, String brand, int amount, String color, String productsType,
            String Patterns, String Bodys, String FabricType)
            : base(UserId, ID, brand, amount, color, productsType,Patterns,Bodys,FabricType)
        {

        }

        /* public override void SellerProductsList()  //Satıcı Ürünleri Listele
        {
            List<Products> result = productList.Where(x => x.UserID == User.USERID &&
             x.productType.Equals(Enum.GetName(typeof(ProductsType), 3))).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        public override void ProductsList()  //Ürünleri Listele
        {
            List<Products> result = productList.Where(
             x => x.productType.Equals(Enum.GetName(typeof(ProductsType), 3))).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        } */
        public override void ProductAdd()
        {
            Products product = new Dress();
            product.productType = Seller.productsTypeFinding();
            product.ID = Canvas.productList.Count + 1000;
            Console.WriteLine("Enter the price");  //Fiyatını giriniz
            product.amount = Convert.ToInt32(Console.ReadLine());
            product.color = Color.ColorFinfing();
            product.brand = Brands.BrandListFinding();
            product.Bodys = BodyChart.BodysFinding();
            product.patterns = Patterns.PatternsFinding();
            product.FabricType = Fabrics.PantsFabricTypeFinding();
            product.UserID = Seller.USERID;
        }

        public override void ProductDelete()
        {
            int index = Canvas.productList.FindIndex(r => r.ID == Seller.DesiredID &&
             r.productType.Equals(Enum.GetName(typeof(ProductsType), 3)));

            if (index >= 0)
                Canvas.productList.RemoveAt(index);
        }

        /*public override void FindingDesiredProduct()
        {
            List<Products> result = productList.Where(x => x.ID == Customer.DesiredID &&
             x.productType.Equals(Enum.GetName(typeof(ProductsType), 3))).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        } */
    }
}
