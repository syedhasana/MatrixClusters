using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace MergeSort
{
    class Program
    { 
        static Hashtable ht = new Hashtable();
        static Queue<int> queue = new Queue<int>();
        public int FindMatrixClusters(int[,] array)
        {
            int NumOfClusters = 0;
            for(int i = 0; i < array.GetLength(0); i++)
            {
                if(ht.ContainsKey(i))
                   continue;
  
                SearchClusters(array, i);
                NumOfClusters++;
            }
            return NumOfClusters;
        }

        void SearchClusters(int [,] array, int index)
        {
            if(ht.ContainsKey(index))
                return;

            ht.Add(index, index);

            for(int j =  0; j < array.GetLength(1); j++)
            {
                if(index == j)
                    continue;
                
                if(array[index, j] == 1 && !(ht.ContainsKey(j) || queue.Contains(j)))
                {
                    queue.Enqueue(j);
                }
            }
            while(queue.Count > 0)
            {
                int i = queue.Dequeue();
                SearchClusters(array, i);
            }    
        }
 
        static void Main(string[] args)
        {
            Program prg = new Program();
            int[,] matrix = new int[4,4];
            matrix[0,0] = matrix[0,1] = matrix[1,1] = matrix[1,0] = matrix[2,1] = matrix[1,2] = matrix[2,2] = matrix[3,3] = 1;  
            for(int i=0; i < matrix.GetLength(0); i++)
            {
                for(int j=0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);        
                }
                Console.Write("\n");
            }
            Console.WriteLine(prg.FindMatrixClusters(matrix));
        }   
    }
}
