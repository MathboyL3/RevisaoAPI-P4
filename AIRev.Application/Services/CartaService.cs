using APIRev.Application.Interfaces;
using APIRev.Application.ViewModel;
using APIRev.Domain.Entities;
using APIRev.Domain.Interfaces;
using AutoMapper;

namespace AIRev.Application.Services
{
    public class CartaService : ICartaService
    {
        private readonly ICartaRepository _cartaRepository;
        private readonly IMapper _mapper;
        public CartaService(ICartaRepository cartaRepository, IMapper mapper)
        {
            _cartaRepository = cartaRepository;
            _mapper = mapper;
        }

        public async Task Adicionar(NovaCartaViewModel carta)
        {
            var _carta = _mapper.Map<Carta>(carta);
            _carta.GenerateID();
            await _cartaRepository.Add(_carta);
        }

        public async Task<IList<CartaViewModel>> GetAll()
        {
            var cartas = await _cartaRepository.GetAll();
            return _mapper.Map<IList<CartaViewModel>>(cartas);
        }

        public async Task<CartaViewModel> GetOne(Guid guid)
        {
            var carta = await _cartaRepository.GetOne(guid);
            return _mapper.Map<CartaViewModel>(carta);
        }
    }
}
