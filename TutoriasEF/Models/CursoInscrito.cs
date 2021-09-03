using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TutoriasEF.Models
{
    class CursoInscrito
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int id_cursos { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_final { get; set; }
        public string Horario { get; set; }
        public string Curso { get; set; }
        public string Docente { get; set; }
        public string Usuario { get; set; }

        public void mostrarCursos()
        {
            Console.WriteLine("Id_Curso: " + id_cursos);
            Console.WriteLine("Fecha de Inicio: " + Fecha_Inicio);
            Console.WriteLine("Fecha Final: " + Fecha_final);
            Console.WriteLine("Hora: " + Horario);
            Console.WriteLine("Curso: " + Curso);
            Console.WriteLine("Docente: " + Docente);
            Console.WriteLine("Usuario: " + Usuario);
        }
    }
}
