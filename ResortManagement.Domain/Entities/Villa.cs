
using ResortManagement.Domain.Entities.Common;
using System.ComponentModel;

namespace ResortManagement.Domain.Entities;

public class Villa : BaseEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }

    [DisplayName("Price Per Night")]
    public double Price { get; set; }
    public int Sqft { get; set; }
    public int Occupancy { get; set; }

    [DisplayName("Image Url")]
    public string? ImageUrl { get; set; } 
    public int VillaNumber { get; set; }
    public bool IsReserved { get; set; } = false;
}

