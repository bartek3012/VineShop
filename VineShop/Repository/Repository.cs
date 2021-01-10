using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VineShop.Infrastructure;
using VineShop.Models;

namespace VineShop.Repository
{
    public class Repository
    {
        //kontekst bazy danych
        protected readonly DataBaseContext DbContext = new DataBaseContext();

        //zmienna konfiguracyjna mappera
        private static MapperConfiguration MapperConfig = new MapperConfiguration(cfg=>cfg.AddProfile(new MapperProfile()));

        //zmienna mappera
        protected readonly IMapper Mapper = MapperConfig.CreateMapper();
    }
}
