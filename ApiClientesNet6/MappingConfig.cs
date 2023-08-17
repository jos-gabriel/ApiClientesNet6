using ApiClientesNet6.Models;
using ApiClientesNet6.Models.Dto;
using AutoMapper;

namespace ApiClientesNet6
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => 
            {
                config.CreateMap<ClienteDto, Cliente>();
                config.CreateMap<Cliente, ClienteDto>();
            });

            return mappingConfig;
        }
    }
}
