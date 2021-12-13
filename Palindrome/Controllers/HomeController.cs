using Microsoft.AspNetCore.Mvc;
using Palindrome.Models;

namespace Palindrome.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Initial()
    {
      return View();
    }

    [Route("/result")]
    public ActionResult Result(string input)
    {
      PalindromeCheck pali = new PalindromeCheck(input);
      return View(pali);
    }
  }
}