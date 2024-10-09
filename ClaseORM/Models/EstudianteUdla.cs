using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ClaseORM.Models
{
    public class EstudianteUdla
    {
        //Anotaciones importantes para C#
        [Key]
        public int IdBanner { get; set; } //Primary Key
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [EmailAddress]
        [AllowNull]
        public string Correo {  get; set; }
        public bool TieneBeca {  get; set; }
        public Carrera Carrera { get; set; } //Anclaje a la clase Carrera
        [ForeignKey("Carrera")]
        public int IdCarrera { get; set; } //Referencia a la clase Carrera ForeingKey
    }
}
