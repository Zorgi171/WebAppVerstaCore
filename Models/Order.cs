using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppVerstaCore.Models
{
    public class Order
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Не указан город отправителя")]
        public string City_Sender { get; set; }

        [Required(ErrorMessage = "Не указан адрес отправителя")]
        public string Address_Sender { get; set; }

        [Required(ErrorMessage = "Не указан город получателя")]
        public string City_Addressee { get; set; }

        [Required(ErrorMessage = "Не указан адрес получателя")]
        public string Address_Addressee { get; set; }

        [Required(ErrorMessage = "Не указан вес груза")]
        public float Weight_Cargo { get; set; }

        [Required(ErrorMessage = "Не указана дата забора груза")]
        [DataType(DataType.Date)]

        public DateTime Fence_Date { get; set; }
    }
}
