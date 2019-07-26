using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_IA
{
    class Capa
    {

        private List<Neurona> capa;

        public bool Vacio()
        {
            bool esVacio = false;
            if (this.capa.Count > 0)
            {
                esVacio = true;
            }
            return esVacio;
        }

        public void Agregar(Neurona neurona)
        {
            this.capa.Add(neurona);
        }

        public void Quitar(Neurona neurona)
        {
            if (!Vacio())
            {
                this.capa.Remove(neurona);
            }
        }

        public int TamanioCapa()
        {
            int num = 0;

            num = capa.Count();

            return num;
        }
    }
}
