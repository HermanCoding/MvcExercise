using Microsoft.AspNetCore.Mvc;
using MvcExercise.Models;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Collections.Generic;

namespace MvcExercise.Controllers
{
    public class DogsController : Controller
    {
        private readonly ILogger<DogsController> _logger;

        public DogsController(ILogger<DogsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        static List<DogsModel> dogs = new List<DogsModel>
        {
            new DogsModel { Id = 1, Name = "Bark Twain", Cuteness = 9, Image = "doggo 01", FavFood = "Barkoni", FavToy = "Barkle", Temperament = 7, IsAdopted = false },
            new DogsModel { Id = 2, Name = "Sir Waggington", Cuteness = 8, Image = "doggo 02", FavFood = "Pawsta", FavToy = "Fetch Stick", Temperament = 6, IsAdopted = false },
            new DogsModel { Id = 3, Name = "Furball", Cuteness = 6, Image = "doggo 03", FavFood = "B one Appetit", FavToy = "Squeaky Ball", Temperament = 8, IsAdopted = false },
            new DogsModel { Id = 4, Name = "Princess Paws", Cuteness = 10, Image = "doggo 04", FavFood = "Royal Canin", FavToy = "Diamond Collar", Temperament = 5, IsAdopted = false },
            new DogsModel { Id = 5, Name = "Biscuit", Cuteness = 7, Image = "doggo 05", FavFood = "P upcakes", FavToy = "Chewy Bone", Temperament = 9, IsAdopted = false },
            new DogsModel { Id = 6, Name = "Daisy", Cuteness = 4, Image = "doggo 06", FavFood = "Doggi e Delight", FavToy = "Plush Squirrel", Temperament = 3, IsAdopted = false },
            new DogsModel { Id = 7, Name = "Captain Woof", Cuteness = 6, Image = "doggo 07", FavFood = "Fish 'n Chips", FavToy = "Nautical Rope", Temperament = 8, IsAdopted = false },
            new DogsModel { Id = 8, Name = "Snuggle Paws", Cuteness = 9, Image = "doggo 08", FavFood = "Cuddle Crunchies", FavToy = "Soft Blanket", Temperament = 7, IsAdopted = false },
            new DogsModel { Id = 9, Name = "Rocky", Cuteness = 3, Image = "doggo 09", FavFood = "Steak Bites", FavToy = "Tennis Ball", Temperament = 4, IsAdopted = false },
            new DogsModel { Id = 10, Name = "Lola", Cuteness = 5, Image = "doggo 10", FavFood = "Treat Tower", FavToy = "Squeaky Duck", Temperament = 6, IsAdopted = false },
            new DogsModel { Id = 11, Name = "Maximus", Cuteness = 8, Image = "doggo 11", FavFood = "Beefy Bites", FavToy = "Tug Rope", Temperament = 9, IsAdopted = false },
            new DogsModel { Id = 12, Name = "Roxy", Cuteness = 7, Image = "doggo 12", FavFood = "Chick en Chewies", FavToy = "Frisbee", Temperament = 4, IsAdopted = false },
            new DogsModel { Id = 13, Name = "Teddy", Cuteness = 2, Image = "doggo 13", FavFood = "Car rot Crunch", FavToy = "Plush Bunny", Temperament = 2, IsAdopted = false },
            new DogsModel { Id = 14, Name = "Coco", Cuteness = 6, Image = "doggo 14", FavFood = "Cocon ut Chew", FavToy = "Ball Launcher", Temperament = 8, IsAdopted = false }
        };

        public IActionResult Dogs()
        {
			List<DogsModel> sortedDogs = dogs.OrderBy(d => d.Name).ToList();

			return View(sortedDogs);
        }

        public IActionResult Details(int id)
        {
            DogsModel? dog = dogs.FirstOrDefault(d => d.Id == id);
            return View(dog);
        }

        public IActionResult Congratulations(int id)
        {
            // update dog in the database to be adopted

			DogsModel? dog = dogs.FirstOrDefault(d => d.Id == id);
            if(dog != null)
            {
                dog.IsAdopted = true;
            }
			return View(dog);
		}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}