using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VineShop.Models.Entities;
using VineShop.ViewModel;
using AutoMapper;

namespace VineShop.Infrastructure
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //Mapowanie win do wyświetlenia w dataGridzie
            CreateMap<Vine, VineViewModel>().
                ForMember(b => b.Size, opt => opt.MapFrom(src => src.Size.Value)).
                ForMember(b => b.Sweetness, opt => opt.MapFrom(src => src.Sweetness.Name)).
                ForMember(b => b.Type, opt => opt.MapFrom(src => src.Type.Name)).
                ForMember(b => b.Brand, opt => opt.MapFrom(src => src.Brand.Name));

            //Mapowanie koszyka do wyświetlenia w dataGridzie
            CreateMap<Cart, CartViewModel>()
                .ForMember(b => b.Name, opt => opt.MapFrom(src => src.Vine.Name)).
                ForMember(b => b.Size, opt => opt.MapFrom(src => src.Vine.Size.Value)).
                ForMember(b => b.Sweetness, opt => opt.MapFrom(src => src.Vine.Sweetness.Name)).
                ForMember(b => b.Type, opt => opt.MapFrom(src => src.Vine.Type.Name)).
                ForMember(b => b.Brand, opt => opt.MapFrom(src => src.Vine.Brand.Name)).
                ForMember(b => b.YearOfProduction, opt => opt.MapFrom(src => src.Vine.YearOfProduction)).
                ForMember(b => b.Price, opt => opt.MapFrom(src => src.Vine.Price));
        }
    }
}
