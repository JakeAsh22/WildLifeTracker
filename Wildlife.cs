using System;

namespace Park {
    
    class Animal
    {
        private string _species;
        private string _enclosure;
        
        public Animal(string species, string enclosure)
        {
            _species = species;
            _enclosure = enclosure;
        }

        public string GetAnimal()
        {
            return _species;
        }

        public string GetHabitat()
        {
            return _enclosure; 
        }
    }  
}