﻿using Hotel_App.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Models.ViewModels
{
    public class RoomIndexViewModel
    {
        public Room Room { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
