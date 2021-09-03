using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TutoriasEF.Models
{
    class Credencial
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]

        public string Usuario { get; set; }
        public string NombreCompleto { get; set; }
        public string correo { get; set; }
        public string Contraseña { get; set; }

        public void mostrarDatos()
        {
            Console.WriteLine("Usuario: " + Usuario);
            Console.WriteLine("NombreCompleto: " + NombreCompleto);
            Console.WriteLine("Correo: " + correo);
            Console.WriteLine("Contraseña: " + Contraseña);
        }

    }
}
