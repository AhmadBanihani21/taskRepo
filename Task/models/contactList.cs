using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public  class contactList
    {
        public static List<Contact> Contacts { get; set; } = new List<Contact> {
           new Contact {Id=0,firstName="ahmad",lastName="mahmoud",email="ahmad@email.com",phoneNumber="0123456789"},
           new Contact {Id=1,firstName="osama",lastName="mahmoud",email="osama@email.com",phoneNumber="0792119858"},
            };
    }
}
