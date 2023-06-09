using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AskizEvent.Models
{
    public class Event
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Наименование мероприятия")]
        [Required(ErrorMessage ="Введите наименование мероприятия.")]
        public string Name { get; set; }
        [DisplayName("Дата")]
        [Required(ErrorMessage = "Введите дату мероприятия.")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DisplayName("Описание")]
        [Required(ErrorMessage = "Введите описание мероприятия.")]
        public string Description { get; set; }
        [DisplayName("Тип мероприятия")]
        [Required(ErrorMessage = "Введите тип мероприятия.")]
        public int TypeID { get; set; }


        public TypeEvent TypeEvents { get; set; }
    }
}
