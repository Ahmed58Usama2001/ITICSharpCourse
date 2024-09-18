using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace C_Week4;

internal class Program
{
    static void Main(string[] args)
    {
        #region Static Attributes
        // Creating instances of Car
        //Car car1 = new Car("Toyota", "Camry");
        //Car car2 = new Car("Honda", "Civic");


        //// Displaying information about the cars
        //Console.WriteLine("Car 1:");
        //car1.DisplayInfo();
        //Console.WriteLine("Car 2:");
        //car2.DisplayInfo();


        //// Displaying the number of cars created
        //Console.WriteLine($"Number of cars created: {Car.numberOfCars}");
        #endregion

        #region Static method
        //int number = 5;

        //// Calling static methods directly without creating an instance of MathUtils
        //int squareResult = MathUtils.Square(number);
        //int cubeResult = MathUtils.Cube(number);



        //Console.WriteLine($"Square of {number}: {squareResult}");
        //Console.WriteLine($"Cube of {number}: {cubeResult}");

        //MathUtils mathUtils = new MathUtils();

        #endregion

        #region Static Ctor VS Object Ctor

        //Console.WriteLine($"Static field value: {MyClass.staticField}");

        //// Creating instances of MyClass
        //MyClass obj1 = new MyClass();
        //MyClass obj2 = new MyClass();

        //// Accessing the staticField
        //Console.WriteLine($"Static field value: {MyClass.staticField}");

        #endregion

        #region Singleton

        //GCard.GetCard(432);

        //GCard.GetCard(50);

        //GCard.GetCard(30);
        #endregion

        #region Operator Overloading

        // Creating two points
        //Point p1 = new Point(2, 3);
        //Point p2 = new Point(4, 5);

        ////// Using overloaded operator to perform vector addition
        //Point sum = p1 + p2;

        ////// Output results
        //Console.WriteLine($"p1: {p1}");
        //Console.WriteLine($"p2: {p2}");
        //Console.WriteLine($"Sum: {sum}");

        //// Using overloaded operator to compare points for equality
        //Console.WriteLine($"Are p1 and p2 equal? {p1 == p2}"); 
        #endregion

        #region As Keyword

        //object obj = new Point(3, 4);
        //object obj = "Hello"; // Assigning a string to obj

        //// Attempt to cast obj to a Point using the as keyword
        //Point point = obj as Point;

        //if (point is not null)
        //{
        //    // Cast was successful, so we can access the X and Y properties
        //    Console.WriteLine($"X: {point.X}, Y: {point.Y}");
        //}
        //else
        //{
        //    // Cast failed, obj is not a Point object
        //    Console.WriteLine("obj is not a Point object");
        //}

        #endregion

        #region Equality with structs
        //MyStruct myStruct1 = new MyStruct(3, 4);
        //MyStruct myStruct2 = new MyStruct(3, 4);

        //Console.WriteLine(myStruct1==myStruct2);
        //Console.WriteLine(myStruct1.Equals(myStruct2));
        //Console.WriteLine(object.ReferenceEquals(myStruct1, myStruct2));
        #endregion


        #region Static Binding

        // Parent class reference variable
        //Parent parentObject = new Parent();
        //parentObject.PrintMessage(); // Calls Parent class method

        // Child class reference variable
        //Child childObject = new Child();
        //childObject.PrintMessage(); // Calls Child class method (due to static binding)

        //// Parent class reference with Child object (static binding in action)
        //Parent parentObject = new Child();
        //parentObject.PrintMessage(); // Calls Parent class method again (static binding) 
        #endregion

        #region Dynamic Binding
        //Parent class reference variable
       Parent parentObject = new Parent();
    parentObject.PrintMessage(); // Calls Parent class method (static binding)

        // Child class reference variable
        Child childObject = new Child();
    childObject.PrintMessage(); // Calls Child class method (static binding)


        parentObject = new Child();
    parentObject.PrintMessage();// Calls Child class method again (dynamic binding) 

        // Dynamic variable - allows for late binding
        //Parent dynamicObject = new Child();
        //dynamicObject.PrintMessage(); // Calls Child class method (dynamic binding)

        //dynamic dynamicObject = new Child();  //to bypass compile-time type checking.
        //dynamicObject.PrintMessage(); // Calls Child class method (dynamic binding)

        //// Parent class reference with Child object (dynamic binding in action)
        //parentObject = new Child();
        //parentObject.PrintMessage(); // Calls Parent class method (static binding)

        //dynamicObject = parentObject; // Assigning Parent object to dynamic variable
        //dynamicObject.PrintMessage(); // Calls Child class method (dynamic binding) 
        #endregion
    }
}

