﻿using System;
namespace DiagramaDeClases
{
    public class Profesor:Persona , evaluable
    {
        private float sueldo;

        public Profesor(string nombre, string edad):base(nombre, edad)
        {
        }

		public float Sueldo
		{
			get
			{
				return sueldo;
			}
			set
			{
				sueldo = value;
			}
		}
		public void Reganiar(string saludo)
		{
			Console.WriteLine(saludo);
		}

        public void Evalua(Alumno alumno, double nota)
        {
            alumno.Nota = nota;
        }

        public override void Saludar(string saludo)
        {
            Console.WriteLine(saludo);
        }
    }
}
