using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Sanitario
{
    class Medico:Sanitario,IPersonalLaboral
    {
        private string especialidad;
        private int numeroPacientes;

        public Medico()
        {

        }
        public Medico(string dni, string nombre, double sueldoBase, int edad,string especialidad,int numeroPacientes) :base(dni,nombre,sueldoBase,edad)
        {
            this.especialidad = especialidad;
            this.numeroPacientes = numeroPacientes;
        }
        public string GetEspecialidad()
        {
            return especialidad;
        }
        public void SetEspecialidad(string especialidad)
        {
            this.especialidad=especialidad;
        }
        public int GetNumeroPacientes()
        {
            return numeroPacientes;
        }
        public void SetNumeroPacientes(int numeroPacientes)
        {
            this.numeroPacientes=numeroPacientes;
        }

        //El método calculaSueldo devolverá el sueldo final ( si es medico se le sumará al sueldo base
        //una cantidad que será el nº de pacientes por 1.20 euros, si es enfermero se le sumará al
        //sueldo base 200 euros si es de UCI y nada si es de planta).
        public string CalculaSueldo()
        {
            return "El sueldo final del medico " + GetNombre() + " es " +(GetSueldoBase()+(GetNumeroPacientes()*1.20))+" euros.";
        }
        public override string Mostrar()
        {
           return base.Mostrar() + "Especialidad: " + especialidad + "\n"+CalculaSueldo()+"\n************************";
        }
       
    }
}
