using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car(80)
            //{
            //    Model = "E200",
            //    Brand = "Mercedes",
            //};

            //car1.AddFuel(30);

            //Console.WriteLine(car1.CurrentFuel);


            Student[] students = new Student[0];

            string opt;
            do
            {
                Console.WriteLine("1. Butun telebelere bax");
                Console.WriteLine("2. Butun telebelere uzre axtaris et");
                Console.WriteLine("3. Telebe elave et");
                Console.WriteLine("0. Menudan cix");

                Console.WriteLine("Secim edin:");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        ShowStudents(students);
                        break;
                    case "2":
                        Console.WriteLine("Axtaris deyerinizi daxil edin:");
                        string search = Console.ReadLine();
                        ShowStudents(students, search);

                        break;
                    case "3":
                        Student std = CreateStudent(); 
                        Array.Resize(ref students, students.Length + 1);
                        students[students.Length - 1] = std;
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Seciminiz yanlisdir!");
                        break;
                }

            } while (opt != "0");
        }

        static bool HasOnlyLetters(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            foreach (var cr in str)
            {
                if (!char.IsLetter(cr))
                    return false;
            }

            return true;
        }

        static bool IsGroupNo(string str)
        {
            if (string.IsNullOrWhiteSpace(str) || str.Length!=4)
                return false;

            //if (char.IsUpper(str[0]) && char.IsDigit(str[1]) && char.IsDigit(str[2]) && char.IsDigit(str[3]))
            //    return true;

            if (!char.IsUpper(str[0]))
                return false;

            for (int i = 1; i < str.Length; i++)
                if (!char.IsDigit(str[i])) return false;

            return true;
        }

        static void ShowStudents(Student[] arr,string search = null)
        {
            if(search == null)
            {
                foreach (Student std in arr)
                    Console.WriteLine($"Fullname: {std.FullName} - GroupNo: {std.GroupNo}");
            }
            else
            {
                foreach (Student std in arr)
                {
                    if(std.FullName.Contains(search)||std.GroupNo.Contains(search))
                        Console.WriteLine($"Fullname: {std.FullName} - GroupNo: {std.GroupNo}");
                }
                    
            }
        }

        static Student CreateStudent()
        {
            string fullname;
            do
            {
                Console.WriteLine("FullName daxil edin:");
                fullname = Console.ReadLine();
            } while (!HasOnlyLetters(fullname));

            string groupNo;
            do
            {
                Console.WriteLine("GroupNo daxil edin");
                groupNo = Console.ReadLine();
            } while (!IsGroupNo(groupNo));


            Student student = new Student(fullname)
            {
                GroupNo = groupNo
            };

            return student;
        }
    }
}