public class Car
{
    // Static attribute
    public static int numberOfCars = 0;

    // Instance attributes
    public string make;
    public string model;

    // Constructor
    public Car(string make, string model)
    {
        this.make = make;
        this.model = model;
        // Increment the static attribute each time a new Car object is created
        numberOfCars++;
    }

    // Method to display information about the car
    public void DisplayInfo()
    {
        Console.WriteLine($"Make: {make}, Model: {model}");
    }
}


public class MathUtils
{
    // Static method to calculate the square of a number
    public static int Square(int number)
    {
        return number * number;
    }

    // Static method to calculate the cube of a number
    public static int Cube(int number)
    {
        return number * number * number;
    }
}

public class MyClass
{
    // Static field
    public static int staticField;

    //static MyClass()
    //{
    //    staticField = 1;
    //}

    // Normal constructor
    public MyClass()
    {
        staticField = 42; // Incorrect: Initializing static field in a normal constructor
    }


   


}


class GCard
{
    public int Data { get; protected set; }

     private GCard(int _data)
    {
        Data = _data;
        Console.WriteLine("Ctor");
    }

    static GCard? SingleObj; ///Initialized Default Value ( null)

    public static GCard GetCard(int _data)
    {
        if (SingleObj == null)
            SingleObj = new GCard(_data);

        Console.WriteLine(SingleObj.Data);

        return SingleObj;
    }


    public void DoSomeGraphicsWork()
    {
        Console.WriteLine("Processing");
    }

}


public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Constructor
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Overloading the '+' operator to perform vector addition
   public static Point operator +(Point left, Point right)
    {
        return new Point(left.X + right.X, left.Y + right.Y);
    } 
    

    // Overloading the '==' operator to compare points for equality
    public static bool operator ==(Point p1, Point p2)
    {
        // Check if both points have the same coordinates
        return p1.X == p2.X && p1.Y == p2.Y;
    }

    // Overloading the '!=' operator to compare points for inequality
    public static bool operator !=(Point p1, Point p2)
    {
        // Check if points are not equal
        return !(p1 == p2);
    }

    // Overriding the ToString method to provide a string representation of the point
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}


public struct MyStruct
{
    public int X { get; set; }
    public int Y { get; set; }


    public static bool operator ==(MyStruct p1, MyStruct p2)
    {
        // Check if both points have the same coordinates
        return p1.X == p2.X && p1.Y == p2.Y;
    }

    public static bool operator !=(MyStruct p1, MyStruct p2)
    {
        // Check if both points have the same coordinates
        return p1.X == p2.X && p1.Y == p2.Y;
    }
    // Constructor
    public MyStruct(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        return false;
    }
}



//Static version
//class Parent
//{


//    public void PrintMessage()
//    {
//        Console.WriteLine("This is the Parent class message.");
//    }
//}

//class Child : Parent
//{
//    public  void PrintMessage() // 'new' keyword used here
//    {
//        Console.WriteLine("This is the Child class message.");
//    }
//}


//dynamic version
class Parent
{
    public virtual void PrintMessage() // Method marked virtual for overriding
    {
        Console.WriteLine("This is the Parent class message.");
    }
}

class Child : Parent
{
    public new virtual void PrintMessage() // Method marked override to ensure it's overriding
    {
        Console.WriteLine("This is the Child class message.");
    }
}

class GrandChild:Child
{
    public override void PrintMessage() // Method marked override to ensure it's overriding
    {
        Console.WriteLine("This is the Child class message.");
    }
}
