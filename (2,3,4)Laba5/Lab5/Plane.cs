using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab5
{
    public class Plane
    { 
        public LinkedList<CrewMember> Crew;

        [Required(ErrorMessage = "Не задано количество мест")]
        [Range(0, 300, ErrorMessage = "Недопустимое количество мест")]
        public int NofSeats;

        [Required(ErrorMessage = "Не задана дата производства")]
        public DateTime DateOfIssue;

        [Required(ErrorMessage = "Не задана грузоподъемность")]
        [Range(0, 300, ErrorMessage = "Недопустимая грузоподьемность")]
        public string carrying;

        [Required(ErrorMessage = "Не задан производитель")]
        public string creator;

        [Required(ErrorMessage = "Не задан ID")]
        [MyIdAttribute]
        public int Id { get; set; }
        public Plane()
        {
            type = Type.passenger;
            Id = 1;
            DateOfIssue = DateTime.Now;
            creator = "AIRBUS";
            carrying = "15 т.";
            Crew = new LinkedList<CrewMember>();
            NofSeats = 2;
        }
        public enum Type
        {
            passenger,
            cargo,
            military
        }
        [Required]
        public Type type;
        public enum Model
        {
            AIRBUS,
            Boeing,
            Raytheon
        }
    }
}
