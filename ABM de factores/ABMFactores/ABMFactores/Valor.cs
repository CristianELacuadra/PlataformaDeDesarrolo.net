using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMFactores
{
    class Valor
    {
        private Int32 _IDValor;

        private string _Denominacion;

        private Int32 _NumValor;

        private Int32 _IDFactor;

        public Valor()
        {
            IDValor = 0;
            Denominacion = string.Empty;
            NumValor = 0;
            IDFactor = 0;
        }

        public Valor(Int32 ID, string Den, Int32 Num, Int32 Fac)
        {
            IDValor = ID;
            Denominacion = Den;
            NumValor = Num;
            IDFactor = Fac;
        }

        public int IDValor
        {
            get
            {
                return _IDValor;
            }

            set
            {
                _IDValor = value;
            }
        }

        public string Denominacion
        {
            get
            {
                return _Denominacion;
            }

            set
            {
                _Denominacion = value;
            }
        }

        public int NumValor
        {
            get
            {
                return _NumValor;
            }

            set
            {
                _NumValor = value;
            }
        }

        public int IDFactor
        {
            get
            {
                return _IDFactor;
            }

            set
            {
                _IDFactor = value;
            }
        }

        public void AltaValor()
        {
            Datos d = new Datos();

            d.Guardar(this);
        }

        public void MostrarValor()
        {
            Datos d = new Datos();

            d.Mostrar(this.IDFactor);
        }

        public void ModificarValor(Int32 i)
        {
            Datos d = new Datos();

            d.Modificar(i, this);
        }

    }
}
