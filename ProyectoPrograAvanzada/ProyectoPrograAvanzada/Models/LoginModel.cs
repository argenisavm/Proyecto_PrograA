using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoPrograAvanzada.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Requerido")]
        [Display(Name = "Usuario")]
        public string Users { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
    }
}