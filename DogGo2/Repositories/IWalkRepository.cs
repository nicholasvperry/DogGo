using DogGo2.Models;
using System.Collections.Generic;

namespace DogGo2.Repositories
{
    public interface IWalkRepository
    {
        List<Walks> GetAllWalks();
        Walks GetWalkById(int id);
        List<Walks> GetWalksByWalkerId(int walkerId);
    }
}