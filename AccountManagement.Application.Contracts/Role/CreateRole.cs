﻿using _0_Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Application.Contracts.Role
{
    public class CreateRole
    {
        public string Title { get; set; }
        public List<int> Permissions { get; set; }

    }
}
