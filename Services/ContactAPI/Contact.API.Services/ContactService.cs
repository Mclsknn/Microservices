﻿using Contact.API.Infrastructure;
using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactByID(int Id)
        {
            return new ContactDTO { Id = Id, FirstName = "Mustafa", LastName = "Çalışkan" };
        }
    }
}
