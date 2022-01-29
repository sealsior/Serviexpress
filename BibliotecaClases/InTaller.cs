using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class InTaller
    {
        public int num_ingreso { get; set; }
        public string patente { get; set; }
        public string fabricante { get; set; }
        public int anno { get; set; }
        public string modelo { get; set; }
        public string servicio { get; set; }
        public string rut_cliente { get; set; }

        public InTaller()
        {
            this.Init();
        }

        private void Init()
        {
            num_ingreso = 0;
            patente = string.Empty;
            fabricante = string.Empty;
            anno = 0;
            modelo = string.Empty;
            servicio = string.Empty;
            rut_cliente = string.Empty;
        }
    }
}
