using System.Threading.Channels;
using System;

namespace ShoppingAPI.Models
{
    public class CartInfo
    {
        public int customerid { get; set; }
        public string? Customername  { get; set; }
        public int Productid  { get; set; }
        public int  buyQty  { get; set; }
        public double TotalAmount  { get; set; }
        //customerID, customerName, productId,buyQty,totalAmount

     static List<CartInfo> CartInfoList = new List<CartInfo>()
     {
        new CartInfo() { customerid=1,Customername="Sam",Productid=1,buyQty=1,TotalAmount=100 },
        new CartInfo() { customerid=2,Customername="Ram",Productid=2,buyQty=3,TotalAmount=70 },
        new CartInfo () { customerid=3,Customername="Ravi",Productid=3,buyQty=5,TotalAmount=60 },
        new CartInfo () { customerid=4,Customername="Raj",Productid=4,buyQty=7,TotalAmount=80 },
        new CartInfo () { customerid=5,Customername="Madhu",Productid=5,buyQty=9,TotalAmount=1000 }
     };
     public List<CartInfo> GetAllProductsCartInfo()
     {
            return CartInfoList;
     }

        public CartInfo GetProductByCartInfoId  (int id)
        {
            var Prod = CartInfoList.Find(p => p.customerid == id);
            if (Prod != null)
            {
                return Prod;
            }
            throw new Exception("CartInfo Not Found");
        }
        public List<CartInfo> getCartProductsByCustomerName(string CustomerName )
        {
            var Prod = CartInfoList.FindAll(p => p.Customername == CustomerName);
            if (Prod.Count > 0)
            {
                return Prod;
            }
            throw new Exception("Sorry Not found this CustomerName = " + CustomerName);
        }
        public string AddNewProductCartInfo (CartInfo  newProd)
        {
            CartInfoList.Add(newProd);
            return "CartInfo Added Successfully";
        }

        public string UpdateProductCartInfo (CartInfo changes)
        {
            var Prod = CartInfoList.Find(p => p.customerid == changes.customerid);
            if (Prod != null)
            {
               
                Prod.Customername = changes.Customername;
                Prod.Productid = changes.Productid;
                Prod.buyQty = changes.buyQty;
                Prod.TotalAmount = changes.TotalAmount;
                return "CartInfo Details Updated";
            }
            throw new Exception("CartInfo Not Found");

        }

        public string DeleteProductCartInfo (int cartinfoid )
        {
            var Prod = CartInfoList.Find(p => p.customerid == cartinfoid);
            if (Prod != null)
            {
                CartInfoList.Remove(Prod);
                return "CartInfo Deleted Successfully";
            }
            throw new Exception("CartInfo Not Found");
        }



    }

   
}
