using Demo.Generics;
using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generics [SWAP Example]
            //int A = 10, B = 30;
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Helper<int>.SWAP<int>(ref A, ref B);
            //Console.WriteLine("After Swap: ");
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //double X = 2.2, Y = 3.3;
            //Console.WriteLine($"X = {X}");
            //Console.WriteLine($"Y = {Y}");
            //Helper<double>.SWAP<double>(ref X, ref Y);
            //Console.WriteLine("After Swap: ");
            //Console.WriteLine($"X = {X}");
            //Console.WriteLine($"Y = {Y}");

            //Point P1 = new Point(1, 2);
            //Point P2 = new Point(10, 20);

            //Console.WriteLine($"P1: {P1}");
            //Console.WriteLine($"P2: {P2}");
            //Helper<Point>.SWAP<Point>(ref P1, ref P2);
            //Console.WriteLine($"P1: {P1}");
            //Console.WriteLine($"P2: {P2} ");

            #endregion

            #region Generics [Search Example]
            //int[] Numbers = { 4, 5, 6, 9, 3, 2, 8, 1, 7 };
            //int Index = Helper<int>.SearchArray(Numbers, 6);
            //Console.WriteLine($"The Index of Value {6} = {Index}");

            //Employee Emp01 = new Employee { Id = 10, Name = "Somaya", Salary = 15000 };
            //Employee Emp02 = new Employee { Id = 20, Name = "Yousef", Salary = 20000 };

            //if (Emp01 == Emp02) // Object State in Struct 
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");

            //if (Emp01.Equals(Emp02))
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");
            //Employee Emp01 = new Employee { Id = 10, Name = "Somaya", Salary = 15000 };
            //Employee Emp02 = new Employee { Id = 20, Name = "Yousef", Salary = 20000 };
            //Employee Emp03 = new Employee { Id = 30, Name = "Sara", Salary = 25000 };

            //Employee[] employees = new Employee[2]
            //{
            //    Emp01,Emp02
            //};

            //int Index = Helper<Employee>.SearchArray(employees, Emp03);
            //Console.WriteLine($"Index of Employee {Emp03} = {Index}");


            #endregion

            #region Generics [Reference Type Example]
            //Employee Emp01 = new Employee { Id = 20, Name = "Yousef", Salary = 20000 };
            //Employee Emp02 = new Employee { Id = 20, Name = "Yousef", Salary = 20000 };

            //if (Emp01 == Emp02) // References in Classes // Not Recommended in Generic as it is not implemented in all data type
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");

            //if (Emp01.Equals(Emp02)) // References in Classes // But Recommended
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");

            //Console.WriteLine($"HC OF Emp01 = {Emp01.GetHashCode()}");
            //Console.WriteLine($"HC OF Emp02 = {Emp02.GetHashCode()}");
            //// Equals -> [Struct] => Compares Objects States [Data]
            // Equals -> [Class] => Compares Between References [Identity] Not Object State 
            #endregion

            #region Generics [Sort Example]
            //int[] Numbers = { 12, 25, 3, 6, 9, 5, 20, 1, 2, 10 };
            //foreach(int item in Numbers)
            //{
            //    Console.Write($" {item}");
            //}

            //Helper<int>.BUbbleSort(Numbers);

            //Console.WriteLine("\nAfter Swapping: ");
            //foreach (int item in Numbers)
            //{
            //    Console.Write($" {item}");
            //}

            //Employee[] employees = new Employee[]
            //{
            //    new Employee(){Id = 10, Name = "Somaya", Salary = 20000},
            //    new Employee(){Id = 20, Name = "Yousef", Salary = 50000},
            //    new Employee(){Id = 30, Name = "Nour", Salary = 15000},
            //    new Employee(){Id = 40, Name = "Sara", Salary = 170000},

            //};

            //Helper<Employee>.BUbbleSort(employees);

            //foreach (Employee item in employees)
            //{
            //    Console.WriteLine($" {item}");
            //}

            //Point[] points =
            //{
            //    new Point(7,2),
            //    new Point(2,5),
            //    new Point(6,4),
            //    new Point(7,3),
            //    new Point(1,2),
            //    new Point(9,2)
            //};

            //Helper<Point>.BUbbleSort(points);

            //foreach(Point point in points)
            //{
            //    Console.WriteLine(point);
            //}
            #endregion


            Console.ReadKey();
        }
    }
}
