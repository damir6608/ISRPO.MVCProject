using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ISRPO.MVCProject.Models
{
    public class Customer
    {
        public long Id { get; set; }

        [Required(ErrorMessage ="Веддите имя")]
        [Display(Name ="Имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Веддите фамилию")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Веддите отчество")]
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Required(ErrorMessage = "Веддите адрес")]
        [Display(Name = "Адрес")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Веддите номер карты")]
        [Range(10000000, 99999999)]
        [Display(Name = "Номер карты")]
        public long? CardNumber { get; set; }

        [Required(ErrorMessage = "Веддите номер банковского счета")]
        [Range(10000000,99999999)]
        [Display(Name = "Номер банковского счета")]
        public long? BankAccount { get; set; }

    }


}
