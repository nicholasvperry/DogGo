using DogGo2.Models;
using System.Collections.Generic;

namespace DogGo2.Repositories
{
    public interface IDogRepository
    {
        List<Dog> GetAllDogs();
        Dog GetDogById(int id);
        public void AddDog(Dog dog);
        public void UpdateDog(Dog dog);
        public void DeleteDog(int dogId);
        List<Dog> GetDogsByOwnerId(int id);
    }
}
