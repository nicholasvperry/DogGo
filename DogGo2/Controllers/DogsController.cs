using DogGo2.Models;
using DogGo2.Repositories;
using DogGo2.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace DogGo2.Controllers
{
    public class DogsController : Controller
    {
        //This allows us to get to our connection string
        private readonly IOwnerRepository _ownerRepo;
        private readonly IDogRepository _dogRepo;
        private readonly IWalkerRepository _walkerRepo;
        private readonly INeighborhoodRepository _neighborhoodRepo;

        // ASP.NET will give us an instance of our Walker Repository. This is called "Dependency Injection"
        public DogsController(
            IOwnerRepository ownerRepository,
            IDogRepository dogRepository,
            IWalkerRepository walkerRepository,
            INeighborhoodRepository neighborhoodRepository
            )
        {
            _ownerRepo = ownerRepository;
            _dogRepo = dogRepository;
            _walkerRepo = walkerRepository;
            _neighborhoodRepo = neighborhoodRepository;
        }
        // GET: DogController. Use method to only show current users information
        [Authorize]
        public ActionResult Index()
        {
            int ownerId = GetCurrentUserId();

            List<Dog> dogs = _dogRepo.GetDogsByOwnerId(ownerId);

            return View(dogs);
        }

        // GET: DogController/Details/5
        [Authorize]
        public ActionResult Details(int id)
        {
            int ownerId = GetCurrentUserId();
            
            Dog dog = _dogRepo.GetDogById(id);


            if (dog == null)
            {
                return NotFound();
            }
            else if (dog.OwnerId != ownerId)
            {

                return NotFound();
            }
            else
            {
                return View(dog);
            }
            
               
            
            
        }

        // GET: DogController/Create
        [Authorize]
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: DogController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create(Dog dog)
        {
            try
            {
                // update the dogs OwnerId to the current user's Id 
                dog.OwnerId = GetCurrentUserId();
                _dogRepo.AddDog(dog);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(dog);
            }
        }

        // GET: DogController/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            int ownerId = GetCurrentUserId();
            List<Owner> owners = _ownerRepo.GetAllOwners();
            Dog dog = _dogRepo.GetDogById(id);

            DogFormViewModel vm = new DogFormViewModel()
            {
                Dog = dog,
                Owners = owners
            };
            
            if (dog == null || dog.OwnerId != ownerId)
            {
                return NotFound();
            }
            
                return View(vm);
            
           

        }

        // POST: DogController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit(int id, Dog dog)
        {
            int ownerId = GetCurrentUserId();
            List<Owner> owners = _ownerRepo.GetAllOwners();
            DogFormViewModel vm = new DogFormViewModel()
            {
                Dog = dog,
                Owners = owners
            };

            if (dog == null || dog.OwnerId != ownerId)
            {
                return NotFound();
            }
            else
            {

                try
                {
                    _dogRepo.UpdateDog(dog);

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return View(vm);
                }
            }
        }

        // GET: DogController/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            int ownerId = GetCurrentUserId();

            Dog dog = _dogRepo.GetDogById(id);
            if (dog.OwnerId != ownerId)
            {
                return NotFound();
            }
            else
            {
                return View(dog);
            }
            
        }

        // POST: DogController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Dog dog)
        {
            
                try
                {
                    _dogRepo.DeleteDog(id);

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return View();
                }
            
        }


        //Lets us get current user data
        private int GetCurrentUserId()
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return int.Parse(id);
        }
    }
}
