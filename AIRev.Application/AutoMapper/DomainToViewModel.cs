using APIRev.Application.ViewModel;
using APIRev.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRev.Application.AutoMapper
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {

            CreateMap<Carta, NovaCartaViewModel>();
            CreateMap<Carta, CartaViewModel>();

        }
    }
}
