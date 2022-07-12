using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Arthes_2022.Data;
using Arthes_2022.Models.Entities;
using Arthes_2022.Data.Interfaces;

namespace Arthes_2022.Controllers
{
    public class RevistasController : Controller
    {
        private readonly IRevistaRepository _repository;

        public RevistasController(IRevistaRepository repository)
        {
            _repository = repository;
        }

        // GET: Revistas
        public async Task<IActionResult> Index()
        {
            return View(await _repository.GetRevistasToList());
        }


        // GET: Revistas/Details/5
        public async Task<IActionResult> Details(int id)
        {
             return View(await _repository.DetailsRevistas(id));
        }

    }
}
