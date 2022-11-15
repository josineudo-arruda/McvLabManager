namespace MvcLabManager.Models;

public class Computer
{
    public int Id { get; set; }
    public string Ram { get; set; }
    public string Processor { get; set; }

    public Computer() {}

    public Computer(int id, string ram, string processor)
    {
        Id = id; 
        Ram = ram;
        Processor = processor;
    }
}