using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigoSinAdapter
{
    internal class Temperatura
    {
        private float _valor;
        private string _unidad;

        public Temperatura(float valor, string unidad)
        {
            _valor = valor;
            _unidad = unidad;
        }
        public float Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        public string Unidad
        {
            get { return _unidad; }
            set { _unidad = value; }
        }

        public Temperatura ConvertirCelsius()
        {
            if (this._unidad == "farenheit")
            {
                this._valor = (_valor - 32) * 5 / 9;
                this._unidad = "celsius";

                return this;
            }
            else
            {
                return this;
            }
        }

        public Temperatura ConvertirFarenheit()
        {
            if (this._unidad == "celsius")
            {
                this._valor = (_valor * 9 / 5) + 32;
                this._unidad = "farenheit";

                return this;
            }
            else { return this; }
        }
    }

}
