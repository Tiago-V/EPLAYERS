using System.Collections.Generic;
using EPLAYERS.Models;

namespace EPLAYERS.Interfaces
{
    public interface IEquipe
    {
        void Create(Equipe e);
        List<Equipe> ReadAll();
        void Update(Equipe e);
        void Delete(int id);
    }
}