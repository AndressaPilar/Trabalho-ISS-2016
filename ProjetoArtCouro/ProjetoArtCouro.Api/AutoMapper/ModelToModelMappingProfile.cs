using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Api.AutoMapper
{
    public class ModelToModelMappingProfile : Profile
    {
        public string Profile
        {
            get { return "ModelToModelMappingProfile"; }
        }

        //Configuração de mapeamento do viewModel para viewModel
        protected override void Configure()
        {
            //Criar
        }
    }
}
