using DataAccess.Repositories;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Presentation.Models;

namespace Presentation.Controllers
{
    public class PollsController: Controller
    {
        private PollRepository _pollRepository;

        // Constructor injection for PollRepository
        public PollsController(PollRepository pollRepository)
        {
            _pollRepository = pollRepository;
        }

        // GET: Polls
        [HttpGet]
        public IActionResult Create()
        {
            // Initialize a new PollCreateViewModel
            PollCreateViewModel pollCreateViewModel = new PollCreateViewModel();

            return View(pollCreateViewModel);
        }

        // POST: Polls
        [HttpPost]
        public IActionResult Create(PollCreateViewModel model)
        {
            // Check if the model state is valid
            if (ModelState.IsValid)
            {
                // Add the new poll to the repository
                _pollRepository.AddPoll(model.Poll);
                TempData["Success"] = "Poll created successfully";
                return RedirectToAction("Index");
            }

            // If the model state is not valid, return to the view with the model
            TempData["Error"] = "Please check all the fields";
            return View(model);

        }

    }
}
