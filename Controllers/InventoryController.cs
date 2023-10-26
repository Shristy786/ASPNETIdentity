using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETIdentity.Controllers
{
    [Authorize(Roles ="Admin")]
    public class InventoryController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
