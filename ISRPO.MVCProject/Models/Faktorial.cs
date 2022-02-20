using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ISRPO.MVCProject.Models
{
    public class Faktorial
    {
        [Display(Name ="Результат подсчета факториала: ")]
        public double? answer { get; set; }

        [Display(Name = "Введите факториал какого числа: ")]
        public int? n { get; set; }

        public double? Calculate(int n)
        {
            answer = 1;
            for(int i = 2; i <= n; i++)
            {
                answer *= i;
            }
            return answer;
        }
    }
}
