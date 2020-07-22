using Microsoft.AspNetCore.Mvc;
using TranslatorWebsite.Services;

namespace TranslatorWebsite.Controllers
{
    public class WordsController : Controller
    {
        private readonly IWordsDbService _service;

        public WordsController(IWordsDbService service)
        {
            _service = service;
        }
    }
}