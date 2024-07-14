namespace LeetCodeSetup.LeetCodeProblems;
//Difficulty: EASY
public class PalindromeNum
{
    //Program.cs configuration
    /* 
     *  PalindromeNum palindromeNum = new PalindromeNum();
        bool result = palindromeNum.IsPalindrome(121);
        Console.WriteLine(result);
     */
    public bool IsPalindrome(int x)
    {
        int value = x;
        int reverse = 0;

        while (value > 0)
        {
            int digit = value % 10;
            reverse = reverse * 10 + digit;
            value /= 10;
        }

        if (reverse == x)
            return true;
        return false;
    }
}