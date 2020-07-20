using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectFinal.Models
{
    public class Firstclass
    {
        // Variables
        int myinteger; string mystring; double mydouble; char mychar; bool mybool; float myfloat; byte mybyte;

        // Properties
        public int MyInt { get; set; }  public string MyString { get; set; } public double MyDouble { get; set; }

        // First Constructor 
        public Firstclass()
        {


        }
        // Second Constructor 
        public Firstclass(int myint, string mystring, double mydouble)
        {
            myint = MyInt;
            mystring = MyString;
            mydouble = MyDouble;

        }

        public int FirstInt()
        {

            return MyInt;
        }

        public string FirstStringMethod(string mystring)
        {

            return mystring;

        }

        public void MyVoid()
        {
            Console.WriteLine("Write to the Console");

        }
    }
}
