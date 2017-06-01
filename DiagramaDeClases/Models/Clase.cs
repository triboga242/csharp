using System;
using System.Collections.Generic;

namespace DiagramaDeClases.Models
{
    public class Clase
    {
        protected List<Alumno> alumnos = new List<Alumno>();
        protected Profesor profe;

        public Clase(List<Alumno> alumnos, Profesor profe)
        {
            this.alumnos = alumnos;
            this.profe = profe;
        }

        public float Media(){

            return 2;
        }

        public void evaluarTodos(){
            
        }

    }
}
