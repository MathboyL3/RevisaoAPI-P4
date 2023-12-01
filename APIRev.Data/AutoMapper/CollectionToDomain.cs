using APIRev.Data.Provider.MongoDB.Collections;
using APIRev.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRev.Data.AutoMapper
{
    public class CollectionToDomain : Profile
    {
        public CollectionToDomain() 
        {
            CreateMap<CartaCollection, Carta>()
                .ConstructUsing(f => new Carta(f.CodeID, f.ToName, f.Content, f.Enviar));
        }
    }
}
