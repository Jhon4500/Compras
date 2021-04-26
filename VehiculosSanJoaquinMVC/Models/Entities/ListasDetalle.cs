using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VehiculosSanJoaquinMVC.Models.Entities
{
    [Table("NS_tblListasDetalle")] //Nombre tabla BD
    public class ListasDetalle


    {
        // Mapeo datos de la tabla lista detalle
        [Required(ErrorMessage = "El campo codigo Detalle lista es obligatorio")]
        [Key]
        public int LdClave { get; set; }

        [Required(ErrorMessage = "El campo Descripcion es obligatorio"),MaxLength(60)]
        [Display(Name = "Activo Lista")]
        public string LdDescripcion1 { get; set; }

        public string LdDescripcion2 { get; set; }

        public int LdActivoV1 { get; set; }

        public int LdUsuario { get; set; }

        [Required(ErrorMessage = "El campo Fecha es obligatorio")]
        [DataType(DataType.DateTime)]
        public DateTime LdFecha { get; set; }

        public int LdusuarioCambio { get; set; }

        [Required(ErrorMessage = "El campo Fecha Cambio es obligatorio")]
        [DataType(DataType.DateTime)]
        public DateTime LdFechaCambio { get; set; }

        public string LdAplicacion { get; set; }


        [ForeignKey("LiCodigo")]
        public int LiCodigo { get; set; } //FK listas

        public virtual Listas Listas { get; set; } // propiedad de navegacion 


        [ForeignKey("ClId")]
        public int ClId { get; set; } //FK Cliente

        public virtual Cliente Cliente { get; set; } // propiedad de navegacion 










    }
}
