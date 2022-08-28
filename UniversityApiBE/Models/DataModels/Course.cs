using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityApiBE.Models.DataModels
{
    //    Crea una clase llamada Curso que debe tener:
    //Nombre(máximo
    //Descripción Corta (máximo 280 caracteres)
    //Descripción larga
    //Público Objetivo
    //Objetivos
    //Requisitos
    //Nivel(solo puede ser Básico, Intermedio o Avanzado para ello usa un enumerado)

    public enum Levels
    {
        Basic,
        Medium,
        Advanced
    }

    public class Course : BaseEntity
    {
        [Required, MaxLength(150)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        public string LongDescription { get; set; } = string.Empty;
        public Levels Level { get; set; }
        // Relación many to many con Categroies
        [Required]
        public ICollection<Category> Categories { get; set; } = new List<Category>();

        // Relación many to many con Students
        public ICollection<Student>? Students { get; set; } = new List<Student>();

        // Relación one to one con Indexes
        [ForeignKey("Index")]
        public int? IdIndex { get; set; }

        public virtual Index? Index { get; set; }

    }


}

