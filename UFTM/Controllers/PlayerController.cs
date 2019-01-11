using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace UFTM.Controllers
{
    public class PlayerController : Controller
    {
        public PlayerController()
        {
        }

        public IActionResult Players()
        {
            return View();
        }
    }
}
