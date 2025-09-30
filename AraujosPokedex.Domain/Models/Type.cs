using System.ComponentModel.DataAnnotations;

namespace AraujosPokedex.Domain.Models;

public class Type
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(20)]
    public string Name { get; set; }
}