using System;

namespace MyApp.Models;

public class Difficulty
{
    public Guid Id { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }    
    
    public string? RegionImageUrl { get; set; }
}
