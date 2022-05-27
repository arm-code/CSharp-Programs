/*
* THIS PROGRAM PARSE NATURAL NUMBERS TO BINARY. AND THEN SHOW THE TOTAL "ONES" CONSECUTIVES. 
*/
class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        int aux = 0;
        int digit = 0;
        int zeros = 0;
        int ones = 0;
        while (n > 0){
            digit = n%2;
            n = n/2;
            if (digit == 1){
                zeros++;
                if(zeros >= ones){
                    ones = zeros;
                }
            }else{
                zeros = 0;
            }
        }
        Console.WriteLine(ones);
    }
}
