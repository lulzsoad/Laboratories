using Laboratories.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratories.Controllers
{
    [ApiController][Route("api/Ajax")]
    public class AjaxAddingController : ControllerBase
    {
        public ItemModel Post(ItemModel item)
        {
            var receivedObject = new ItemModel() 
            { 
                Name = item.Name,
                Description = item.Description,
                IsVisible = item.IsVisible
            }; 

            return receivedObject;
        }
    }
}
