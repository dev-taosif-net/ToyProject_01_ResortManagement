
using ResortManagement.Domain.Entities.Common;

namespace ResortManagement.Domain.Entities;

public class Villa : BaseEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public double Price { get; set; }
    public int Sqft { get; set; }
    public int Occupancy { get; set; }
    public string? ImageUrl { get; set; } 
    public int VillaNumber { get; set; }
    public bool IsReserved { get; set; } = false;
}

