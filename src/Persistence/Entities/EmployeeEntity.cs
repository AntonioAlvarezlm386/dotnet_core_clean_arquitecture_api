using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Persistence.Entities;

public class EmployeeEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = null!;

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; } = null!;

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Salary { get; set; }

    [Required]
    [MaxLength(50)]
    public string EmployeeType { get; set; } = null!;
}
