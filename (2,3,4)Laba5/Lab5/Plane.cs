using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Lab5
{

    public enum PlaneState
    {
        Flies,
        OnTheGrnd
    }
    public class Plane
    {
        public List<CrewMember> Crew;

        public PlaneState State { get; set; }

        [Required(ErrorMessage = "Не задано количество мест")]
        [Range(0, 300, ErrorMessage = "Недопустимое количество мест")]
        public int NofSeats { get; set; }

        [Required(ErrorMessage = "Не задана дата производства")]
        public DateTime DateOfIssue { get; set; }

        [Required(ErrorMessage = "Не задана грузоподъемность")]
        [Range(0, 300, ErrorMessage = "Недопустимая грузоподьемность")]
        public string carrying { get; set; }

        [Required(ErrorMessage = "Не задан производитель")]
        public string creator { get; set; }

        [Required(ErrorMessage = "Не задан ID")]
        [MyIdAttribute]
        public int Id { get; set; }
        public Plane()
        {
            Crew = new List<CrewMember>();
            State = PlaneState.OnTheGrnd;
        }
        private Plane(int id, string creator, Plane.Type type, int seats, DateTime date, string carry,PlaneState st)
        {
            this.Id = id;
            this.State = st;
            this.carrying = carry;
            this.creator = creator;
            this.DateOfIssue = date;
            this.NofSeats = seats;
            this.type = type;
            Crew = new List<CrewMember>();
        }
        public enum Type
        {
            passenger,
            cargo,
            military
        }
        [Required]
        public Type type { get; set; }
        public enum Model
        {
            AIRBUS,
            Boeing,
            Raytheon
        }

        public void DrawToGrid(DataGridView dataGrid) //пишет объект в датагрид
        {
            string st;
            if (this.State == PlaneState.OnTheGrnd)
            {
                st = "На земле";
            }
            else
            {
                st = "Летит";
            }
            dataGrid.Rows.Add(
                this.Id.ToString(),
                this.creator,
                this.type.ToString(),
                this.NofSeats.ToString(),
                this.DateOfIssue.ToShortDateString(),
                this.carrying.ToString(),"",
                st);
        }

        public Plane Copy() //prototype
        {
            Plane copy = new Plane(this.Id,this.creator,this.type,this.NofSeats,this.DateOfIssue,this.carrying,this.State);
            copy.Id++;
            foreach (CrewMember i in this.Crew)
            {
                copy.Crew.Add(i);
            }
            return copy;
        }
    }
}
