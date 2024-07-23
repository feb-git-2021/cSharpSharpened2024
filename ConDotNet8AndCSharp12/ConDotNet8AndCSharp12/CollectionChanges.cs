using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Frozen;

namespace ConDotNet8AndCSharp12
{
    public class CollectionChanges
    {

        int[] oldWayArray1 = new int[] { 1, 2, 3, 4 };//oldest way
        int[] oldWayArray2 = new [] { 1, 2, 3, 4 };
        int[] oldWayArray3 = { 1,2,3,4};

        int[] array = [1,2,3,4];//in c#12
        List<int> myList = [1,2,3,4];
       
        public void MultiArray()
        {
            int[] row0 = [1, 2, 3];
            int[] row1 = [4, 5, 6];
            int[] row2 = [7, 8, 9];
            int[] largeArray = [.. row0, .. row1, .. row2];
            int[][] matrix = [row0, row1, row2];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.WriteLine(matrix[row][col].ToString());
                }
            }
        }


    }
}
