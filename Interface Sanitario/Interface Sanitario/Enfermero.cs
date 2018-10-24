using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Sanitario
{
    class Enfermero : Sanitario,IPersonalLaboral
    {
        string puesto;

        public Enfermero()
        {
        }
        public Enfermero(string dni, string nombre, double sueldoBase, int edad, string puesto) : base(dni, nombre, sueldoBase, edad)
        {
            this.puesto = puesto;
        }

        public string GetPuesto()
        {
            return puesto;
        }
        public void SetPuesto(string puesto)
        {
            this.puesto = puesto;
        }

        public double CalculaSueldo(string puesto)
        {
            if (puesto == "UCI")
            {
               return GetSueldoBase() + 200;
            }
            else if(puesto=="planta")
            {
                return GetSueldoBase();
            }
            else
            {
                Console.WriteLine("ERRRROR");
                return 0;
            }
        }
        public override string Mostrar()
        {
            return "********************\n" + base.Mostrar() + "Puesto es: " + GetPuesto() + "\nSueldo final de " +GetNombre()+ " es " + (CalculaSueldo(puesto)+ (CalculaSueldo(puesto) * 0.01));
        }

    }


}
