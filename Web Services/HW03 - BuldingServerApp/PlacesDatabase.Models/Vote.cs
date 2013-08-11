﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacesDatabase.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int PlaceId { get; set; }
        public string Username { get; set; }
        public virtual Place Place { get; set; }
    }

}
