using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Sanitario
{
    class Sanitario: IPersonalLaboral
    {
        private string dni, nombre;
        private double sueldoBase;
        private int edad;

        public Sanitario()
        {

        }
        public Sanitario(string dni, string nombre, double sueldoBase, int edad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.sueldoBase = sueldoBase;
            this.edad = edad;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetDni()
        {
            return dni;
        }
        public void SetDni(string dni)
        {
            this.dni = dni;
        }
        public double GetSueldoBase()
        {
            return sueldoBase;
        }
        public void SetSueldoBase(double sueldoBase)
        {
            this.sueldoBase = sueldoBase;
        }
        public int GetEdad()
        {
            return edad;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        //El método jubilable devolverá verdadero si el sanitario tiene 65 años o más y falso en otro
        //caso.
        //public bool Jubilable(int edad)
        //{
        //    if (edad >= 65)
        //    {
        //        Console.WriteLine("El sanitario " + GetNombre() + " se va a jubilar");
        //        return jubilar = true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("El sanitario " + GetNombre() + " no se va a jubilar");
        //        return jubilar = false;
        //    }
        //}
        //El método mostrar visualizará el dni, el nombre, la edad y el sueldo final y la especialidad y el
        //num pacientes en caso de Médico y el puesto en caso del enfermero.
        public virtual string Mostrar()
        {
            return "Datos del sanitario:\n"+ "Dni: " + dni + "\nNombre: " + nombre + "\nEdad: " + edad + "\n";
        }

        public bool Jubilable()
        {
            if (edad >= 65)
            {
                //Console.WriteLine("El sanitario " + GetNombre() + " se va a jubilar");
                return true;
            }
            else
            {
                //Console.WriteLine("El sanitario " + GetNombre() + " no se va a jubilar");
                return false;
            }
           
        }

        public double CalculaSueldo()
        {

            throw new NotImplementedException();
        }
    }
}
