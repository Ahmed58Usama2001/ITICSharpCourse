using System.Diagnostics;

namespace C_Week2;

internal class Program
{
    static void Main(string[] args)
    {
        #region signed vs unsigned
        //Signed data types
        //sbyte signedByte = -10;
        //short signedShort = -20000;
        //int signedInt = -500000;
        //long signedLong = -10000000000L;

        //// Unsigned data types
        //byte unsignedByte = 50;
        //ushort unsignedShort = 60000;
        //uint unsignedInt = 4000000000;
        //ulong unsignedLong = 1500000000000000000UL;

        //Console.WriteLine($"Signed Byte: {signedByte}");
        //Console.WriteLine($"Signed Short: {signedShort}");
        //Console.WriteLine($"Signed Int: {signedInt}");
        //Console.WriteLine($"Signed Long: {signedLong}");

        //Console.WriteLine($"Unsigned Byte: {unsignedByte}");
        //Console.WriteLine($"Unsigned Short: {unsignedShort}");
        //Console.WriteLine($"Unsigned Int: {unsignedInt}");
        //Console.WriteLine($"Unsigned Long: {unsignedLong}");
        //#endregion



        //#region float, double and decimal
        //Console.WriteLine($"Size of decimal: {sizeof(decimal)} bytes");
        //Console.WriteLine($"Size of double: {sizeof(double)} bytes");
        //Console.WriteLine($"Size of float: {sizeof(float)} bytes");
        #endregion

        #region TryParse

        //string numberStr = "hghg";
        ////int number = int.Parse(numberStr);
        ////Console.WriteLine(number); // Output: 123

        //int number;

        //if (int.TryParse(numberStr, out number))
        //{
        //    Console.WriteLine(number);
        //}
        //else
        //{
        //    Console.WriteLine("Conversion failed.");
        //}

        #endregion

        #region array
        //int[5] arr;
        //int[] arr;

        //[Stack]
        //+ -----+
        //| arr | (Reference to array, uninitialized)
        //+-----+

        //[Heap]
        //(no memory allocated for array elements yet)
        //-----------------------------------------------------------
        //arr = new int[3];
        //arr[0] = 10;
        //arr[1] = 20;

        ////[Stack]
        ////+ -----+
        ////| arr | (Reference to array)
        ////+-----+

        ////[Heap]
        ////+ ---+---+---+---+---+
        ////| 10 | 20 | 0 | (Array elements with initialized values)
        ////+---+---+---+---+---+

        //int[] arr2 = arr;
        ////arr[0] = 1;
        ////for (int i = 0; i < arr2.Length; i++)
        ////{
        ////    Console.WriteLine(arr2[i]);
        ////}


        //int[] arr2 = (int[])arr.Clone();

        ////int[]= object;

        ////derived = base ==> no implicit casting(not valid) ==>must use explicit cast

        //arr[0] = 1;
        //for (int i = 0; i<arr2.Length; i++)
        //{
        //    Console.WriteLine(arr2[i]);
        //}


#endregion

#region Implicit vs Explicit casting
//double doubleValue = 10.5777777777777777;
//int intValue = (int)doubleValue;  // Explicit casting to int, potential data loss

//int intValue = 10;
//double doubleValue = intValue;  // Implicit casting from int to double, safe conversion 


//----------------------------------------------------------


//For reference types

DerivedClass derivedObj = new DerivedClass();

        BaseClass baseObj = new BaseClass();

        baseObj = derivedObj;

        derivedObj = (DerivedClass)baseObj;

        #endregion

        #region Boxing Vs UnBoxing
        // Boxing: Converting value type to object reference type
        //int intValue = 42;
        //object boxedValue = intValue; // Boxing occurs here

        //Console.WriteLine(intValue);

        ////// Unboxing: Converting object reference type back to value type
        //int unboxedValue = (int)boxedValue; // Unboxing occurs here


        #endregion

        #region nullable
        //int x = 50;

        //int? Y; ///Nullable int , IL : Nullable<int>

        //Y = null;

        ///////Safe Casting , Implicit


        //x = (int)Y;

        /////UnSafe , Explicit 


        //int? x = null;

        //int result = x ?? 10;

        //Person person = null;

        //string name = person?.Name;

        //Console.WriteLine(name);

        #endregion

        #region Passing By value & Passing By reference for value types 
        //void ChangeValue(int x, int y)
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}

