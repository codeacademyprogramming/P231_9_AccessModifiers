using System;
using Lesson.Classes;
using MyClasses;
using NewApp.Classes;



namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            Product pr1 =new Product(25);
            pr1.Name = "Milla 1L";

            Console.WriteLine(pr1.Price);

            //pr1.SetPrice(50);
            //pr1.SetPrice(-10);
            //pr1.SetPrice(10);
            //pr1.SetPrice(-20);
            //pr1.SetPrice(30);
            //pr1.SetPrice(-1);

            pr1.Price = -44;
            pr1.Price = 45;
            pr1.Price = -80;


            Console.WriteLine(pr1.Info);


            Student std = new Student();
            std.Age = 18;
            std.FullName = "Hikmet";

            Console.WriteLine($"{std.FullName} - {std.Age}");

            Employee emp = new Employee();

            Notebook notebook = new Notebook();
            notebook.Name = "Asus ROG";
            notebook.Price = 134;
        }
    }

   
   
}
