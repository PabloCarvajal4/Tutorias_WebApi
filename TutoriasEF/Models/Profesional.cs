using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TutoriasEF.Models
{
    class Profesional
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]

        public int id_docente { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public int Edad { get; set; }
        public string Descripcion { get; set; }

        public void mostrarProfesionales()
        {
            Console.WriteLine("Id_Docente: " + id_docente);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Carrera: " + Carrera);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Descripción: " + Descripcion);
        }
    }
}
