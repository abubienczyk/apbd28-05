namespace REST_API.Models;

public class Visit
{
    public DateTime Date { get; set; }
    public int AnimalId { get; set; }
    public string Overview { get; set; }
    public double Price { get; set; }


    public Visit(DateTime date, int animalId, string overview, double price)
    {
        Date = date;
        AnimalId = animalId;
        Overview = overview;
        Price = price;
    }
}