﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class User
    {
        public Guid Id { get; set; }
        public string? FirstName {get; set;}

        public string? LastName { get; set;}

        public string? Email { get; set; }

        public int Age { get; set; }

        public string? DateOfBirth { get; set;}
    }
}
