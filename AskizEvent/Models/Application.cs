using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AskizEvent.Models
{
    public class Application
    {
        [Key]
        public int Number { get; set; }
        public int ApplicantID { get; set; }
        public int ManagerID { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateCreate { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateEdit { get; set; }
        public int StatusID { get; set; }
        public string Massage { get; set; }
        public int EventID { get; set; }

    }
}
