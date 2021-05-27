﻿using DevIO.Business.Models;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
	public interface IProdutoService
	{
		Task Adicionar(Produto produto);
		Task Atualizar(Produto produto);
		Task Remover(Produto produto);
	}
}