using System.ComponentModel.DataAnnotations;

namespace Persistence.Entities;

public class PackageEntity
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string? SeatingArrangement { get; set; } 
    public string? Placement { get; set; }
    public decimal? Price { get; set; }
    public string? Currency { get; set; }
}
