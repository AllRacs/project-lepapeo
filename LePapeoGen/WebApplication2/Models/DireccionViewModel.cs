using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LePapeo.Models
{
    public class DireccionViewModel
    {
        [Display(Prompt = "id", Description = "id", Name = "Id")]
        [Required(ErrorMessage = "Debe indicar un id")]
        public int id { get; set; }

        [Display(Prompt = "Ciudad", Description = "Ciudad", Name = "Ciudad")]
        [Required(ErrorMessage = "Debe indicar una ciudad")]
        public String ciudad { get; set; }

        [Display(Prompt = "Provincia", Description = "Provincia", Name = "Provincia")]
        [Required(ErrorMessage = "Debe indicar una provincia")]
        public String provincia { get; set; }

        [Display(Prompt = "C�digo postal", Description = "C�digo postal", Name = "Cod_postal")]
        [Required(ErrorMessage = "Debe indicar un c�digo postal v�lido")]
        [StringLength(maximumLength: 5, ErrorMessage = "El texto debe tener una longitud de 5")]
        public String cod_pos { get; set; }

        [Display(Prompt = "Calle", Description = "Calle, Avda., Boulevard, ...", Name = "Calle")]
        [Required(ErrorMessage = "No deber�a de dar error, como default se pone estado pendiente")]
        public String calle { get; set; }

        [Display(Prompt = "N�mero", Description = "N�mero de puerta", Name = "Numero_puerta")]
        [Required(ErrorMessage = "Introduce un valor mayor que cero, no existen puertas con n�mero 0 o menor")]
        [Range(1, int.MaxValue)]
        public int numero_puerta { get; set; }

        [Display(Prompt = "Pos X", Description = "Posici�n X de las coordenadas en el mapa", Name = "Pos_x")]
        [Required(ErrorMessage = "Debe de ser un n�mero v�lido")]
        public float pos_x { get; set; }

        [Display(Prompt = "Pos Y", Description = "Posici�n Y de las coordenadas en el mapa", Name = "Pos_y")]
        [Required(ErrorMessage = "Debe de ser un n�mero v�lido")]
        public float pos_y { get; set; }
    }
}