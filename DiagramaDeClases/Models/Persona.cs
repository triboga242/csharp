﻿using System;
namespace DiagramaDeClases
{
    public abstract class Persona: Saludable
    {
        private string nombre_;
        private string edad_;

        protected Persona(string nombre, string edad)
        {
            this.nombre_= nombre;
            this.edad_ = edad;
        }


        public string Nombre
        {
			get
			{
				return nombre_;
			}
            set
            {
                nombre_ = value;
            }
		}    

        public string Edad{
            get
            {
                return edad_;  
            }
            set
            {
                edad_ = value;
            }
        }
        virtual public void Andar(){}

        public override string ToString()
        {
            return string.Format("[Persona: Nombre={0}, Edad={1}]", Nombre, Edad);
        }

       
		public abstract void Saludar(string saludo);


    }
}
