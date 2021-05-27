using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Business.Models.Validations;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Business.Services
{
	public class FornecedorService : BaseService, IFornecedorService
	{
		private readonly IFornecedorRepository _fornecedorRepository;
		private readonly IEnderecoRepository _enderecoRepository;

		public FornecedorService(IFornecedorRepository fornecedorRepository,
								 IEnderecoRepository enderecoRepository)
		{
			_fornecedorRepository = fornecedorRepository;
			_enderecoRepository = enderecoRepository;
		}

		public async Task Adicionar(Fornecedor fornecedor)
		{
			//Validar o estado da entidade
			/*
			var validator = new FornecedorValidation();
			var result = validator.Validate(fornecedor);
			if(!result.IsValid)
			{
				//result.Errors; --> coleção de erros...
			}
			*/
			if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)
			   || !ExecutarValidacao(new EnderecoValidation(), fornecedor.Endereco)) return;

			if (_fornecedorRepository.Buscar(f => f.Documento == fornecedor.Documento).Result.Any())
			{
				Notificar("Já existe um fornecedor com este documento infomado.");
				return;
			}

			await _fornecedorRepository.Adicionar(fornecedor);
		}

		public async Task Atualizar(Fornecedor fornecedor)
		{
			if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)) return;
		}

		public async Task AtualizarEndereco(Endereco endereco)
		{
			if (!ExecutarValidacao(new EnderecoValidation(), endereco)) return;
		}

		public async Task Remover(Fornecedor fornecedor)
		{
			throw new NotImplementedException();
		}
	}
}
