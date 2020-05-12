using System;
using System.Collections.Generic;
using System.Linq;
using Reporter.UI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Reporter.DL.Entities;
using Reporter.Common.DTOs;
using Reporter.Common.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reporter.UI.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<PersonEntity> _userManager;

        public AdminController(UserManager<PersonEntity> usrMgr)
        {
            _userManager = usrMgr;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(PersonViewModel person)
        {
            if (ModelState.IsValid)
            {
                PersonEntity appUser = new PersonEntity
                {
                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    DepartmentId = person.DepartmentId,
                    FacultieId = person.FacultieId,
                    Email = person.Email
                };

                IdentityResult result = await _userManager.CreateAsync(appUser, person.Password);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                {
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
            }
            return View(person);
        }
    }
}
