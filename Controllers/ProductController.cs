using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETIdentity.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
