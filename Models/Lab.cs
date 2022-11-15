namespace MvcLabManager.Models;

public class Lab
{
    public int Id { get; set; }
    public string Number { get; set; }
    public string Name { get; set; }
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