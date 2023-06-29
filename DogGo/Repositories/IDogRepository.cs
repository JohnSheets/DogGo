using DogGo.Models;

namespace DogGo.Repositories
{
    public interface IDogRepository
    {
        List<Dog> GetAllDogs();
        void AddDog(Dog dog);
        void UpdateDog(Dog dog);
        void DeleteDog(int id);
        Dog GetDogById(int id);
        List<Dog> GetDogsByOwnerId(int ownerId);

    }
}
