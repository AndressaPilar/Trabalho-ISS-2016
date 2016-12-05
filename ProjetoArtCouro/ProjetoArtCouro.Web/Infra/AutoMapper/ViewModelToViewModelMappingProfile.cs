using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoArtCouro.Web.Infra.AutoMapper
{
    public class ViewModelToViewModelMappingProfile : Profile
    {
        public string Profile
        {
            get { return "ViewModelToViewModelMappingProfile"; }
        }

        //Configuração de mapeamento do viewModel para viewModel
        protected override void Configure()
        {
            //Mapper.CreateMap<PersonModelView, AddressModelView>();
            //Mapper.CreateMap<PersonModelView, PhysicalPersonModelView>();
            //Mapper.CreateMap<PersonModelView, LegalPersonModelView>();
        }
    }
}