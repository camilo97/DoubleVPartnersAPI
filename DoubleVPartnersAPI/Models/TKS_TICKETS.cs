using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoubleVPartnersAPI.Models
{
    public class TKS_TICKETS
    {
        public int Id { get; set; }
        public string USUARIO { get; set; }
        public DateTime FECHA_CREACION { get; set; }
        public DateTime FECHA_ACTUALIZACION { get; set; }
        public bool ESTADO { get; set; }
    }
}
