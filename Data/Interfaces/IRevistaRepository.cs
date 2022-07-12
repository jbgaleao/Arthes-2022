using Arthes_2022.Models.Entities;
using Arthes_2022.Models.ViewModels;

namespace Arthes_2022.Data.Interfaces
{
    public interface IRevistaRepository
    {
        // Task<Revista?> GetRevistaById(int id);
        Task<IEnumerable<Revista>> GetRevistasToList();
        // Task<Revista> InsertRevista(CadastraRevistaViewModel revistaVM);
        // Task<Revista> UpdateRevista(CadastraRevistaViewModel revistaVM);
        // Task DeletaRevista(int Id);
    }
}
