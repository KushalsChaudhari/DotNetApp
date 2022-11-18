namespace WebApp.Controllers;

public class ServiceInterestController : Controller
{
    public IActionResult Index()
    {
        return View("Welcome");
    }

public IActionResult CalculateSI(int p , int n , float r, [FromServices] Services.IInterest sip)
    {
        ViewBag.SI = sip.SI(p,n,r);
        return View("Welcome");
    }

}