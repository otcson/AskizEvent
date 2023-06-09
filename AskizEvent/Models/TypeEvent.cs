using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AskizEvent.Models
{
    public class TypeEvent
    {
        [Key]
        public int TypeEventID { get; set; }
        public string Name { get; set; }
    }
}
