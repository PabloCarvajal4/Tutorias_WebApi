using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TutoriasEF.Models
{
    class TutoriaPersonalizada
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]

        public int id_tutoria { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Clase { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Docente { get; set; }

        public void mostrarTutoriasPersonalizadas()
        {
            Console.WriteLine("Id_Tutoria: " + id_tutoria);
            Console.WriteLine("Usuario: " + Usuario);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Clase: " + Clase);
            Console.WriteLine("Fecha: " + Fecha);
            Console.WriteLine("Hora: " + Hora);
            Console.WriteLine("Docente: " + Docente);
        }
    }
}
