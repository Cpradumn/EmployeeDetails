using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class ProductDetails
    {
        // product Name
        // Product code
        // product price
         public string ProductName { get; set; }
        public string ProductCode { get; set; }

        public float ProductPrice { get; set; }

        public override string ToString()
        {
            return $"ProductName : {ProductName} \n Product Code : {ProductCode} \n Product Price : {ProductPrice} ";
        }
    }
}
