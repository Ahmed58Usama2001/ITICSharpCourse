using System;
using System.Xml.Linq;

namespace C_Week4;

internal class Program
{
    [Flags]
    public enum DaysOfWeek
    {
        Saturday = 1,       // 0000 0001      
        Sunday = 2,         // 0000 0010     
        Monday = 4,         // 0000 0100     
        Tuesday = 8,        // 0000 1000     
        Wednesday = 16,     // 0001 0000 
        Thursday = 32,      // 0010 0000     
        Friday = 64,         // 0100 0000
        
    }
    //0101 0100
    //0000 0100 
 //   -----------
     //0000 0100

    public class Student
    {           
        public int Age;  //what is the cons?

        private string _name;  // Private field

        public string Name  // Property
        {
            get { return _name; }  // Getter accessor
            set { _name = value; }  // Setter accessor
        }


        public int MyProperty { get; set; }

        public int MyProperty1 { get; set; }


        //public void SetName(string name)  //value=name
        //{
        //    _name = name;
        //}

        public string Address { get; set; }
    }

    public class Numbers
    {

        public Numbers(int size)
        {
            numbers = new int[size];
        }

        public int MyProperty { get; set; }

        private int[] numbers;
        private int[] gdsh;
        public int this[int index] //(This) keyword here means Numbers (the class itself) => Every Time you see it replace it with the class name it will make sense
        {
            get
            {
                if (index < 0 || index >= numbers.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return numbers[index];
            }
            set
            {
                if (index < 0 || index >= numbers.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                numbers[index] = value;
            }
        }

       
    }

    public interface IShape
    {
        double CalculateArea();
    }


    public class Circle:IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }

    // Concrete Square class
    public class Square : IShape
    {
        public double SideLength { get; set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }

    public class Employee : IComparable
    {
        public int Id { get; set; }
        public string Name{ get; set;  }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Employee otherEmployee = (Employee)obj;
            return this.Id.CompareTo(otherEmployee.Id);
        }
    }

    static void Main(string[] args)
    {
        #region Bit flag enum

        //DaysOfWeek meetingDays = DaysOfWeek.Monday | DaysOfWeek.Wednesday | DaysOfWeek.Friday;   //0101 0100
        ////Console.WriteLine("Meeting days: " + meetingDays);

        ////meetingDays = meetingDays | DaysOfWeek.Thursday;
        ////Console.WriteLine("Updated meeting days (Thursday added): " + meetingDays);

        ////meetingDays = meetingDays ^ DaysOfWeek.Thursday;
        ////Console.WriteLine("Updated meeting days (Thursday removed): " + meetingDays);

        //bool hasTuesday = (meetingDays & DaysOfWeek.Tuesday) != 0;
        //Console.WriteLine("Has Tuesday: " + hasTuesday);
        #endregion

        #region Attributes & propsharing


        //Student person = new Student();
        //person.Age = -5;

        //person.Name = "Test";

        //Console.WriteLine("Person's Age: " + person.Age);
        #endregion

        #region Indexer
        //Numbers nums = new Numbers(5);

        //nums.MyProperty=5;

        //// Using the indexer to set values
        //nums[0] = 10;
        //nums[1] = 20;
        //nums[2] = 30;

        //// Using the indexer to get values
        //Console.WriteLine(nums[0]);  // Output: 10
        //Console.WriteLine(nums[1]);  // Output: 20
        //Console.WriteLine(nums[2]);  // Output: 30 
        #endregion

        #region Interfaces (Open Closed Principle)

        // Method that operates on Circle objects directly
        //static void PrintCircleArea(Circle circle)
        //{
        //    Console.WriteLine("Area of the circle: " + circle.CalculateArea());
        //}

        //// Method that operates on Rectangle objects directly
        //static void PrintRectangleArea(Rectangle rectangle)
        //{
        //    Console.WriteLine("Area of the rectangle: " + rectangle.CalculateArea());
        //}

        //static void PrintSquareArea(Square square)
        //{
        //    Console.WriteLine("Area of the square: " + square.CalculateArea());
        //}






        //Circle circle = new Circle(5);
        //Rectangle rectangle = new Rectangle(4, 6);
        //Square square = new Square(3);

        //PrintCircleArea(circle);
        //PrintRectangleArea(rectangle);
        //PrintSquareArea(rectangle);


        //------------------------------------------------------------




        //static void PrintArea(IShape shape)
        //{
        //    Console.WriteLine("Area of the shape: " + shape.CalculateArea());
        //}

        //IShape circle = new Circle(5);
        //IShape rectangle = new Rectangle(4, 6);
        //IShape square = new Square(3);

        //PrintArea(circle);
        //PrintArea(rectangle);
        //PrintArea(square);

        #endregion

        #region Sort Function & Icomparable

        //int[] numbers = { 5, 3, 8, 1, 2 };
        //Array.Sort(numbers);

        //foreach (int num in numbers)
        //{
        //    Console.WriteLine(num); // Output: 1, 2, 3, 5, 8
        //}

        //Employee[] employees = new Employee[]
        // {
        //    new Employee { Id = 3, Name = "Alice", Age = 30 },
        //    new Employee { Id = 1, Name = "Bob", Age = 25 },
        //    new Employee { Id = 2, Name = "Charlie", Age = 35 }
        // };

        //Array.Sort(employees);

        //foreach (var emp in employees)
        //{
        //    Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Age: {emp.Age}");
        //}
        #endregion

        #region Exceptions 
        //try
        //{
        //    // Code that may throw exceptions
        //    int x = 10;
        //    int y = 0;
        //    int result = x / y; // This will throw a DivideByZeroException
        //}
        //catch (DivideByZeroException ex)
        //{
        //    // Handle DivideByZeroException
        //    Console.WriteLine("Cannot divide by zero.");
        //}
        //catch (Exception ex)
        //{
        //    // Handle other exceptions
        //    Console.WriteLine("An error occurred: " + ex.Message);
        //}
        //finally
        //{
        //    // Code that always executes
        //    Console.WriteLine("Finally block executed.");
        //}


        #endregion


        #region Copy Constructor
        Person person1 = new Person("Ahmed", 22);
        Console.WriteLine(person1.GetHashCode());
        Console.WriteLine(person1);

        Person person2 = new Person(person1);
        Console.WriteLine(person2.GetHashCode());
        Console.WriteLine(person2);

        #endregion


    }
}


public class Person : ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }


    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public Person(Person oldObject)
    {
        this.Name = oldObject.Name;
        this.Age = oldObject.Age;
    }

    public override string ToString()
    {
        return $"Person Name: {Name} - Person Age: {Age}";
    }

    public object Clone()
    {
        return new Person(this);  //(This) keyword here means Person (the class itself) => Every Time you see it replace it with the class name it will make sense
    }
}


class OuterClass  // Default access modifier is internal
{
    class InnerClass // Default access modifier is private
    {
        // Members of InnerClass
    }
}


public class Man
{
    private int age;
    private string name;

    public Man(int myAge) :this(myAge, "default")
    {
      
    }

    public Man(int myAge, string myName)
    {
        this.age = myAge;
        this.name = myName;
    }
}


public class MyBaseClass
{
    protected int baseValue;

    public MyBaseClass(int val)
    {
        this.baseValue = val;
    }
}

public class MyDerivedClass : MyBaseClass
{
    
    private string derivedValue;

    public MyDerivedClass(int val1, string val2) : base(val1)
    {
        this.derivedValue = val2;
    }
}




