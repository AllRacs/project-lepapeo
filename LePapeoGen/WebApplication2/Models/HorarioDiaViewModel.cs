using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LePapeo.Models
{
    public class HorarioDiaViewModel
    {
        [ScaffoldColumn(false)]
        public int id { get; set; }

        [Display(Prompt = "Fecha de apertura por la mañana", Description = "Hora de apertura por la mañana", Name = "Hora de apertura am")] 
        [DataType(DataType.Time, ErrorMessage = "La fecha introducida debe tener un formato dd/mm/aaaa")]
        public DateTime Hora_ini_am { get; set; } 

        [Display(Prompt = "Fecha de cierre por la mañana", Description = "Hora de cierre por la mañana", Name = "Hora de cierre am")]
        [DataType(DataType.Time, ErrorMessage = "La fecha introducida debe tener un formato dd/mm/aaaa")]
        public DateTime Hora_fin_am { get; set; }

        [Display(Prompt = "Fecha de apertura por la tarde", Description = "Hora de apertura por la tarde", Name = "Hora de apertura pm")]
        [DataType(DataType.Time, ErrorMessage = "La fecha introducida debe tener un formato dd/mm/aaaa")]
        public DateTime Hora_ini_pm { get; set; }

        [Display(Prompt = "Fecha de cierre por la tarde", Description = "Hora de cierre por la tarde", Name = "Hora de cierre pm")]
        [DataType(DataType.Time, ErrorMessage = "La fecha introducida debe tener un formato dd/mm/aaaa")]
        public DateTime Hora_fin_pm { get; set; }

        [Display(Prompt = "Dia de la semana", Description = "Dia de la semana", Name = "Dia")]
        [Required(ErrorMessage = "Debe indicar una dia para el horario semana")]
        public LePapeoGenNHibernate.Enumerated.LePapeo.DiaSemanaEnum Dia { get; set; }

        [Display(Prompt = "Horario de la semana", Description = "Horario de la semana", Name = "Semana ")]
        [Required(ErrorMessage = "Debe indicar un HorarioSemana para el HorarioDia")]
        public int HorarioSemana { get; set; }


    }
}