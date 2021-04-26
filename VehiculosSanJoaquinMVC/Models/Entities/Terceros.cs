using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VehiculosSanJoaquinMVC.Models.Entities
{

    [Table("NS_tblTerceros")]
    public class Terceros
    {
        [Required(ErrorMessage = "El campo codigo Detalle lista es obligatorio")]
        [Key]
        public int TeClave { get; set; }

        public string TeDescripcion { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El campo nombre es obligatorio"), MaxLength(30)]
        [Display(Name = "Nombre")]
        public string TeNombre1 { get; set; }

        public string TeNombre2 { get; set; }


        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El campo Apellido es obligatorio"), MaxLength(30)]
        [Display(Name = "Apellido")]
        public string TeApellido1 { get; set; }

        public string TeApellido2 { get; set; }

        [Required(ErrorMessage = "El campo cedula es obligatorio")]
        [Display(Name = "Cedula")]
        public int TeCedula { get; set; }


        [Display(Name ="Correo")]
        [Required(ErrorMessage = "El campo correo electronico no es una direccion de correo electronica valida  ")]
        public string TeCorreo { get; set; }


        public string TeTelefono1 { get; set; }

        public string TeTelefono2 { get; set; }

        public string TeActividad { get; set; }

        public string TeRazonSocial { get; set; }


        [Required(ErrorMessage = "El campo Fecha de nacimiento es obligatorio")]
        [DataType(DataType.DateTime)]
        public DateTime TeFecNacimiento { get; set; }

        public string  TeNaturaleza { get; set; }

        public string TeCupoCredito { get; set; }

        public string TeNit { get; set; }

        public string TeDiasPlazo { get; set; }

        public string TeCargo { get; set; }

        //traigo las propiedades para realizar la relacion 
        public virtual List<ListasDetalle> ListasDetalle { get; set; }

    }
}
