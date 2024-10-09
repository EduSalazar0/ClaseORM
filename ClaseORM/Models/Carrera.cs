using System.ComponentModel.DataAnnotations;

namespace ClaseORM.Models
{
    public class Carrera
    {
        [Key]
        public int Id { get; set; } //Primary Key
        [Required]
        public string Name { get; set; }
    }
}
