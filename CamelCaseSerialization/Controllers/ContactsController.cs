using System.Collections.Generic;
using System.Web.Http;
using CameCaseSerialization.Models;

namespace CameCaseSerialization.Controllers
{
    public class ContactsController : ApiController
    {
        private static readonly Contact[] Contacts =
        {
            new Contact {FirstName = "Alex", LastName = "Wolf", Phone = "18073028765" },
            new Contact {FirstName = "John", LastName = "Smith", Phone = "18028817721" }
        };

        public IEnumerable<Contact> Get()
        {
            // TODO get from DB
            var contacts = Contacts;
            
            return contacts;
        }
    }
}