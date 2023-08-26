using AutoMapper;
using DataAccess.Models;
using ApiRESTDevsu.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRESTDevsu.Utils
{
    public static class MapperUtil
    {

        internal static Cliente MapToCliente(this ContractCliente obj)
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<ContractCliente, Cliente>()
            );
    
            var mapper = configuration.CreateMapper();
            
            return mapper.Map<Cliente>(obj);
        }

        internal static Cuenta MapToCuenta(this ContractCuenta obj)
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<ContractCuenta, Cuenta>()
                .ForMember(dest => dest.TipoCuenta, opt => opt.MapFrom(src => src.TipoCuenta == Constants.AHORROS ? 1 : 2))
            );
            var mapper = configuration.CreateMapper();
            return mapper.Map<Cuenta>(obj);
        }

        internal static Persona MapToPersona(this ContractCliente obj)
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<ContractCliente, Persona>()
            );
            var mapper = configuration.CreateMapper();
            return mapper.Map<Persona>(obj);
        }

        internal static ContractCliente MapToContractCliente(this Persona obj)
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<Persona, ContractCliente>()
            );
            var mapper = configuration.CreateMapper();
            return mapper.Map<ContractCliente>(obj);
        }

        internal static Movimiento MapToMovimiento(this ContractMovimiento obj)
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<ContractMovimiento, Movimiento>()
                .ForMember(dest => dest.TipoMovimiento, opt => opt.MapFrom(src => src.TipoMovimiento== Constants.DEBITO ? 0 : 1))
            );
            var mapper = configuration.CreateMapper();
            return mapper.Map<Movimiento>(obj);
        }

        internal static ContractMovimiento MapToContractMovimiento(this Movimiento obj)
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<Movimiento, ContractMovimiento>()
                .ForMember(dest => dest.TipoMovimiento, opt => opt.MapFrom(src => src.TipoMovimiento ==  0 ? Constants.DEBITO : Constants.CREDITO))
            );
            var mapper = configuration.CreateMapper();
            return mapper.Map<ContractMovimiento>(obj);
        }

        internal static ContractCuenta MapToContractCuenta(this Cuenta obj)
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<Cuenta, ContractCuenta>()
                .ForMember(dest => dest.TipoCuenta, opt => opt.MapFrom(src => src.TipoCuenta==  1 ? Constants.AHORROS: Constants.CREDITO))
            );
            var mapper = configuration.CreateMapper();
            return mapper.Map<ContractCuenta>(obj);
        }

    }
}
