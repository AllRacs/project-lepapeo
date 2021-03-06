using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LePapeo.Models
{
    public class ReservaViewModel
    {
        public int id { get; set; }

        [Display(Prompt = "id usuario", Description = "id usuario", Name = "Id_usuario")]
        [Required(ErrorMessage = "Debe indicar un n�mero de id usuario")]
        public int idusuario { get; set; }

        [Display(Prompt = "id restaurante", Description = "id restaurante", Name = "Id_restaurante")]
        [Required(ErrorMessage = "Debe indicar un n�mero de id restaurante")]
        public int idrestaurante { get; set; }

        [Display(Prompt = "N�mero de comensales", Description = "N�mero de comensales", Name = "Comensales")]
        [Required(ErrorMessage = "Debe indicar un n�mero de comensales")]
        public int comensales { get; set; }

        [Display(Prompt = "Estado de la reserva", Description = "Estado de la reserva (pendiente, aceptado, denegado)", Name = "Estado")]
        [Required(ErrorMessage = "No deber�a de dar error, como default se pone estado pendiente")]
        public LePapeoGenNHibernate.Enumerated.LePapeo.EstadoReservaEnum estado { get; set; }

        [Display(Prompt = "Reserva finalizada o no", Description = "En forma booleana muestra si la fecha de la reserva es anterior o posterior a fecha actual", Name = "Finalizada")]
        [Required(ErrorMessage = "La fecha introducida debe tener un formato dd/mm/aaaa")]
        public bool finalizada { get; set; }

        [Display(Prompt = "Fecha para la que se solicita la reserva", Description = "Fecha para la que se solicita la reserva, cuando quieren asistir los comensales", Name = "Fecha_hora")]
        [DataType(DataType.DateTime, ErrorMessage = "La fecha introducida debe tener un formato dd/mm/aaaa")]
        public DateTime fecha_hora { get; set; }

        [Display(Prompt = "Fecha de solicitud", Description = "Fecha en la que se solicita la reserva", Name = "Fecha solicitud")]
        [DataType(DataType.DateTime, ErrorMessage = "La fecha introducida debe tener un formato dd/mm/aaaa")]
        public DateTime fecha_solicitud { get; set; }
    }
}