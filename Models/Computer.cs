namespace MvcLabManager.Models;
using System.ComponentModel.DataAnnotations;

public class Computer
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Ram { get; set; }

    [Required]
    public string Processor { get; set; }

    public Computer() {}

    public Computer(int id, string ram, string processor)
    {
        Id = id; 
        Ram = ram;
        Processor = processor;
    }
}