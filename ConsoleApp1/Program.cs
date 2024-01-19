namespace ConsoleApp1;

class Program
{
    static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] == target - nums[i])
                {
                    return [i, j];
                }
            }
        }

        return [];
    }

    static int MaximumProductDifference(int[] nums)
    {
        int lastIndex = nums.Length - 1;
        int penultimateIndex = lastIndex - 1;
        Array.Sort(nums);
        Array.Reverse(nums);

        return (nums[0] * nums[1]) - (nums[penultimateIndex] * nums[lastIndex]);
    }
    
    static void Main(string[] args)
    {
        int number = -121;
        char[] letters = number.ToString().ToCharArray();
        Array.Reverse(letters);
        
        int.TryParse(new string(letters), out int reversed);

        if (number == reversed)
            Console.WriteLine("Is palindrome");
        else
            Console.WriteLine("Is not palindrome");
    }
}
    










