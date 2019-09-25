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
    public bool GetAnimalByAge(int maxAge) 
    {
        return (_age < maxAge); 
    }

    public int GetAnimalByhealth(int health) 
    {
        return _health;
    }

  }
}