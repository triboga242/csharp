using System;
namespace DiagramaDeClases
{
    public class Alumno:Persona, evaluable
    {
        private Double nota_;

        public Alumno(double nota, string nombre, string edad):base(nombre, edad)
        {
            nota_ = nota;
        }

        public double Nota

        {
            get
            {
                return nota_;
            }
            set
            {
                nota_ = value;
            }
        }

        public override void evalua(double nota)
        {
            throw new NotImplementedException();
        }
    }
}
