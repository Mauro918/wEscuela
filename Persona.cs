using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wEscuela
{
    class Persona
    {

        String nombre;
        private double sueldo;
        private int calificacion;

        public Persona()
        {
            Nombre = "";
            Sueldo = 0;
            Calificacion = 0;
        
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public int Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }

        public string Asistir()
        {
            string Asiste = (Nombre + " asiste a la escuela ");
            return Asiste;
        }
       
        public string Enseñar()
        {
            string Enseña= (Nombre + " esta eseñando ");
            return Enseña;
        }

        public double Salario(double sueldo)
        {
            Sueldo = sueldo;
            return Sueldo;
        }

        public int Notas(int calificacion)
        {
            Calificacion = calificacion;
            return Calificacion;
        }

        public string Estudiar()
        {
            string estudia = (Nombre + " Esta estudiando ");
            return estudia;
        }
    }

    
}
