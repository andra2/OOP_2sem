using System.ComponentModel.DataAnnotations;

namespace Lab5
{

    interface IAirportCrew
    {
        string Name{ get; set; }
        int Age { get; set; }
    }
    public abstract class CrewMember : IAirportCrew
    {
        [Required(ErrorMessage = "Не заданы ФИО", AllowEmptyStrings = false)]
        [StringLength(70, MinimumLength = 1, ErrorMessage = "Слишком короткое ФИО")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Отсутствует должность", AllowEmptyStrings = false)]
        [StringLength(70, MinimumLength = 1, ErrorMessage = "Слишком короткая должность")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Возраст не задан")]
        [Range(18, 100, ErrorMessage = "Возраст должен быть от 18 до 100")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Опыт работы не задан")]
        [Range(0, 100, ErrorMessage = "Опыт работы должен быть от 0 до 80")]
        public int Experience { get; set; }
    }
}
