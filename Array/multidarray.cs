using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    multi dimensional array is an array that contains more than one dimension.
    It is used to store data in a tabular format.
    It is also known as a rectangular array.
    It is used to store data in a matrix format.
    It is used to store data in a grid format.
    how to declare a multi dimensional array:
    data_type[,] array_name = new data_type[rows, columns];
    where rows is the number of rows and columns is the number of columns.
    Example:
    int[,] arr = new int[3, 3];
    This will create a 2D array with 3 rows and 3 columns.
    how to initialize a multi dimensional array:
    public static void Main(string[] args)
    {
        int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        // This will create a 2D array with 3 rows and 3 columns and initialize it with the given values.
        // You can access the elements of the array using the index.
        Console.WriteLine(arr[0, 0]); // Output: 1
        Console.WriteLine(arr[1, 1]); // Output: 5
        Console.WriteLine(arr[2, 2]); // Output: 9
    }
    how get values from user:
    public static void Main(string[] args)
    {
        int[,] arr = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Enter value for arr[{0},{1}]: ", i, j);
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        // This will create a 2D array with 3 rows and 3 columns and initialize it with the values entered by the user.
        // You can access the elements of the array using the index.
        Console.WriteLine(arr[0, 0]);
        Console.WriteLine(arr[1, 1]);
        Console.WriteLine(arr[2, 2]);
    }
    how to declare 3D array:
    public static void Main(string[] args)
    {
        int[,,] arr = new int[2, 3, 4];
        // This will create a 3D array with 2 layers, 3 rows and 4 columns.
        // You can access the elements of the array using the index.
        arr[0, 0, 0] = 1;
        arr[0, 0, 1] = 2;
        arr[0, 0, 2] = 3;
        arr[0, 0, 3] = 4;
        Console.WriteLine(arr[0, 0, 0]); // Output: 1
    }
 */

namespace _24SOECE13043_Dharmraj_sodha.Array
{
    internal class multidarray
    {
        public static void Main(string[] args)
        {
            int[,] ary = new int[2,2];
            ary[0,0] = 1;
            ary[0,1] = 2;
            ary[1,0] = 3;
            ary[1,1] = 4;
            Console.WriteLine("2D Array:");
            Console.WriteLine(ary[0,0]);
            int[,] ints = { { 1, 2, 6 }, { 3, 4, 5 } };
            //Console.WriteLine(Convert.ToString(ints[0]));
            Console.WriteLine("2D Array with initialization:");
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.Write(ints[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
