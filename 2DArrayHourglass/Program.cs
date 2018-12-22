using System;

namespace _2DArrayHourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[][]
            {
                 new int[] {1,1,1,0,0,0},
                 new int[] {0,1,0,0,0,0},
                 new int[] {1,1,1,0,0,0},
                 new int[] {0,0,2,4,4,0},
                 new int[] {0,0,0,2,0,0},
                 new int[] {0,0,1,2,4,0},
            };

            // one hourglass can only have 7 numbers, so the smallest number will be -63
            var maxTotal = -9 * 7;

            // 6 by 6 matrix can only have 16 hourglass (4 x 4)
            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    int total = 0;
                    total = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if (total > maxTotal)
                    {
                        maxTotal = total;
                    }
                }
            }

            Console.WriteLine(maxTotal);
        }

    }
}
