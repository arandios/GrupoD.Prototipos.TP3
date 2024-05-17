using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoD.Prototipos.TP3
{
    public class Persona
    {
        // Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }

        // Constructor
        public Persona(string nombre, string apellido, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
        }
    }

    // Clase Cliente que hereda de Persona
    public class Cliente : Persona
    {
        // Propiedades específicas de Cliente
        public int NumeroCliente { get; set; }
        public string Contraseña { get; set; }

        // Constructor
        public Cliente(string nombre, string apellido, string dni, int numeroCliente, string contraseña) : base(nombre, apellido, dni)
        {
            NumeroCliente = numeroCliente;
            Contraseña = contraseña;
        }
    }

    // Clase Empleado que hereda de Persona
    public class Empleado : Persona
    {
        // Propiedades específicas de Empleado
        public int Legajo { get; set; }
        public string Contraseña { get; set; }

        // Constructor
        public Empleado(string nombre, string apellido, string dni, int legajo, string contraseña) : base(nombre, apellido, dni)
        {
            Legajo = legajo;
            Contraseña = contraseña;
        }
    }
}

  
  
         

    

