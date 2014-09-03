using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InitiateAPI.Models
{
    public class Initiate
    {
        public int InitiateId { get; set; }
        public string NombreProceso { get; set; }
        public int NumeroProceso { get; set; }
        public string NombreTarea { get; set; }
    }
}