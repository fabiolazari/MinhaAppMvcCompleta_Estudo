﻿using AutoMapper;
using DevIO.App.ViewModels;
using DevIO.Business.Models;

namespace DevIO.App.AutoMapper
{
	public class AutoMapperConfig : Profile
	{
		public AutoMapperConfig()
		{
			CreateMap<Produto, ProdutoViewModel>().ReverseMap();
			CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
			CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
		}
	}
}
