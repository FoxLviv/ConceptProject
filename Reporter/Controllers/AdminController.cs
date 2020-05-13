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
using Reporter.BL.Services.Persons;
using AutoMapper;
using Reporter.Common.DTOs.Person;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reporter.UI.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<PersonEntity> _userManager;
        private IPasswordHasher<PersonEntity> _passwordHasher;

        private readonly IPersonService _personService;
        readonly IMapper _mapper;

        public AdminController(UserManager<PersonEntity> usrMgr, IMapper mapper, IPersonService personService, IPasswordHasher<PersonEntity> passwordHasher)
        {
            _userManager = usrMgr;
            _passwordHasher = passwordHasher;

            _mapper = mapper;
            _personService = personService;

        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var test = _userManager.Users;
            IQueryable<PersonViewModel> result = from person in test
                                                 select new PersonViewModel{
                                                     Id = person.Id,
                                                     Name = person.UserName,
                                                     FirstName = person.FirstName,
                                                     LastName = person.LastName,
                                                     DepartmentId = 1,
                                                     FacultieId = 1,
                                                     Email = person.Email,
                                                     Password = person.PasswordHash,
                                                 };
            return View(result);
        }

        public ViewResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(PersonViewModel person)
        {
            if (this.ModelState.IsValid)
            {
                var appUser = new PersonEntity
                {
                    UserName = person.Name,
                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    DepartmentId = 1,
                    FacultieId = 1,
                    Email = person.Email,
                };
                //var res = _mapper.Map<PersonEntity>(appUser);
                IdentityResult result = await this._userManager.CreateAsync(appUser, person.Password);
                if (result.Succeeded)
                {
                    return this.RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        this.ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            return View(person);
        }

        public async Task<IActionResult> Update(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                PersonViewModel personView = new PersonViewModel
                {
                    Id = user.Id,
                    Name = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    DepartmentId = 1,
                    FacultieId = 1,
                    Email = user.Email,
                    Password = user.PasswordHash,
                };
                return View(personView);
            }
            else
                return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(string id, string email, string password)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                if (!string.IsNullOrEmpty(email))
                    user.Email = email;
                else
                    ModelState.AddModelError("", "Email cannot be empty");

                if (!string.IsNullOrEmpty(password))
                    user.PasswordHash = _passwordHasher.HashPassword(user, password);
                else
                    ModelState.AddModelError("", "Password cannot be empty");

                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
                {
                    IdentityResult result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                        Errors(result);
                }
            }
            else
                ModelState.AddModelError("", "User Not Found");

            PersonViewModel personView = new PersonViewModel
            {
                Id = user.Id,
                Name = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                DepartmentId = 1,
                FacultieId = 1,
                Email = user.Email,
                Password = user.PasswordHash,
            };

            return View(personView);
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            await _personService.DeletePersonAsync(id);

            var test = _userManager.Users;
            IQueryable<PersonViewModel> resultVM = from person in test
                                                 select new PersonViewModel
                                                 {
                                                     Id = person.Id,
                                                     Name = person.UserName,
                                                     FirstName = person.FirstName,
                                                     LastName = person.LastName,
                                                     DepartmentId = 1,
                                                     FacultieId = 1,
                                                     Email = person.Email,
                                                     Password = person.PasswordHash,
                                                 };
            return View("Index", resultVM);
        }
    }
}
