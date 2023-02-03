using AdressBook.Data;
using AdressBook.Models;
using AdressBook.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace AdressBook.Controllers
{
    public class ContactsController : Controller
    {
        private ABDbContext Dbcontext { get; }

        public ContactsController(ABDbContext dbcontext)
        {
            this.Dbcontext = dbcontext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddContactViewModel newContact)
        {
            var contact = new Contact(newContact);
            await Dbcontext.Contacts.AddAsync(contact);
            await Dbcontext.SaveChangesAsync();
            return RedirectToAction("Add");
        }

    }
}
