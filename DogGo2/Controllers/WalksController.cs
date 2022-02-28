using DogGo2.Models;
using DogGo2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DogGo2.Controllers
{
    public class WalksController : Controller
    {
        //This allows us to get to our connection string
        private readonly IWalkRepository _walkRepo;
        private readonly IOwnerRepository _ownerRepo;
        private readonly IDogRepository _dogRepo;
        private readonly IWalkerRepository _walkerRepo;
        private readonly INeighborhoodRepository _neighborhoodRepo;

        // ASP.NET will give us an instance of our Walker Repository. This is called "Dependency Injection"
        public WalksController
            (IWalkRepository walkRepository,
             IOwnerRepository ownerRepository,
             IDogRepository dogRepository,
             IWalkerRepository walkerRepository,
             INeighborhoodRepository neighborhoodRepository
            )
        {
            _walkRepo = walkRepository;
            _ownerRepo = ownerRepository;
            _dogRepo = dogRepository;
            _walkerRepo = walkerRepository;
            _neighborhoodRepo = neighborhoodRepository;
        }
       
        // GET: WalkController
        public ActionResult Index()
        {
            List<Walks> walks = new List<Walks>();
            return View(walks);
        }

        // GET: WalkController/Details/5
        public ActionResult Details(int id)
        {
            Walks walk = _walkRepo.GetWalkById(id);

            if (walk == null)
            {
                return NotFound();
            }
            return View(walk);
        }

        // GET: WalkController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WalkController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WalkController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WalkController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WalkController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WalkController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
