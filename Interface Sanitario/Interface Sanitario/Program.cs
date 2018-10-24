using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Sanitario
{
    class Program
    {
        static void Main(string[] args)
        {
            Medico m1 = new Medico("32567890K", "Chino Cudeiro",1800, 45, "Pediatra", 56);
            Medico m2 = new Medico("32123456K", "Doctor Amor", 1200, 69, "Ginecologo", 1456);
            Enfermero e1 = new Enfermero("31234234L", "Juana Perez", 600, 24, "planta");
            Enfermero e2 = new Enfermero("31234234H", "Pepita Perez", 3200, 68, "UCI");
            Enfermero e3 = new Enfermero("31234234M", "Antonia Perez", 1000, 21, "planta");


            //List<Medico> listaMedicos = new List<Medico>();
            //listaMedicos.Add(m1);
            //listaMedicos.Add(m2);

            //List<Enfermero> listaEnfermeros = new List<Enfermero>();
            //listaEnfermeros.Add(e1);
            //listaEnfermeros.Add(e2);
            //listaEnfermeros.Add(e3);

            List<Sanitario> sanitarios = new List<Sanitario>()
            {
                m1, m2, e1, e2, e3
            };

            //foreach (Sanitario medico in listaMedicos)
            //{
            //    Console.WriteLine(medico.Mostrar());
            //    if (medico.Jubilable())
            //    {
            //        Console.WriteLine("Se puede jubilar");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No se puede jubilar");
            //    }
            //}
            //foreach (Sanitario enfermero in listaEnfermeros)
            //{
            //    Console.WriteLine(enfermero.Mostrar());
            //    if(enfermero.Jubilable())
            //    {
            //        Console.WriteLine("Se puede jubilar");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No se puede jubilar");
            //    }

            //}
            foreach (Sanitario sanitario in sanitarios)
            {
                Console.WriteLine(sanitario.Mostrar());
                if (sanitario.Jubilable())
                {
                    Console.WriteLine("Se puede jubilar");
                }
                else
                {
                    Console.WriteLine("No se puede jubilar");
                }
            }
            Console.ReadLine();

        }

        
        

    }
}
