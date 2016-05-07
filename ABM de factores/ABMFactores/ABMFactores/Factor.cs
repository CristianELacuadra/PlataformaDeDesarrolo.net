using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMFactores
{
    public class Factor
    {
        private Int32 _IDFactor;

        private string _NombreFactor;

        private Valor Val;

        public Factor()
        {
            IDFactor = 0;
            NombreFactor = string.Empty;
        }

        public Factor(Int32 ID, string Nom)
        {
            IDFactor = ID;
            NombreFactor = Nom;
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

        public string NombreFactor
        {
            get
            {
                return _NombreFactor;
            }

            set
            {
                _NombreFactor = value;
            }
        }

        public void AltaFactor()
        {
            Datos d = new Datos();

            d.Guardar(this);
        }

        public void BajaFactor()
        {
            Datos d = new Datos();

            d.Borrar(this.IDFactor);
        }

        public void MostrarFactor()
        {
            Datos d = new Datos();

            d.Mostrar();
        }

        public void ModificarFactor(Int32 i)
        {
            Datos d = new Datos();

            d.Modificar(i, this);
        }
    }
}