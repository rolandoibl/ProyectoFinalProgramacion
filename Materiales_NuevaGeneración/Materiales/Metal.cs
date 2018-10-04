using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materiales
{
    public class Metal : Material
    {
        #region Atributos
        private float fluencia;
        private float moduloYoung;
        #endregion

        #region Constructores
        public Metal(string nombre, float densidad, string tipo,string medidas,float fluencia, float moduloYoung) : base(nombre, densidad, tipo,medidas)
        {
        }
        #endregion

        #region Propiedades
        public float Fluencia { get => fluencia; set => fluencia = value; }
        public float ModuloYoung { get => moduloYoung; set => moduloYoung = value; }
        #endregion
    }
}
