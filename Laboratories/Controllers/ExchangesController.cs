using Laboratories.Database;
using Laboratories.Entities;
using Laboratories.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratories.Controllers
{
    public class ExchangesController : Controller
    {
        private readonly ExchangesDbContext _dbContext;

        public ExchangesController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Show()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ItemModel item)
        {
            var entity = new ItemEntity
            {
                Name = item.Name,
                Description = item.Description,
                IsVisible = item.IsVisible
            };

            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();

            var viewModel = new AddNewItemConfirmationViewModel
            {
                Id = 1,
                Name = item.Name,
            };
            //Post
            //return View("AddConfirmation", viewModel);

            // Post-Redirect-Get
            return RedirectToAction("AddConfirmation", new { itemId = 1,  });
        }

        [HttpGet]
        public IActionResult AddConfirmation(int itemId)
        {
            return View(itemId);
        }

        [HttpGet]
        public IActionResult ShowItems()
        {
            List<ItemModel> items = new List<ItemModel>();
            foreach(var key in _dbContext.Items)
            {
                items.Add(new ItemModel { Id = key.Id, Name = key.Name, Description = key.Description, IsVisible = key.IsVisible });
            }
            ViewData["Items"] = items;
            return View();
        }

    }
}
