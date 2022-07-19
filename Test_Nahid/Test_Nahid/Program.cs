using System;
using System.Collections.Generic;

namespace Test_Nahid
{
    internal class Program
    {

        class Student {

            public int Id { get; set; }
            public string  Name  { get; set; }
            public int  Age { get; set; }

        }


        static void Main(string[] args)
        {

            List<Student> StdList = new List<Student>();

            Student obj1 = new Student();

            obj1.Id =   1;
            obj1.Name = "Hasem";
            obj1.Age = 20;


            Student obj2 = new Student();

            obj2.Id = 2;
            obj2.Name = "Nahid";
            obj2.Age = 36;


            StdList.Add(obj2);


            for (int i = 0; i < StdList.Count; i++)
            {
                if (StdList[i].Age > 20)
                {
                    Console.WriteLine("Student Name {0} Age {1}",StdList[i].Name, StdList[i].Age);

                }
             
            }

           
        }
    }
}
