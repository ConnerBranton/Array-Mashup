using System;
using System.Linq;

namespace Array_Mashup
{
    class Program
    {
        static void Main(string[] args)
        {
            FillArray();
            
        }


        static void FillArray()
        {
                        
            Console.Write("How big should the 1st array be? ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[a];

            Console.Write("How big should the 2nd array be? ");
            int d = Convert.ToInt32(Console.ReadLine());
            int[] array2 = new int[d];

            //placeholder
            Console.WriteLine();

            Console.WriteLine("Fill the first array:     ");
            for (int i = 0; i < a; i++)
            {
                //get user input for each locatin of the array and store it
                Console.Write("array entry {0} = ", i);
                int g = int.Parse(Console.ReadLine());
                array1[i] = g;
                    
            }
            //placeholder
            Console.WriteLine();

            Console.WriteLine("Fill the second array:     ");
            for (int w = 0; w < d; w++)
            {
                //get input for each location of the array and store it
                Console.Write("array entry {0} = ", w);
                int x = int.Parse(Console.ReadLine());
                array2[w] = x;
            }//call combine array and its boundaries

            int[] combAry = CombineArray(array1, array2);
            PrintArray(combAry);
        }
        
        static int[] CombineArray(int[] ray1, int[] ray2)
        {
            //declare two string variables to store arrays to
            int[] combArray;
            combArray = ray1.Concat(ray2).ToArray();
            
            return combArray;
            
        }

        static void PrintArray(int[] ary3)
        {
            //print combined array
            //add strings together and incorperate brackets at beginning and end   
            string combinedArray = "";
            //for loop to read the input and convert to string
            for (int i = 0; i < ary3.Length; i++)
            {   //create for loop and stop commas before last number
                if (i == ary3.Length - 1)
                {//string conversion for second array to store array
                    combinedArray += ary3[i].ToString();
                }//puts commas at end of each number in string
                else
                    combinedArray += ary3[i].ToString() + ", ";                

            }
            //output 
            Console.WriteLine("\nThis is the combined array -> [" + combinedArray + "]");
        }
    }   

}
