using System.ComponentModel.DataAnnotations;

namespace Persistence.Entities;

public class EventEntity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string? Image { get; set; }
    public string? Title { get; set; }
    public DateTime Date { get; set; }
    public DateTime Time { get; set; }
    public string? Location { get; set; }
    public string? Description { get; set; }

    public ICollection<EventPackageEntity>  Packages { get; set; } = [];
}
