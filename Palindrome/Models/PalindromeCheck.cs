using System;

namespace Palindrome.Models
{
  public class PalindromeCheck
  {
    public string PaliString { get; set; }
    public PalindromeCheck(string paliString)
    {
      PaliString = paliString;
    }

    public PalindromeCheck(int paliInt)
    {
      PaliString = paliInt.ToString();
    }

    public bool IsPalindrome()
    {
      char[] backwards = PaliString.ToCharArray();
      Array.Reverse(backwards);
      string backwardsString = new string(backwards);

      return PaliString == backwardsString;
    }

    public bool IsPalindromeTheHardWay()
    {
      for (int i = 0; i < PaliString.Length; i++)
      {
        if (PaliString[i] != PaliString[PaliString.Length - i - 1])
        {
          return false;
        }
      }
      return true;
    }
  }
}

