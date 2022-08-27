using System.ComponentModel.DataAnnotations;

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
        Intermediate,
        Hard
    }

    public class Course : BaseEntity
    {
        [Required, MaxLength(150)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(200)]
        public string ShortDescription { get; set; } = string.Empty;
        public string LongDescription { get; set; } = string.Empty;
        public string Target { get; set; } = string.Empty;
        public string objectives { get; set; } = string.Empty;
        public string requirements { get; set; } = string.Empty;
        public Levels Level { get; set; }


    }
}
