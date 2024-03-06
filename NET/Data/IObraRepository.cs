using Tickett.Models;


namespace Tickett.Data
{
        public interface IObraRepository
    {
        List<Obra> GetAll();
        // GetAll(int id);
        void Add(Obra obra);
        ObraDTO Get(int id);
        void Update(Obra obra);
        void Delete(int id);

    }
}