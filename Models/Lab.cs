using System.ComponentModel.DataAnnotations;

namespace MvcLabManager.Models;

public class Lab
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string Number { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Sector { get; set; }

    public Lab() {}

    public Lab(int id, string number, string name, string sector)
    {
        Id = id;
        Number = number;
        Name = name;
        Sector = sector;
    }
}