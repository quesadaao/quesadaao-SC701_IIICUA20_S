using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Mapping
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<DO.Objects.GroupComment, DataModels.GroupComment>();
            CreateMap<DO.Objects.GroupUpdate, DataModels.GroupUpdate>();

            // Resource to Domain
            CreateMap<DataModels.GroupComment, DO.Objects.GroupComment>();
            CreateMap<DataModels.GroupUpdate, DO.Objects.GroupUpdate>();
        }

        //public static void CreateMaps()
        //{
        //    Mapper.Initialize(cfg =>
        //    {
        //        cfg.CreateMap<ent.Employees, data.Employees>();
        //        cfg.CreateMap<data.Employees, ent.Employees>();

        //        cfg.CreateMap<ent.Customers, data.Customers>();
        //        cfg.CreateMap<data.Customers, ent.Customers>();

        //    });

        //}

    }
}
