using System;
using System.Threading.Tasks;
using EstateApp.Web.Interfaces;
using EstateApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstateApp.Web.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly IPropertyService _propertyService;
        public PropertiesController( IPropertyService propertyService) 
        {
             _propertyService = propertyService;

        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(PropertyModel model) 
        {
            if(!ModelState.IsValid) return View();
            try
            {
               await _propertyService.AddProperty(model);
               return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
} 