using System.Threading.Channels;

namespace ShoppingAPI.Models
{
    public class Products
    {
       

        public int Productid { get; set; }
        public string? ProductName { get; set; }
        public string ProductCategory { get; set; }
        public int ProductPrice { get; set; }
        public int ProductDiscountRate { get; set; }
        public bool ProductIsinStock { get; set; }
        //productId, productName, productCategory,productPrice,productDiscountRate, productIsInStock
       

        static List<Products> ProdList  = new List<Products>()
        {
          new Products(){ Productid = 1,ProductName="Soap",ProductCategory="A",ProductPrice=10,ProductDiscountRate=2,ProductIsinStock=true },
          new Products(){Productid = 2,ProductName = "Ball",ProductCategory ="B",ProductPrice = 20,ProductDiscountRate = 4,ProductIsinStock = true},
          new Products() { Productid = 3,ProductName="Hard",ProductCategory="C",ProductPrice=10,ProductDiscountRate=2,ProductIsinStock=true },
          new Products() { Productid = 4,ProductName = "Cool",ProductCategory = "D",ProductPrice = 15,ProductDiscountRate = 4,ProductIsinStock = false },
          new Products() { Productid = 5,ProductName = "Soft",ProductCategory = "E",ProductPrice = 100,ProductDiscountRate = 9,ProductIsinStock = true },
          new Products() { Productid = 6,ProductName = "CTS",ProductCategory = "F",ProductPrice = 500,ProductDiscountRate = 1,ProductIsinStock = false },
          new Products() { Productid = 7,ProductName = "GANG",ProductCategory = "G",ProductPrice = 90,ProductDiscountRate = 5,ProductIsinStock = true }
        };

       
        public List<Products> GetAllProducts ()
        {
            return ProdList    ;
        }
        public Products GetProductById (int id)
        {
            var Prod = ProdList.Find(p => p.Productid == id);
            if (Prod != null)
            {
                return Prod;
            }
            throw new Exception("Product Not Found");
        }
        public List<Products> GetProductByCategory (string Category )
        {
            var Prod  = ProdList.FindAll(p  => p.ProductCategory == Category);
            if (Prod.Count > 0)
            {
                return Prod;
            }
            throw new Exception("Sorry Not found this category= " + Category);
        }
        public List<Products> GetProductIsinStock (string Yesorno )
        {
            if (Yesorno == "yes")
            {
                var Isinstock  = ProdList.FindAll(p  => p.ProductIsinStock == true);
                return Isinstock;
            }
            var Instock  = ProdList.FindAll(p  => p.ProductIsinStock == false);
            return Instock;
        }
        public string AddNewProduct(Products newProd )
        {
            ProdList.Add(newProd);
            return "Product Added Successfully";
        }

        public string UpdateProduct (Products changes)
        {
            var Prod  = ProdList.Find(p  => p.Productid == changes.Productid);
            if (Prod != null)
            {
                Prod.ProductName = changes.ProductName;
                Prod.ProductCategory = changes.ProductCategory;
                Prod.ProductPrice = changes.ProductPrice;
                Prod.ProductDiscountRate = changes.ProductDiscountRate;
                Prod.ProductIsinStock = changes.ProductIsinStock;

                return "Product Details Updated";
            }
            throw new Exception("Product Not Found");

        }

        public string DeleteProduct (int Prodid )
        {
            var Prod  = ProdList.Find(p  => p.Productid == Prodid);
            if (Prod  != null)
            {
                ProdList .Remove(Prod);
                return "Product Deleted Successfully";
            }
            throw new Exception("Product Not Found");
        }




    }
}
