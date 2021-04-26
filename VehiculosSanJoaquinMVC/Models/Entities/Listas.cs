using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VehiculosSanJoaquinMVC.Models.Entities

{
    //Nombre de la tabla asi queda en la base de datos
    [Table("NS_tblListas")]
    public class Listas
    {
        // Mapeo los campos de la tabla listas

        [Required(ErrorMessage = "El campo codigo es obligatorio")]
        [Key]
        public  int LiCodigo { get; set; } //

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "El campo nombre es obligatorio"), MaxLength(30)]
        [Display(Name = "Nombre")]
        public string LiNombre { get; set; }



        
        [Required(ErrorMessage = "El campo Activo es obligatorio"), MaxLength(10)]
        [Display(Name = "Activo Lista")]
        public string LiActivo { get; set; }



        [Required(ErrorMessage = "El campo Codigo Padre es obligatorio"), MaxLength(10)]
        [Display(Name = "Activo Lista")]
        public string LiCodigoPadre { get; set; }



        public virtual List<ListasDetalle> DetalleListas{ get; set; } // propiedad navegacion

       

        

    }
}
