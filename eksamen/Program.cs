using System;

namespace eksamen
{
    public class Person {
      public int id { get; set; }
      public string name { get; set; }
      public int age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          var p1 = new Person();
          p1.id = 1;
          p1.name = "Grom";
          p1.age = 12;


          var p2 = new Person();
          p2.id = 2;
          p2.name = "Mandekage";
          p2.age = 19;

          var p3 = new Person();
          p3.id = 3;
          p3.name = "Gåstav";
          p3.age = 99;

          Person[] folk = {
            p1,
            p2,
            p3
          };
          foreach (var person in folk){
            if (person.age > 14){
              Console.WriteLine(person.name);
            }
          }
        }
    }
}
