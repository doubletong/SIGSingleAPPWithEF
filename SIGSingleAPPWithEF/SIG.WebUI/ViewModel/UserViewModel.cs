﻿using SIG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIG.ViewModel
{
    public class UserViewModel
    {
        public User User { get; set; }
        public IEnumerable<Ribbit> Ribbits { get; set; }
    }
}