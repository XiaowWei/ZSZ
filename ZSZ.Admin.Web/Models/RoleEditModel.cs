﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZSZ.Admin.Web.Models
{
    public class RoleEditModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long[] PermissionIds { get; set; }
    }
}