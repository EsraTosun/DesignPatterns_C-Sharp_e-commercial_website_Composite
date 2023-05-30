using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_e_commerce
{
    interface ICompositeProducts
    {
        void ProductsListAdd(Products products);
        void ProductsListRemove(Products products);
        List<Products> GetProducts();
        void ProductsList();        //Ürünleri Listele
        void SellerProductsList();  //Satıcı Ürünleri Listele
    }
}
