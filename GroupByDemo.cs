using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class GroupByDemo
    {
       static IList<Student> studentList = new List<Student>() { 
        new Student() { StudentID = 1, StudentName = "John", Age = 18, Class =1 } ,
        new Student() { StudentID = 2, StudentName = "Steve",  Age = 21,  Class =1} ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18,  Class =1} ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20,  Class =2} ,
        new Student() { StudentID = 5, StudentName = "Abram" , Age = 21,  Class =2} 
    };
        static void RunGroupByExample()
        {
            //Unique By Class
           //var studentGroup = studentList.GroupBy(x=>x.Class).OrderBy(x=>x.Key);

          
           //Unique By Class And Age
        //   var studentGroup = studentList.GroupBy(x=> new {x.Age, x.Class});//.OrderBy(x=>x.Key.Age).ThenBy(x=>x.Key.Class);
        //     foreach (var x in studentGroup)
        //    { 
              
        //        System.Console.WriteLine(x.Count()+ " student in Class "+ x.Key.Class + " With Age " +x.Key.Age);
        //        foreach (var item in x)
        //        {
        //            System.Console.WriteLine(item.StudentName);
        //        }
        //    }
        Person p = new Person();
        p.FuckEmm();
        }
    }
    class Person
    {
        internal int PersonID;
        internal string car;
        internal string FirstName;
        internal string LastName;
        internal string CarSeries;

        public void FuckEmm()
        {


            Person[] persons = new Person[8];
            persons[0] = new Person { PersonID = 2, car = "Ferrari", FirstName = "Martin", LastName = "James", CarSeries = "Series A" };
            persons[1] = new Person { PersonID = 2, car = "Ferrari", FirstName = "Martin", LastName = "James", CarSeries = "Series B" };
            persons[2] = new Person { PersonID = 2, car = "Ferrari", FirstName = "Martin", LastName = "James", CarSeries = "Series C" };
            persons[3] = new Person { PersonID = 1, car = "BMW", FirstName = "Joanne", LastName = "James", CarSeries = "Series 1" };
            persons[4] = new Person { PersonID = 1, car = "BMW", FirstName = "Joanne", LastName = "James", CarSeries = "Series 3" };
            persons[5] = new Person { PersonID = 2, car = "Audi", FirstName = "Martin", LastName = "James", CarSeries = "A3" };
            persons[6] = new Person { PersonID = 1, car = "Porche", FirstName = "Joanne", LastName = "James", CarSeries = "Series Carrera" };
            persons[7] = new Person { PersonID = 3, car = "Lexus", FirstName = "Leon", LastName = "James", CarSeries = "S Class" };

            Console.Out.WriteLine("--------------------------------------------");


            // var results7 = from p in persons group p by new { p.car, p.FirstName, p.LastName } into gp from g in gp select new { Name = g.FirstName + " " + g.LastName, Car = g.car, Count = gp.Count() }; 
            var results7 = persons.GroupBy(x=> new {x.FirstName,x.LastName,x.car});
            foreach (var k in results7) {
                System.Console.WriteLine(k.Count());
                foreach (var p in k)
                {
                    
                
                Console.WriteLine(p.FirstName + " " +  p.LastName + " " + p.car);
                 }
            }
        }
    }
      public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int Class { get; set; }
    }
    
}
