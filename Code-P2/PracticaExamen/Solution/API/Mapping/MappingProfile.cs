using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Mapping
{
    // Implementamos el casteo de objetos del automapper para no tener referencias circulares
    public class MappingProfile : Profile
    {
        // Necesitamos crear este metodo para poder direccionar el casteo de los objetos
        public MappingProfile()
        {
            // Representa el casting del objeto a el similar
            // Desde DO hacia DataModels
            // Domain to Resource
            CreateMap<DO.Objects.GroupComment, DataModels.GroupComment>();
            CreateMap<DO.Objects.GroupUpdate, DataModels.GroupUpdate>();


            // Representa el casting del objeto a el similar
            // Desde DataModels hacia DO
            // Resource to Domain
            CreateMap<DataModels.GroupComment, DO.Objects.GroupComment>();
            CreateMap<DataModels.GroupUpdate, DO.Objects.GroupUpdate>();
        }

    }
}
