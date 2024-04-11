using REST_API.Models;
namespace REST_API.Database;

//statyczna klasa i statyczna metoda 
public static class AnimalSetUp
{
  public static List<Animal> animals = new List<Animal>()
  {
    {new Animal(1,"mruczek","cat",5.7,"white")},
    {new Animal(2,"azor","dog",20,"mutlicolor")},
    {new Animal(3, "pola", "parrot", 3.2,"blue")},
    {new Animal(4,"misia", "hamster",0.07,"black")}
   
  };
}