        //int a = 3, b = 5;

        //ChangeValue(a, b);

        //Console.WriteLine(a);
        //Console.WriteLine(b);


        //void ChangeValueRef(ref int x, ref int y)
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}

        //ChangeValueRef(ref a, ref b);

        //Console.WriteLine(a);
        //Console.WriteLine(b);

        #endregion

        #region Passing By value & Passing By reference for value types 

        //static int SumArrayByVal(int[] arr)
        //{
        //    int sum = 0;

        //    if (arr != null)
        //    {
        //        arr[0] = 100;

        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];
        //        }
        //    }

        //    return sum;
        //}

        //int[] numbers = { 1, 2, 3 };

        //Console.WriteLine(numbers[0]);


        //SumArrayByVal(numbers); //Passing By value

        //Console.WriteLine(numbers[0]);


        //static int SumArrayByRef(ref int[] arr)
        //{
        //    int sum = 0;

        //    if (arr != null)
        //    {
        //        arr[0] = 100;

        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];
        //        }
        //    }

        //    return sum;
        //}

        //int[] numbers = { 1, 2, 3 };

        //Console.WriteLine(numbers[0]);


        //SumArrayByRef(ref numbers); //Passing By value

        //Console.WriteLine(numbers[0]);


        //-------------------------------------------------------------------------------
        //static int SumArrayByVal(int[] arr)
        //{
        //    int sum = 0;

        //    if (arr != null)
        //    {
        //        arr = new int[] { 4, 5, 6 };

        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];
        //        }
        //    }

        //    return sum;
        //}

        //int[] numbers = { 1, 2, 3 };

        //Console.WriteLine(numbers[0]);


        //SumArrayByVal(numbers); //Passing By value

        //Console.WriteLine(numbers[0]);


        static int SumArrayByRef(ref int[] arr)
        {
            int sum = 0;

            if (arr != null)
            {
                arr = new int[] { 4, 5, 6 };

                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }

        int[] numbers = { 1, 2, 3 };

        Console.WriteLine(numbers[0]);


        SumArrayByRef(ref numbers); //Passing By value

        Console.WriteLine(numbers[0]);

        #endregion

        #region Out vs Ref
        //static void ModifyWithRef(ref int num)
        //{
        //    num += 10;
        //}

        //int a = 5;

        //ModifyWithRef(ref a);
        //Console.WriteLine("Value after using ref: " + a);



        //static void ModifyWithOut(out int num)
        //{

        //    num = 20;
        //}

        //int b;
        //ModifyWithOut(out b);
        //Console.WriteLine("Value after using out: " + b);

        #endregion


        #region Stack Trace

        //StackTrace stackTrace = new StackTrace();

        //StackFrame[] stackFrames = stackTrace.GetFrames();

        //for (int i = 0; i < stackFrames?.Length; i++)
        //{
        //    Console.WriteLine(stackFrames[i]?.GetMethod()?.Name);
        //}

        #endregion

        #region Named Parameters

        //static void DisplayInfo(string name, int age, string city)
        //{
        //    Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
        //}


        //DisplayInfo("Ahmed", 22, "Tanta");

        //DisplayInfo(age: 30, name: "John", city: "New York");

        //DisplayInfo(city: "Los Angeles", name: "Alice", age: 25);

        //DisplayInfo("Mike", city: "Chicago", age: 35);

        #endregion


        //BaseClass baseClass = new BaseClass();

        //Point point = new Point();
        //Person point = new Person();

    }
}

struct Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class BaseClass { }

class DerivedClass : BaseClass { }




public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

}



