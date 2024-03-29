﻿using AutoMapper;
using ProvCli.Api.Contracts.Models;
using ProvCli.Domain.Command;
using ProvCli.Domain.Entities;

namespace ProvCli.Api.Mappers
{
    public static class Mapping
    {
        public static void ModelToEntity(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<CriacaoFornecedorModel, CriacaoFornecedorCommand>();
        }

        public static void EntityToModel(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Fornecedor, ListagemFornecedorModel>();
        }
    }
}
