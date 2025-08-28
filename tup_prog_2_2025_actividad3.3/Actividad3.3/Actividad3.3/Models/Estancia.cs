using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3._3.Models
{
    internal class Estancia
    {
        public string Nombre { get; set; }
        public Casco Casco { get; set; }

        ArrayList puestos = new ArrayList();
        ArrayList campos = new ArrayList();

        public Campo AgregarCampo(string idCampo, double superficie)
        {
            Campo nuevo = new Campo(superficie, idCampo);
            campos.Add(nuevo);
            return nuevo;   
        }

        public Campo VerCampo(int idx)
        {
            if (idx >= 0 && idx < campos.Count)
            {
                return campos[idx] as Campo;
            }

            return null;
        }

        public int VerCantidadCampos()
        {
            if(campos != null)
            {
                return campos.Count;
            }

            return 0;
        }
        public Estancia(string nombre, string idCampo, double superficie)
        {

            this.Nombre = nombre;
            this.Casco = new Casco();
            this.Casco.Administrador = "Sin Asignar";

            Puesto puesto = new Puesto();
            puestos.Add(puesto);
            puesto.Responsable = "Sin Asignar";

            Campo campo = new Campo(superficie, idCampo);

        }



    }
}
