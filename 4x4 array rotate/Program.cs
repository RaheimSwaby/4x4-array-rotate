using System.Numerics;

namespace _4x4_array_rotate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] nums = new int[][] 
            {
                [5,1,9,11,],
                [2,4,8,10,],
                [13,3,6,7,],
                [15,14,12,16,],

            };
            Rotate(nums);
            Print(nums);

        }

        public static void  Rotate(int[][] nums) 
        {
            int n = nums.Length; 
            
            for (int i = 0; i < n; i++) 
            {
                for (int j = i + 1; j < n; j++) 
                {
                    int temp = nums[i][j]; 
                    nums[i][j] = nums[j][i];
                    nums[j][i] = temp;
                }
            }
            for (int i = 0; i < n; i++) 
            {
                int left = 0;
                int right = n-1;
                while (left < right) 
                {
                    int temp = nums[i][left];
                    nums[i][left] = nums[i][right];
                    nums[i][right] = temp;
                    left++;
                    right--;
                }
            }
            
        }
        public static void Print(int[][] nums) 
        {
            foreach(var i in nums) 
            {
                Console.WriteLine(string.Join(" ",i));
            }
        }
    }
}
