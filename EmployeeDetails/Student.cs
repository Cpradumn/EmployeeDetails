using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public enum Gender { Male, Female}

    public enum Branch { IT,Computer,Mechanical,Civil,Electrical}
    public class Student
    {
        private int rollno;
        private string name;
        private int age;
        private float percentage;
        private Gender gender;
        private Branch branch;

        public Student()
        {
            rollno = 0;
            name = "";
            age = 0;
            percentage = 0.0f;
            
        }
        public override string ToString()
        {
            return $"Roll No : {rollno}, Name : {name},Age : {age},Percentage : {percentage},Gender : {gender},Branch : {branch}";
        }

        public Student(int rollno, string name, int age, float percentage, Gender gender,Branch branch )
        {
            this.rollno = rollno;
            this.name = name;
            this.age = age;
            this.percentage = percentage;
            this.gender = gender;
            this.branch = branch;
        }

        public void Display()
        {
            Console.WriteLine($"Roll No : {rollno}, Name : {name},Age : {age},Percentage : {percentage},Gender : {gender},Branch : {branch}");
        }
    }
}
