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
  }
}