using WebApi.Entities;

namespace Repository.Interfaces
{
    public interface IClienteRepository
    {
        Cliente GetById(int id);
        Cliente GetByEmail(string email);
        void Add(Cliente cliente);
    }

}
