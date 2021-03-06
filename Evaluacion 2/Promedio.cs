using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_2
{
    public class Promedio
    {
        public string Nombre { get; set; }
        public double NumeroCuenta { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }

        //Constructores
        public Promedio(){}
        public Promedio(string _nombre, double _numerocuenta)
        {
            Nombre = _nombre;
            NumeroCuenta = _numerocuenta;
        }

        public Promedio(double _nota1, double _nota2, double _nota3, double _nota4)
        {
            Nota1 = _nota1;
            Nota2 = _nota2;
            Nota3 = _nota3;
            Nota4 = _nota4;
        }

        //Metodos
        public double DevolverPromedio()
        {
            double prom;
            prom = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            return prom;
            
        }

        public string aproboOreprobo()
        {
            double prom;
            prom = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            if (prom < 69 ) 
            {
                return ("Reprobo");
            }
            else
            {
                return ("Aprobo");
            }
           

        }

    }
}
