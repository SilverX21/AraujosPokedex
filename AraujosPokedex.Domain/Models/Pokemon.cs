using System.ComponentModel.DataAnnotations;

namespace AraujosPokedex.Domain.Models;

public sealed class Pokemon
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(30)]
    public string Name { get; set; }

    [StringLength(30)]
    public string Nickname { get; set; }

    [Required]
    [StringLength(20)]
    public string Region { get; set; }

    [Required]
    public string PrimaryType { get; set; }

    public string SecondaryType { get; set; }

    public bool IsOwned { get; set; }

    public DateTime DateCaught { get; set; }
}