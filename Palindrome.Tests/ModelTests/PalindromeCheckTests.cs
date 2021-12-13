using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;

namespace Palindrome.Models.Tests
{
  [TestClass]
  public class PalindromeCheckTests
  {
    [TestMethod]
    public void Palindrome_StoresAString_String()
    {
      PalindromeCheck test = new PalindromeCheck("racecar");
      Assert.IsInstanceOfType(test.PaliString, typeof(string));
      Assert.AreEqual(test.PaliString, "racecar");
    }

    [TestMethod]
    public void IsPalindrome_ReturnsTrueForPalindrome_True()
    {
      PalindromeCheck test = new PalindromeCheck("racecar");
      Assert.AreEqual(true, test.IsPalindrome());
    }

    [TestMethod]
    public void IsPalindrome_ReturnsFalseForNotAPalindrome_False()
    {
      PalindromeCheck test = new PalindromeCheck("fudge");
      Assert.AreEqual(false, test.IsPalindrome());
    }

    [TestMethod]
    public void IsPalindromeTheHardWay_ReturnsTrueForPalindrome_True()
    {
      PalindromeCheck test = new PalindromeCheck("racecar");
      Assert.AreEqual(true, test.IsPalindromeTheHardWay());
    }

    [TestMethod]
    public void IsPalindromeTheHardWay_ReturnsFalseForNotAPalindrome_False()
    {
      PalindromeCheck test = new PalindromeCheck("fudge");
      Assert.AreEqual(false, test.IsPalindromeTheHardWay());
    }

    [TestMethod]
    public void IsPalindrome_WorksForNumbers_True()
    {
      PalindromeCheck test = new PalindromeCheck(101);
      Assert.AreEqual(true, test.IsPalindrome());
    }

    [TestMethod]
    public void IsPalindromeTheHardWay_WorksForNumbers_True()
    {
      PalindromeCheck test = new PalindromeCheck(101);
      Assert.AreEqual(true, test.IsPalindromeTheHardWay());
    }
  }
}