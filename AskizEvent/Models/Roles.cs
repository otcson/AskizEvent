﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AskizEvent.Models
{
    public class Roles
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
