using System;
using System.Collections.Generic;
using AnimalRecord;


  public class Program
  {
    public static void Main()
    {
      Animal tiger = new Animal("Babushka", 5, 3);
      Animal lion = new Animal("Mittens", 4, 5);
      Animal monkey = new Animal("Tom", 2, 1);
      Animal chimpanzee = new Animal("Guspacho", 10, 2);
      Animal snake = new Animal("Tim", 1, 4);

       List<Animal> Animals = new List<Animal>() { tiger, lion, monkey, chimpanzee, snake };

    //    Console.WriteLine("Enter the name of the animal:");
    //    string NameInput = Console.ReadLine();
       Console.WriteLine("Enter the max health of the animal:");
       string healthBar = Console.ReadLine();
       int healthBarInput = int.Parse(healthBar);
       Console.WriteLine("Enter the max age of the animal:");
       string ageLimit = Console.ReadLine();
       int ageLimitInput = int.Parse(ageLimit);

       List<Animal> AnimalsMatchingSearch = new List<Animal>(0);

    //    foreach (Animal animaldata in Animals)
    //    {
    //        if (string.IsNullOrEmpty(animaldata.GetAnimalByName()))
    //        {
    //           AnimalsMatchingSearch.Add(animaldata); 
              
    //        }
    //    }
    //    foreach(Animal animaldata in AnimalsMatchingSearch)
    //    {
    //        Console.WriteLine(animaldata.GetAnimalByName());
    //    }



       foreach (Animal animaldata in Animals)
      {
        if (animaldata.GetAnimalByAge(ageLimitInput) && animaldata.GetAnimalByhealth(healthBarInput))
        {
          AnimalsMatchingSearch.Add(animaldata);
        } 
      }
      if (AnimalsMatchingSearch.Count == 0) {
          Console.WriteLine("There is no animal available according to your search");
      }
        foreach(Animal animaldata in AnimalsMatchingSearch)
    {
          Console.WriteLine(animaldata.GetAnimalByName());
    }


    }

  }
