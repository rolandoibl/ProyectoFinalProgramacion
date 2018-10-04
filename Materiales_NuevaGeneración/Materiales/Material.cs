using System;

namespace Materiales
{
    public class Material
    {
        #region Atributos
        private string nombre;
        private float densidad;
        private string tipo;
        private string medidas;
        #endregion

        #region Constructores
        public Material(string nombre, float densidad, string tipo,string medidas)
        {
            this.nombre = nombre;
            this.densidad = densidad;
            this.tipo = tipo;
            this.Medidas = medidas;
        }
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public float Densidad { get => densidad; set => densidad = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Medidas { get => medidas; set => medidas = value; }
        #endregion
    }
}
