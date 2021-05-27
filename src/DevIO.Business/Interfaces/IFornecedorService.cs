using DevIO.Business.Models;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
	public interface IFornecedorService
	{
		Task Adicionar(Fornecedor fornecedor);
		Task Atualizar(Fornecedor fornecedor);
		Task Remover(Fornecedor fornecedor);
		Task AtualizarEndereco(Endereco endereco);
	}
}
