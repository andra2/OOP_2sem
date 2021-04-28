using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Lab5
{
    public class Plane
    {
        public List<CrewMember> Crew;

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
            Crew = new List<CrewMember>();
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

        public void DrawToGrid(DataGridView dataGrid) //пишет объект в датагрид
        {
            dataGrid.Rows.Add(
            this.Id.ToString(),
            this.creator,
            this.type.ToString(),
            this.NofSeats.ToString(),
            this.DateOfIssue.ToShortDateString(),
            this.carrying.ToString());
        }

        public Plane Copy()
        {
            Plane copy = (Plane)MemberwiseClone();

            copy.Id = this.Id;
            copy.Id++;
            copy.NofSeats = this.NofSeats;
            copy.type = this.type;
            copy.DateOfIssue = this.DateOfIssue;
            copy.creator = creator;
            copy.carrying = this.carrying;
            copy.Crew = new List<CrewMember>();
            foreach (CrewMember i in this.Crew)
            {
                Crew.Add(i);
            }
            return copy;
        }
    }
}
