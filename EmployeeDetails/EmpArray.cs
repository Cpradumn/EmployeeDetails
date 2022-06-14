using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class EmpArray
    {

        private string EmpName;
        private string EmpDeptName;
        private string EmpDesignation;
        private string EmpType;
        private float EmpSalary;
        private int EmpID;
        private int EmpAge;
        public EmpArray()
        {
            string EmpName = "";
            string EmpDeptName = "";
            string EmpDesignation = "";
            string EmpType = "";
            float EmpSalary = 0.0f;
            int EmpID = 0;
            int EmpAge = 0;
        }

        public override string ToString()
        {
            return $"Employee Name : {EmpName}\n Employee Dept Name : {EmpDeptName}\n Employee Designation : {EmpDesignation}\n Employee Type : {EmpType}\n Employee Salary : {EmpSalary}\n Employee Age : {EmpAge}";
        }

        public EmpArray(string empName, string empDeptName, string empDesignation, string empType, float empSalary, int empID, int empAge)
        {
            EmpName = empName;
            EmpDeptName = empDeptName;
            EmpDesignation = empDesignation;
            EmpType = empType;
            EmpSalary = empSalary;
            EmpID = empID;
            EmpAge = empAge;
        }

        public void Display()
        {
            Console.WriteLine($"Employee Name : {EmpName}\n Employee Dept Name : {EmpDeptName}\n Employee Designation : {EmpDesignation}\n Employee Type : {EmpType}\n Employee Salary : {EmpSalary}\n Employee Age : {EmpAge}");

        }
    }

   
}
