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
    public class Vehiculos
    {

        [Key]
        public int VeId { get; set; }

        public string VePlaca { get; set; }

        public string VePropietario { get; set; }

        public string VeMarca { get; set; }

        public string Velinea { get; set; }

        public int VeModelo { get; set; }

        public int VeCilindradaCC { get; set; }

        public string VeColor { get; set; }

        public string Veservicio { get; set; }

        public string Veclase { get; set; }

        public string VeTipoCarroceria { get; set; }

        public string VeCombustible { get; set; }

        public string VeCapacidad { get; set; }

        public string VeMotor { get; set; }

        public string VeSerie { get; set; }

        public string Vechasis { get; set; }

        public string Vevalor { get; set; }

        public string VeIva { get; set; }

        public decimal VeTotal { get; set; }

        public int TeClave { get; set; } // FK llave primaria de terceros









    }
}
