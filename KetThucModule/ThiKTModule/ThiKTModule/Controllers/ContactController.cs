using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactManagement.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository contactRepository;

        IEnumerable<Contact> Contacts { get; set; }

        public ContactController(IContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        public IActionResult Index(string SearchStudent)
        {
            if (SearchStudent == null)
            {
                Contacts = contactRepository.GetAll();
            }
            else
            {
                Contacts = contactRepository.GetContactByName(SearchStudent);
            }

            return View(Contacts);
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind] Contact contact)
        {
            if (ModelState.IsValid)
            {
                contactRepository.Add(contact);
                contactRepository.Commit();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Detail(int id)
        {
            var contact = contactRepository.GetById(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        [HttpGet]
        public IActionResult Delete(int? id, Contact contact)
        {
            if (id.HasValue)
            {
                contact = contactRepository.GetById(id.Value);
            }

            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
                contactRepository.Delete(contact.Id);
                contactRepository.Commit();
                return RedirectToAction("Index", new { id = contact.Id});
        }
    }
}