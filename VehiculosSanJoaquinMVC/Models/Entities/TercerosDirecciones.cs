using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VehiculosSanJoaquinMVC.Models.Entities
{
    //Nombre de la tabla asi queda en la base de datos
    [Table("NS_tblTercerosDirecciones")]

    public class TercerosDirecciones
    {
        [Required(ErrorMessage = "El campo codigo Terceros direcciones es obligatorio")]
        [Key]
        public int TdId { get; set; }

        public int TdCodigo2 { get; set; }

        
        [Required(ErrorMessage = "El campo Direccion es obligatorio")]
        [Display(Name = "Direccion")]
        public string TdDireccion1 { get; set; }

        public string TdDireccion2 { get; set; }

        public int TdCodigoPostal { get; set; }

        public string TdLongitud { get; set; }

        public string TdLatitud { get; set; }








    }
}
