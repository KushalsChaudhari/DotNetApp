namespace WebApp.Controllers;

public class InterestController : Controller
{
    //double si;

    public IActionResult Index()
    {
        ViewBag.SI = 0;
        return View("Index");
    }
    
    [HttpPost]
    public IActionResult CalculateSI(int p, int n , float r)
    {
        ViewBag.SI = p * n * r / 100;
         
        return (View("Index"));

    }
}