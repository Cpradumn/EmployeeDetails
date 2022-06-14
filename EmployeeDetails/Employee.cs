using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class Employee
    {
        private int EmpID;
        private string EmpName;
        private string EmpDeptName;
        private string EmpDesignation;
        private float EmpSalary;

        public Employee()
        {
            Console.WriteLine("Default Constructor : ");
            EmpID = 0;
            EmpName = "";
            EmpDeptName = "";
            EmpDesignation = "";
          
            EmpSalary = 0.0f;
        }
        public override string ToString()
        {
            return $"Employee ID : {EmpID}, Employee Name : {EmpName}, Employee Dept Name : {EmpDeptName},Employee Designation : {EmpDesignation},Employee salary : {EmpSalary}";
        }

        public Employee(int empID, string empName, string empDeptName, string empDesignation, float empSalary)
        {
            EmpID = empID;
            EmpName = empName;
            EmpDeptName = empDeptName;
            EmpDesignation = empDesignation;
            EmpSalary = empSalary;

        }
        public void Display()
        {
            /*
            Console.WriteLine("Employee Details : \n");
            Console.WriteLine("Employee ID : "+EmpID);
            Console.WriteLine("Employee Name : "+EmpName);
            Console.WriteLine("Employee Dept Name : "+EmpDeptName);
            Console.WriteLine("Empoyee Designation : "+EmpDesignation);
            Console.WriteLine("Employee Salary : " + EmpSalary);
            */

            Console.WriteLine($"Employee ID : {EmpID}, Employee Name : {EmpName}, Employee Dept Name : {EmpDeptName},Employee Designation : {EmpDesignation},Employee salary : {EmpSalary}");
        }
    }

    
}
