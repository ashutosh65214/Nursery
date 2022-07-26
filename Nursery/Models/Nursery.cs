﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nursery.Models
{
    public class Nursery
    {
        public int Id { get; set; }
        public int SKU_NO { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime CreatedDate { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}