using System;
using System.Collections;
using System.Collections.Generic;

namespace EmployeeDetails
{
   public class Program
    {

        static void Addition()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Addition is :{a + b}");
        }
        static void Substract()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Substract is :{a - b}");
        }

        public delegate void MyDelegate();
        public class Calculate
        {
            public event MyDelegate add;
            public event MyDelegate sub;

            public void Accept (int n)
            {
                if(n ==1)
                {
                    add();
                }
                else if(n ==2)
                {
                    sub();
                }
            }
        }
        public static void Main(string[] args)
        {

            Calculate c1 = new Calculate();
            c1.add += new MyDelegate(Addition);
            c1.sub += new MyDelegate(Substract);

            c1.Accept(2);











            /*
             * 
             * Employee Class 
            Employee emp  = new Employee();
            Employee emp1 = new Employee(1001, "sachin", "IT", "Admin", 45000.46f);

            emp.Display();
            emp1.Display();
            */

            /*
             * Employee1
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
             * 
             * Student
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
             * Employee Array
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
             * Array List
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
             * 
             * Array List Product Details
             * 
             * 
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

            // https://github.com/Cpradumn


            /*
            List<int> intlist = new List<int>() { 1, 2, 3, 4, 5};

            foreach(int item in intlist)
            {
                Console.WriteLine(item);
            }

            List<string> stringlist = new List<string>() { "red", "Yeoolw", "Green", "Blue" };

            foreach(string item2 in stringlist)
            {
                Console.WriteLine(item2);
            }

            */


            /*
             * 
             * List Student
            List<Student> students = new List<Student>()
            {
                new Student(1001, "Pradumn", 24, 86.67f, Gender.Male, Branch.IT),
                new Student(1002,"sachin",25,88.60f,Gender.Male,Branch.Electrical)
            };

            foreach (Student stud in students)
            {
                Console.WriteLine(stud);
            }
            */


            // Dictionary --> generic collection object to store the data int the form of key-value pair


            /*
            Dictionary<int, string> Countries = new Dictionary<int, string>();
            Countries.Add(91, "India");
            Countries.Add(45, "Germany");
            Countries.Add(1, "USA");

            Countries.Remove(0);
            foreach(var country in Countries)
            {
                Console.WriteLine(country.Key+" "+country.Value);
            }

            */

            /*
            Console.WriteLine("Employee Stack Details : ");

            Stack<Employee> stack = new Stack<Employee>();
            //{
            //    //new Employee (1002,"Sachin","IT","Admin",45000),

            //};
            stack.Push(new Employee(1002, "Sachin", "IT", "Admin", 45000.45f)); // ---> Push
            //stack.Pop(); // Pop --> Remove

            foreach(Employee emp in stack)
            {
                Console.WriteLine(emp);
            }


            Console.WriteLine("Employee Queue Details : ");

            Queue<Employee> queue = new Queue<Employee>();
            queue.Enqueue(new Employee(1002, "Sachin", "IT", "Admin", 45000)); //Enqueue --> Add
            //queue.Dequeue(); // Dequeue --> Remove

            foreach (Employee emp1 in queue)
            {
                Console.WriteLine(emp1);
            }


            //// Student Stack Details 
            ///

            // Student Stack Details 
            Console.WriteLine("Student Stack Details : ");

            Stack<Student> stack1 = new Stack<Student>();

            stack1.Push(new Student(1001, "Pradumn", 24, 86.67f, Gender.Male, Branch.IT));
            stack1.Push(new Student(1002, "sachin", 25, 88.60f, Gender.Male, Branch.Electrical));

            foreach (Student stud in stack1)
            {
                Console.WriteLine(stud);
            }


            // Student Queue Details

            Console.WriteLine("Student Queue Details");

            Queue<Student> queue1 = new Queue<Student>();
            queue1.Enqueue(new Student(1001, "Pradumn", 24, 86.67f, Gender.Male, Branch.IT));
            queue1.Enqueue(new Student(1002, "sachin", 25, 88.60f, Gender.Male, Branch.Electrical));

            foreach (Student stud4 in queue1)
            {
                Console.WriteLine(stud4);
            }

            */


            

        }

    }
}
