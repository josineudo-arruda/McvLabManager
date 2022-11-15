namespace MvcLabManager.Models;

public class Computer
{
    [Required]
    [StringLength(100, ErrorMessage = "Atingiu o número máximo")]
    public int Id { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Atingiu o número máximo")]
    public string Ram { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Atingiu o número máximo")]
    public string Processor { get; set; }

    public Computer() {}

    public Computer(int id, string ram, string processor)
    {
        Id = id; 
        Ram = ram;
        Processor = processor;
    }
}