﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string WebsiteUrl { get; set; }
        public string Bio { get; set; }
    }
}
