﻿namespace CVBuilder.Models;
public class Education : ICloneable , IValidation
{
    [Required(ErrorMessage = "School Name required.")]
    public virtual string? LocationName { get; set; }
    [Required(ErrorMessage = "Year required.")]
    public string? Year { get; set; }
    public List<Data>? Data { get; set; } = new();
    public bool IsVailid() => !string.IsNullOrWhiteSpace(LocationName) && !string.IsNullOrWhiteSpace(Year);
    public bool InEditState { get; set; }


    // public Education Clone() => new() { LocationName = this.LocationName, Year = this.Year, Data = this.Data };

      object ICloneable.Clone() => new Education() { LocationName = this.LocationName, Year = this.Year, Data = this.Data };

 
}
