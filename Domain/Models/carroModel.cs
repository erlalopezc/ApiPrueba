using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class carroModel
    {
        public int Anio { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }

        public int NumeroPuertas { get; set; }
    }
}
