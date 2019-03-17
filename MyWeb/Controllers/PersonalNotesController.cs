using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using MyWebApp.Services;

namespace MyWebApp.Controllers
{   
    public class PersonalNotesController : Controller
    {
        private readonly PersonalNotesService _personalNotesService;

        public PersonalNotesController()
        {
            _personalNotesService = new PersonalNotesService();
        }

        public IActionResult Index()
        {
            var personalNotes = _personalNotesService.GetAll();
            return View(personalNotes);
        }

        [Route("[controller]/details/{id:int}")]
        [Route("[action]")]
        public IActionResult Details(int id)
        {
            PersonalNote note = _personalNotesService.GetById(id);

            return View(note);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PersonalNote personalNote)
        {
            if (!ModelState.IsValid)
            {
                return View(personalNote);
            }

            PersonalNote newPersonalNote = _personalNotesService.Create(personalNote);

            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            PersonalNote personalNote = _personalNotesService.GetById(id);
            return View(personalNote);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, PersonalNote personalNote)
        {
            _personalNotesService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}