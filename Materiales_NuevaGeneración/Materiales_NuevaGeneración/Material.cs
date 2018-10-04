using System;

namespace Materiales_NuevaGeneración
{
    public class Material
    {
        private string nombre;
        private float densidad;
        private string tipo;

        public Material(string nombre, float densidad, string tipo)
        {
            this.nombre = nombre;
            this.densidad = densidad;
            this.Tipo = tipo;
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                if (value == "")
                {
                    nombre = "Genérico";
                }
                else
                {
                    nombre = value;
                }
            }
        }

        public float Densidad
        {
            get => densidad;
            set
            {
                if (value <= 0)
                {
                    densidad = 0;
                }
                else
                {
                    densidad = value;
                }
            }
        }

        public string Tipo
        {
            get => tipo;
            set
            {
                if(value=="")
                {
                    tipo = "Desconocido";
                }
                else
                {
                    tipo = value;
                }              
            }
        }
    }
}
