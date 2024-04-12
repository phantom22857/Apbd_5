using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.DataBase;

public class MockDb
{
    public List<Animal> Animals { get; set; } = new List<Animal>();
    public List<Visit> Visits { get; set; } = new List<Visit>();

    public MockDb()
    {
        Animals.Add(new Animal { Id = 1, Name = "Buddy", Category = "Dog", Weight = 24.5, FurColor = "Brown" });
        Animals.Add(new Animal{Id=2,Name="Cute",Category="Tiger",Weight = 100.7,FurColor="orange-black",});
        Animals.Add(new Animal{Id=3,Name="Margaret",Category="Elephant",Weight = 250,FurColor="gray",});
        Animals.Add(new Animal{Id=4,Name="Jack",Category="wolf",Weight = 70,FurColor="gray-black",});
        Visits.Add(new Visit { Id = 1, AnimalId = 1, DateOfVisit = DateTime.Today, Description = "Annual Vaccination", Price = 150 });
        Visits.Add(new Visit { Id = 2, AnimalId = 2, DateOfVisit = DateTime.Today, Description = "Annual Vaccination", Price = 800 });
        Visits.Add(new Visit { Id = 3, AnimalId = 3, DateOfVisit = DateTime.Today, Description = "Annual Vaccination", Price = 500 });
        Visits.Add(new Visit { Id = 4, AnimalId = 4, DateOfVisit = DateTime.Today, Description = "Annual Vaccination", Price = 350 });
    }

    
}