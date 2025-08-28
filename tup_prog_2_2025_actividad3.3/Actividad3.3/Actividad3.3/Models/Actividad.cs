using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3._3.Models
{
    public abstract class Actividad
    {
        public int Periodo { get; set; }
        public string Descripcion { get; set; }

        abstract public double CalcularProduc();
        abstract public double CacularRendimiento();



}
