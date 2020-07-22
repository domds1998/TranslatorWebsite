using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TranslatorWebsite.Services;

namespace TranslatorWebsite.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersDbService _service;

        public UsersController(IUsersDbService service)
        {
            _service = service;
        }

        public IActionResult GetUser()
        {
            return View(_service.GetUsers());
        }
    }
}