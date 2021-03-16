using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class CrewMember
    {
        [Required(ErrorMessage = "Не заданы ФИО", AllowEmptyStrings = false)]
        [StringLength(70, MinimumLength = 1, ErrorMessage = "Слишком короткое ФИО")]
        public string Name;

        [Required(ErrorMessage = "Отсутствует должность", AllowEmptyStrings = false)]
        [StringLength(70, MinimumLength = 1, ErrorMessage = "Слишком короткая должность")]
        public string position;

        [Required(ErrorMessage = "Возраст не задан")]
        [Range(18, 100, ErrorMessage = "Возраст должен быть от 18 до 100")]
        public int Age;

        [Required(ErrorMessage = "Опыт работы не задан")]
        [Range(0, 100, ErrorMessage = "Опыт работы должен быть от 0 до 80")]
        public int Experience;
    }
}
