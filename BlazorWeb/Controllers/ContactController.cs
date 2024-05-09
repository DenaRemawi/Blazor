using BlazorWeb.Data;
using BlazorWeb.Reposetry;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWeb.Controllers
{
    public class ContactController : Controller
    {
        IContactReposetry contactReposetry;
        public ContactController(IContactReposetry _ContactReposetry)
        {
            contactReposetry = _ContactReposetry;

        }
        public IActionResult Index()
        {
            List<Contact> contacts = contactReposetry.GetAllContact();

            return View("Index", contacts);
        }  
        
        public IActionResult NewContact()
        {

            return View();
        }

        public IActionResult Removes(int id)
        {
            contactReposetry.Removes(id);
            List<Contact> contacts = contactReposetry.GetAllContact();
            return View("Index", contacts);
        }


        //public IActionResult SaveContact(Contact contact)
        //{


        //    if (ModelState.IsValid == true)
        //    {
        //        contactReposetry.Inseart(contact);
        //    }
        //    List<Contact> contacts = contactReposetry.GetAllContact();
        //    return View("Index", contacts);
        //}

        public IActionResult SaveContact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                contactReposetry.Inseart(contact);

                return RedirectToAction("Index");
            }

            return View("NewContact", contact);
        }


        public IActionResult EditContact(int id)
        {
            var contact = contactReposetry.GetContactById(id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        } 
        
        public IActionResult UpdateContact(Contact contact)
        {
            contactReposetry.UpdateContact(contact);

            List<Contact> contacts = contactReposetry.GetAllContact();
            return View("Index", contacts);
        }


    }
}
    

