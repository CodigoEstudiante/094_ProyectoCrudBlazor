using BlazorCrud.Shared;

namespace BlazorCrud.Client.Services
{
    public interface IDepartamentoService
    {
        Task<List<DepartamentoDTO>> Lista();
    }
}
