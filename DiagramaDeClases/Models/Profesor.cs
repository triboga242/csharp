using System;
namespace DiagramaDeClases
{
    public class Profesor:Persona , evaluable
    {
        public Profesor(string nombre, string edad):base(nombre, edad)
        {
        }

        public override void evalua(double nota)
        {
            throw new NotImplementedException();
        }

        public void Saludar()
        {
            throw new NotImplementedException();
        }
    }
}
