using APIRev.Data.Provider.MongoDB.Collections;
using APIRev.Domain.Entities;
using APIRev.Domain.Interfaces;
using AutoMapper;
using H1Store.Catalogo.Data.Providers.MongoDb.Interfaces;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRev.Data.Repositories
{
    public class CartaRepository : ICartaRepository
    {
        private readonly IMongoRepository<CartaCollection> _repository;
        private readonly IMapper _mapper;

        public CartaRepository(IMongoRepository<CartaCollection> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task Add(Carta carta)
        {
            var _carta = _mapper.Map<CartaCollection>(carta);
            await _repository.InsertOneAsync(_carta);
        }

        public async Task<IList<Carta>> GetAll()
        {
            var cartas = _repository.FilterBy(f => true);
            return _mapper.Map<IList<Carta>>(cartas);
        }

        public async Task<Carta> GetOne(Guid id)
        {
            var carta = await _repository.FindOneAsync(f => f.CodeID.Equals(id));
            return _mapper.Map<Carta>(carta);
        }
    }
}
