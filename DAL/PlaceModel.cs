﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    class PlaceModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }       
        public string Address { get; set; }
        public int CountRow { get; set; }
        public int CountSeatInRow { get; set; }
    }
}
