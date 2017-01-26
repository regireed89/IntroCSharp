using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{

    class Student
    {
        Student() { }
        Student(string name) { }
        List<Student> jnames = new List<Student>();
        Student jim = new Student("Jim");
        Student john = new Student("John");
        Student joe = new Student("Joe");
        List<Student> bnames = new List<Student>();
        Student billy = new Student("Billy");
        Student bob = new Student("Bob");
        Student bo = new Student("Bo");

        public void Addstudents()
        {
            jnames.Add(jim);
            jnames.Add(john);
            jnames.Add(joe);

            bnames.Add(billy);
            bnames.Add(bob);
            bnames.Add(bo);

        }
        Dictionary<string, List<Student>> names = new Dictionary<string, List<Student>>();
        public void AddToDictionary()
        {
           


        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
