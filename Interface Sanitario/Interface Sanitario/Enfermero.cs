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

        public string CalculaSueldo(string puesto)
        {
            if (puesto == "UCI")
            {
                return (GetSueldoBase() + 200) + " euros.";
            }
            else if(puesto=="planta")
            {
                return GetSueldoBase() + " euros.";
            }
            else
            {
                return "Puesto incorrecto";
            }
        }
        public override string Mostrar()
        {
            return base.Mostrar() + "Puesto es: " + GetPuesto() + "\nSueldo final de " +GetNombre()+ " es " + CalculaSueldo(puesto)+"\n********************";
        }

    }


}
