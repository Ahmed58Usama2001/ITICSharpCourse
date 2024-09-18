using System.Collections;

namespace C_Week5;

internal class Program
{
    static void Main(string[] args)
    {

        #region ArrayList
        //// Create an ArrayList
        //ArrayList arrayList = new ArrayList();

        //// Box: Storing value types in ArrayList
        //int intValue = 42;
        //arrayList.Add(intValue);  // Boxing: intValue is boxed into an object

        //double doubleValue = 3.14;
        //arrayList.Add(doubleValue);  // Boxing: doubleValue is boxed into an object

        //// Unbox: Retrieving value types from ArrayList
        //int retrievedInt = (int)arrayList[0];  // Unboxing: Extracting intValue from object
        //double retrievedDouble = (double)arrayList[1];  // Unboxing: Extracting doubleValue from object

        //// Displaying values
        //Console.WriteLine("Retrieved int value: " + retrievedInt);  // Output: Retrieved int value: 42
        //Console.WriteLine("Retrieved double value: " + retrievedDouble);  // Output: Retrieved double value: 3.14 

        ////--------------------------------------------------------------------------------
        //arrayList.Add("Hello");

        //for (int i = 0; i < arrayList.Count; i++)
        //{
        //    // Attempting to cast each element to an int
        //    intValue = (int)arrayList[i]; // This line will throw an InvalidCastException
        //    Console.WriteLine(intValue);
        //}

        #endregion

        #region List

        //List<int> intList = new List<int>();

        //// Adding integers to the list
        //intList.Add(10);
        //intList.Add(20);
        //// intList.Add("Hello"); // This line would result in a compile-time error

        //// Accessing elements
        //foreach (int intValue in intList)
        //{
        //    Console.WriteLine(intValue);
        //} 

        #endregion

        #region Hash Table

        //Dictionary<string, int> ages = new Dictionary<string, int>();

        //// Adding key-value pairs to the dictionary
        //ages.Add("Alice", 30);
        //ages.Add("Bob", 35);

        //// Attempting to add a key-value pair with a duplicate key
        //ages.Add("Alice", 32);   //Exception
        //ages["Alice"] = 32;     //overwrite

        //// Accessing the values by keys
        //Console.WriteLine("Alice's age: " + ages["Alice"]); // Output: 32
        //Console.WriteLine("Bob's age: " + ages["Bob"]);     // Output: 35
        //Console.WriteLine("Ali's age: " + ages["Ali"]);     // Output: 35

        #endregion
    }
}
