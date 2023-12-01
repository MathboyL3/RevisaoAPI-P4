using APIRev.Application.ViewModel;

namespace APIRev.Application.Interfaces
{
    public interface ICartaService
    {
        Task Adicionar(NovaCartaViewModel carta);
        Task<CartaViewModel> GetOne(Guid guid);
        Task<IList<CartaViewModel>> GetAll();
    }
}
