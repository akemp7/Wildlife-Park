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

     public string GetAnimalByName() 
    {
        return _name;
    }
    
    public int GetNewInstanceAnimalByAge() 
    {
        return _age;
    }
     
     public int GetNewInstanceAnimalByHealth() 
    {
        return _health;
    }



    public bool GetAnimalByAge(int maxAge) 
    {
        return (_age < maxAge); 
    }

    public bool GetAnimalByhealth(int maxHealth) 
    {
        return  (_health < maxHealth);  
            
    }
      
      public void SetName(string makeAnimal ) {
        _name = makeAnimal;
  }
   
     
   }
}