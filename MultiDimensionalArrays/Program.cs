using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)

        {
            #region
            //int[,] data = new int[2, 2];
            //data[0, 0] = 62;
            //data[0, 1] = 55;
            //data[1, 0] = 33;
            //data[1, 1] = 75;
            //Console.WriteLine(data[1,0]);
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int i = 0; i < 2; i++)
            //    {
            //        for (int j = 0; j < 2; j++)
            //        {
            //            Console.Write(data[i,j]+ "\t");
            //        }
            //        Console.WriteLine();
            //    }
            #endregion
            //int[,] data = new int[2, 2];


            #region entering value via readline
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine($"enter element in the position{i} {j}");
            //        data[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("you entered too much values");

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine(data[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region intitialize second way

            //int[,] data = new int[,] { { 5, 9 }, { 8, 6 } };

            #endregion

            #region three dimensions

            //\\GET.LEGTH
            //int[,,] data = new int[2, 2, 2] { { { 2, 3 }, { 9, 8 } }, { { 7, 3 }, { 1, 5 } } };

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        for (int k = 0; k < 2; k++)
            //        {
            //            Console.WriteLine(data[i,j,k]);
            //        }
            //    }
            //}
            #endregion
        }
    }
}
