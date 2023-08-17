using ApiClientesNet6.Models.Dto;

namespace ApiClientesNet6.Repository
{
    public interface IClienteRepositorio
    {
        Task<List<ClienteDto>> GetClientes();
        Task<ClienteDto> GetClienteById(int id);
        Task<ClienteDto> CreateUpdate(ClienteDto clienteDto);
        Task<bool> DeleteCliente(int id);

    }
}
