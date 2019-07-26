using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_IA
{
    class RedNeuronal
    {

        private List<Capa> redNeuronal;

        public bool Vacio()
        {
            bool esVacio = false;
            if (this.redNeuronal.Count > 0)
            {
                esVacio = true;
            }
            return esVacio;
        }

        public void Agregar(Capa capa)
        {
            this.redNeuronal.Add(capa);
        }

        public void Quitar(Capa capa)
        {
            if (!Vacio())
            {
                this.redNeuronal.Remove(capa);
            }
        }

        public int TamanioRedNeuronal()
        {
            int num = 0;

            num = redNeuronal.Count();

            return num;
        }
    }
}
