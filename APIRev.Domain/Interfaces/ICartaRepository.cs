using APIRev.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRev.Domain.Interfaces
{
    public interface ICartaRepository
    {
        Task Add(Carta carta);
        Task<IList<Carta>> GetAll();
        Task<Carta> GetOne(Guid id);
    }
}
