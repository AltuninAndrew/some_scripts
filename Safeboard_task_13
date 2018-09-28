using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace safeboard_task
{
    class Program
    {

        static void Main(string[] args)
        {
                string pos_file = @"D:\fil.txt";     
                int size_matrix = SizeMatrixIn_File(pos_file);
                int[,] Matrix = new int[size_matrix,size_matrix];
                FillMassOf_File(pos_file, size_matrix,ref Matrix);
                int result = MinDistance(Matrix, size_matrix);
                Console.WriteLine(result);
                Console.ReadKey();
        }

        static int MinDistance(int[,] matrix, int Size)
        {

            int[,] min_dist = new int[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i == 0 && j == 0)
                        min_dist[i, j] = matrix[i, j];
                    else
                        if (i == 0)
                        min_dist[i, j] = matrix[i, j] + min_dist[0, j - 1];
                    else if (j == 0)
                        min_dist[i, j] = matrix[i, j] + min_dist[i - 1, 0];
                    else
                        min_dist[i, j] = Math.Min(min_dist[i, j - 1], min_dist[i - 1, j]) + matrix[i, j];
                }
            }
            return min_dist[Size - 1, Size - 1];
        }

        static void FillMassOf_File(string patch, int sizeMass, ref int[,] mass)
        {
            using (StreamReader sr = new StreamReader(patch))
            {
                string line = "";
                int y = -1;
                while ((line = sr.ReadLine()) != null)
                {
                    if (y >= 0)
                    {
                        for (int x = 0; x < sizeMass; x++)
                        {
                            mass[x, y] = int.Parse(line.Split(' ')[x]);

                        }
                    }
                    y++;

                }
            }
        }
        
        static int SizeMatrixIn_File(string patch)
        {
            int value = 0;
            using (StreamReader sr = new StreamReader(patch))
            {
                value = int.Parse(sr.ReadLine());
            }
            return value;
        }
    }
}
