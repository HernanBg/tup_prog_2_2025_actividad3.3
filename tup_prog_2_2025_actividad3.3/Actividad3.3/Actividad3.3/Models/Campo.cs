using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3._3.Models
{
    internal class Campo:Icomparabale
    {

        public double Superficie {  get; set; }
        public string IdCampo {  get; set; }

        public  Campo (double superficie, string idCampo)
        {
            this.Superficie = superficie;
            this.IdCampo = idCampo;
        }

        public int CompareTo(object otro)
        {
            Campo otroCampo = otro as Campo;
            if (otroCampo != null)
            {
                return (IdCampo.CompareTo(otroCampo.IdCampo));
            }
            return 1;
        }

    }
}
