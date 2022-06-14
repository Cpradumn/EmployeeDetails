using System;
using System.Collections;
using System.Collections.Generic;

namespace EmployeeDetails
{
   public class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 
             * Employee Class 
            Employee emp  = new Employee();
            Employee emp1 = new Employee(1001, "sachin", "IT", "Admin", 45000.46f);

            emp.Display();
            emp1.Display();
            */

            /*
            // Property initializer syntax
            Date date1 = new Date();
            date1.Day = 13;
            date1.Month = "june";
            date1.Year = 2022;

            Console.WriteLine($"Date is {date1.Day}/{date1.Month}/{date1.Year}");


                                    OR

            // object initializer syntax
            Date date2 = new Date{Day = 14, Month = "June", Year = 2022 };
            Console.WriteLine($"Date is {date2.Day}/{date2.Month}/{date2.Year}");


            */

            /*
            Student student1 = new Student();
            student1.Display();

            Student student2 = new Student(1001,"Pradumn",24,86.67f,Gender.Male,Branch.IT );
            student2.Display();
            */


            /*
             * 
             * Product Details 
            ProductDetails productDetails = new ProductDetails();
            productDetails.ProductName = "HP ProBook G6 Laptop";
            productDetails.ProductCode = "ZAPC74659La";
            productDetails.ProductPrice = 78000.00f;

            Console.WriteLine("Product Details : ");
            Console.WriteLine($"Product Name : {productDetails.ProductName}\n,Product Code : {productDetails.ProductCode}\n,Product Price : {productDetails.ProductPrice}");
            */


            //EmpArray emparray = new EmpArray();
            //emparray.Display();

            /*
            int [] arr = new int[5] {1, 2, 3, 4, 5};

            EmpArray[] emplist = new EmpArray[5]
            {
                new EmpArray("Sachin", "Testing", "Tester", "Company Role", 34500.57f, 1001, 24),
                new EmpArray("Sumit", "IT", "IT Engineer", "Contract ", 31500.545f, 1012, 27),
                new EmpArray("Mamata W", "Sahyadri", "Soft Developer", "Company Role", 37600.78f, 1013, 29),
                new EmpArray("Rajeshwari P", "TAG", "HR", "Company Role", 31500.57f, 1035, 28),
                new EmpArray("Kishor", "Pre-Sales", "Sales Manager", "Contract", 43500.67f, 1046, 25),

            };

            foreach (EmpArray emp1 in emplist)
            {
                Console.WriteLine(emp1);
            }
            */

            /*
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("Hello");
            list.Add(45);
            

            string name = list[1].ToString();
            int a = Convert.ToInt32(list[0]);
            
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            */


            /*
            ArrayList list = new ArrayList()
            {
                new ProductDetails{ProductName="Laptop HP Probook G6",ProductCode ="HJXC346YR",ProductPrice=78000.546f},
                new ProductDetails{ProductName="Laptop DELL Latitude 3420",ProductCode ="OPRE864HR",ProductPrice=66000.60f}
            };

            foreach (ProductDetails item in list)
            {
                Console.WriteLine(item);
            }
            */



        }
       
    }
}
