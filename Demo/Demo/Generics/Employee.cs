using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Generics
{
    internal class Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}"; 
        }

        #region Operator Overloading
        //public static bool operator == (Employee Emp01 , Employee Emp02)
        //{
        //    //if (Emp01.Id == Emp02.Id && Emp01.Name == Emp02.Name && Emp01.Salary == Emp02.Salary)
        //    //    return true;
        //    //return false;
        //    return Emp01.Equals(Emp02);
        //}

        //public static bool operator != (Employee Emp01, Employee Emp02)
        //{
        //    //if (Emp01.Id != Emp02.Id || Emp01.Name != Emp02.Name || Emp01.Salary != Emp02.Salary)
        //    //    return true;
        //    //return false;
        //    return !(Emp01.Equals(Emp02));
        //}
        #endregion


        public override bool Equals(object obj)
        {
            Employee emp = (Employee)obj; // Explicit Casting
                                          // Unsafe Casting
                                          // May Throw Exception

            return this.Id == emp.Id && this.Name == emp.Name && this.Salary == emp.Salary;
        }

        // We need to override the GetHashCode Function to make the 2 references Equivelent to Each Other
        public override int GetHashCode()
        {
            // Generate Hash Code based on the Object State
            // return Id.GetHashCode() + Name?.GetHashCode()??0 + Salary.GetHashCode();
            return HashCode.Combine(Id.GetHashCode(), Name.GetHashCode(), Salary.GetHashCode());
            // 10: Somaya: 1000
            // 1000:Somaya: 10
        }

        // Sorting Based on Salary
        // Object Member Function
        public int CompareTo(object obj)
        {
            //Employee PassedEmployee = (Employee)obj; // UnSafe
            //                                         // Explicit Casting
            //                                         // May Throw Exception

            //return (this.Salary.CompareTo(PassedEmployee?.Salary));

            #region IS Conditional Operator  [True | False]
            //// This Operator Will Return True in 2 Cases
            //// 1. Obj Is a Employee
            //// 2. Obj Is An Object from Class Inherit from Employee
            //if(obj is Employee PassedEmployee)
            //{
            //    return this.Salary.CompareTo(PassedEmployee.Salary);
            //}

            //return 1;
            #endregion

            #region As Casting Operator
            Employee PassedEmployee = obj as Employee;
            // Casting Succeed into 2 Cases:
            // 1. Obj Is Employee
            // 2. Obj is An Object from Class Inherit From Employee
            // If Failed Will Return Null
            // Zero Exception will Be Thrown 
            return this.Salary.CompareTo(PassedEmployee?.Salary);
            #endregion
        }

        
    }
}
