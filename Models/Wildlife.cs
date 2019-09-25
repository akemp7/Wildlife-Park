using System;


namespace AnimalRecord {
class Animal
  {
    private string _name;
    private int _age;
    private int _health;

    public Animal(string name, int age, int health)
    {
      _name = name;
      _age = age;
      _health = health;
    }
    public int GetAnimalByAge() 
    {
        return _age;
    }

    public int GetAnimalByhealth() 
    {
        return _health;
    }

  }
}