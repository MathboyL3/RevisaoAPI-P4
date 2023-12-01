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
    public class DomainToCollection : Profile
    {
        public DomainToCollection() 
        {
            CreateMap<Carta, CartaCollection>();

        }
    }
}
