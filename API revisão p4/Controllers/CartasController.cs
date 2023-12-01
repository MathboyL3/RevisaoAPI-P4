using APIRev.Application.Interfaces;
using APIRev.Application.ViewModel;
using APIRev.Domain.Entities;
using APIRev.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIRev.Controllers
{
    [ApiController]
    public class CartasController : ControllerBase
    {
        private readonly ICartaService _cartaService;
        public CartasController(ICartaService cartaService)
        {
            _cartaService = cartaService;
        }

        [HttpGet]
        [Route("/Cartas")]
        public async Task<IList<CartaViewModel>> GetCartas()
        {
            return await _cartaService.GetAll();
        }

        [HttpGet]
        [Route("/Carta/{guid}")]
        public async Task<CartaViewModel> GetCarta(Guid guid)
        {
            return await _cartaService.GetOne(guid);
        }

        [HttpPost]
        [Route("/AddCarta")]
        public async Task<IActionResult> AddCarta([FromBody] NovaCartaViewModel carta)
        {
            await _cartaService.Adicionar(carta);
            return Ok("Carta mandada para o Papai Noel.");
        }
    }
}
