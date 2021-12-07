using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace Models.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void Palindrome_StoresAString_String()
    {
      Palindrome test = new Palindrome("racecar");
      Assert.IsInstanceOfType(test.PaliString, typeof(string));
      Assert.AreEqual(test.PaliString, "racecar");
    }

    [TestMethod]
    public void IsPalindrome_ReturnsTrueForPalindrome_True()
    {
      Palindrome test = new Palindrome("racecar");
      Assert.AreEqual(true, test.IsPalindrome());
    }

    [TestMethod]
    public void IsPalindrome_ReturnsFalseForNotAPalindrome_False()
    {
      Palindrome test = new Palindrome("fudge");
      Assert.AreEqual(false, test.IsPalindrome());
    }

    [TestMethod]
    public void IsPalindromeTheHardWay_ReturnsTrueForPalindrome_True()
    {
      Palindrome test = new Palindrome("racecar");
      Assert.AreEqual(true, test.IsPalindromeTheHardWay());
    }

    [TestMethod]
    public void IsPalindromeTheHardWay_ReturnsFalseForNotAPalindrome_False()
    {
      Palindrome test = new Palindrome("fudge");
      Assert.AreEqual(false, test.IsPalindromeTheHardWay());
    }

    [TestMethod]
    public void IsPalindrome_WorksForNumbers_True()
    {
      Palindrome test = new Palindrome(101);
      Assert.AreEqual(true, test.IsPalindrome());
    }

    [TestMethod]
    public void IsPalindromeTheHardWay_WorksForNumbers_True()
    {
      Palindrome test = new Palindrome(101);
      Assert.AreEqual(true, test.IsPalindromeTheHardWay());
    }
  }
}