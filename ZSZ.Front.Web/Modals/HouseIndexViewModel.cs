﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZSZ.DTO;

namespace ZSZ.Front.Web.Modals
{
    public class HouseIndexViewModel
    {
        public HouseDTO House { get; set; }
        public HousePicDTO[] Pics { get; set; }
        public AttachmentDTO[] Attachments { get; set; }

    }
}