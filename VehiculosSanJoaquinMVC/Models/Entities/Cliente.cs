using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VehiculosSanJoaquinMVC.Models.Entities
{
    [Table("NS_tblClientes")]

    public class Cliente
    {

        
        [Required(ErrorMessage = "El campo codigo es obligatorio"), MaxLength(30)]
        [Key]
        public int ClId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El campo nombre es obligatorio"), MaxLength(30)]
        [Display(Name = "Nombre")]
        public string ClNombre1 { get; set; }

        public string ClNombre2 { get; set; }


        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El campo Apellido es obligatorio"), MaxLength(30)]
        [Display(Name = "Apellido")]
        public string ClApellido1 { get; set; }

        public string ClApellido2 { get; set; }

        [Required(ErrorMessage = "El campo cedula es obligatorio")]
        [Display(Name = "Cedula")]
        public int ClCedula { get; set; }


        [Display(Name = "Correo")]
        [Required(ErrorMessage = "El campo correo electronico no es una direccion de correo electronica valida  ")]
        public string ClCorreo { get; set; }


        public string ClTelefono1 { get; set; }

        public string ClTelefono2 { get; set; }

        public virtual List<ListasDetalle> DetalleListas { get; set; } // propiedad navegacion
    }
}
