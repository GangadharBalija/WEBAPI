using System.Threading.Channels;

namespace ShoppingAPI.Models
{
    public class Products
    {
       

        public int Productid { get; set; }
        public string? ProductName { get; set; }
        public int ProductCategory { get; set; }
        public int ProductPrice { get; set; }
        public int ProductDiscountRate { get; set; }
        public bool ProductIsinStock { get; set; }
        //productId, productName, productCategory,productPrice,productDiscountRate, productIsInStock
       

        //static List<Products> ProdList = new List<Products>()
        //{
        //  new Products() { Productid = 1,ProductName="Soap",ProductCategory=1,ProductPrice=10,ProductDiscountRate=2,ProductIsinStock=true },
        //  new Products() { Productid = 2,ProductName = "Ball",ProductCategory = 2,ProductPrice = 20,ProductDiscountRate = 4,ProductIsinStock = true },
        //  new Products() { Productid = 3,ProductName = "Mouse",ProductCategory = 3,ProductPrice = 100,ProductDiscountRate = 9,ProductIsinStock = true },
        //  new Products() { Productid = 4,ProductName = "Lap",ProductCategory = 4,ProductPrice = 500,ProductDiscountRate = 1,ProductIsinStock = false },
        //  new Products() { Productid = 5,ProductName = "Fan",ProductCategory = 5,ProductPrice = 90,ProductDiscountRate = 5,ProductIsinStock = true }
                     

        //};
        static List<Products> ProdList  = new List<Products>()
        {
            new Products(){ Productid = 1,ProductName="Soap",ProductCategory=1,ProductPrice=10,ProductDiscountRate=2,ProductIsinStock=true },
            new Products(){Productid = 2,ProductName = "Ball",ProductCategory = 2,ProductPrice = 20,ProductDiscountRate = 4,ProductIsinStock = true},
            //new Products(){ empNo=103, empName="Pari", empDesignation="Consultant", empDeptNo=10, empIsPermenant = false, empSalary=100},
            //new Employees(){ empNo=104, empName="Nikita", empDesignation="Consultant", empDeptNo=10, empIsPermenant = true, empSalary=400},
            //new Employees(){ empNo=105, empName="Anjali", empDesignation="Consultant", empDeptNo=30, empIsPermenant = true, empSalary=600},
            //new Employees(){ empNo=106, empName="Surbhi", empDesignation="Sales", empDeptNo=30, empIsPermenant = true, empSalary=800},
            //new Employees(){ empNo=107, empName="Maahi", empDesignation="Consultant", empDeptNo=10, empIsPermenant = false, empSalary=1200},
            //new Employees(){ empNo=108, empName="Akshay", empDesignation="Consultant", empDeptNo=10, empIsPermenant = true, empSalary=2200},
            //new Employees(){ empNo=109, empName="Puneet", empDesignation="HR", empDeptNo=20, empIsPermenant = true, empSalary=100},
            //new Employees(){ empNo=1010, empName="Raj", empDesignation="Consultant", empDeptNo=10, empIsPermenant = true, empSalary=220},
            //new Employees(){ empNo=1011, empName="Roshni", empDesignation="HR", empDeptNo=20, empIsPermenant = false, empSalary=250}
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




    }
}
