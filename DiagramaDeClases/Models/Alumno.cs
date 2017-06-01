﻿using System;
namespace DiagramaDeClases
{
    public class Alumno:Persona
    {
        //variables
        private Double nota_;
        private string matricula_;

        //constructores
        public Alumno(double nota, string nombre, string edad):base(nombre, edad)
        {
            nota_ = Nota;
        }


        //getters
        public double Nota

        {
            get
            {
                return nota_;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    nota_ = value;
                }else{
                    throw new Exception("MAAAAAAAAL");
                }
            }
        }

        public string Matricula

		{
			get
			{
				return matricula_;
			}
			set
			{
				matricula_ = value;
			}
		}

        public override void Saludar(string saludo)
        {
            Console.WriteLine(saludo);
        }

		public void Quejarse(string saludo)
		{
			Console.WriteLine(saludo);
		}
    }
}
