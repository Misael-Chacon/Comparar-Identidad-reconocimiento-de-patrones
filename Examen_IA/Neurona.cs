using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_IA
{
    class Neurona
    {
        private List<List<Double>> Entradas;
        private List<List<Double>> Pesos;
        private List<Double> Bias;
        private List<Double> Yin;
        private List<Double> Salidas;
        private List<Double> SalidasEsperadas;

        public Neurona()
        {
            Entradas = new List<List<Double>>();
            Pesos = new List<List<Double>>();
            Bias = new List<Double>();
            Salidas = new List<Double>();
            SalidasEsperadas = new List<Double>();
        }

        public List<List<Double>> getEntradas()
        {
            return Entradas;
        }
        public void setEntradas(List<List<Double>> Entradas)
        {
            this.Entradas = Entradas;
        }
        public void AddEntradas(List<Double> Entradas)
        {
            this.Entradas.Add(Entradas);
        }


        public List<List<Double>> getPesos()
        {
            return Pesos;
        }
        public void setPesos(List<List<Double>> Pesos)
        {
            this.Pesos = Pesos;
        }
        public void AddPesos(List<Double> Pesos)
        {
            this.Pesos.Add(Pesos);
        }


        public List<Double> getBias()
        {
            return Bias;
        }
        public void setBias(List<Double> Bias)
        {
            this.Bias = Bias;
        }
        public void AddBias(Double Bia)
        {
            this.Bias.Add(Bia);
        }


        public List<Double> getYin()
        {
            return Yin;
        }
        public void setYin(List<Double> Yin)
        {
            this.Yin = Yin;
        }
        public void AddYin(Double Yin)
        {
            this.Yin.Add(Yin);
        }


        public List<Double> getSalidas()
        {
            return Salidas;
        }
        public void setSalidas(List<Double> Salidas)
        {
            this.Salidas = Salidas;
        }
        public void AddSalidas(Double Salida)
        {
            this.Salidas.Add(Salida);
        }


        public List<Double> getSalidasEsperadas()
        {
            return SalidasEsperadas;
        }
        public void setSalidasEsperadas(List<Double> SalidasEsperadas)
        {
            this.SalidasEsperadas = SalidasEsperadas;
        }
        public void AddSalidasEsperadas(Double SalidaEsperada)
        {
            this.SalidasEsperadas.Add(SalidaEsperada);
        }


    }
}
