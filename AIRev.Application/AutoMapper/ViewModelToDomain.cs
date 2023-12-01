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
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<NovaCartaViewModel, Carta>()
                .ConstructUsing(f => new Carta(f.ToName, f.Content, f.Enviar));

            CreateMap<CartaViewModel, Carta>()
                .ConstructUsing(f => new Carta(f.CodeID, f.ToName, f.Content, f.Enviar));
        }
    }
}
