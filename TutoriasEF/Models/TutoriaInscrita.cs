using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TutoriasEF.Models
{
    class TutoriaInscrita
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int id_tutoria { get; set; }
        public string Clase { get; set; }
        public string Hora { get; set; }
        public DateTime Fecha { get; set; }
        public string Docente { get; set; }
        public string Usuario { get; set; }

        public void mostrarTutorias()
        {
            Console.WriteLine("Id_Tutoria: " + id_tutoria);
            Console.WriteLine("Clase: " + Clase);
            Console.WriteLine("Fecha: " + Fecha);
            Console.WriteLine("Hora: " + Hora);
            Console.WriteLine("Docente: " + Docente);
            Console.WriteLine("Usuario: " + Usuario);
        }
    }
}
