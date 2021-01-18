﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAdminApp.Models
{
    public class ContactViewModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string Subject { get; set; }
        public string Content { get; set; }
    }
}