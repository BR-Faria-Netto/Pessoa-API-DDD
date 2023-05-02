using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Interfaces;
using Dominio.Modelos;
using FluentValidation;

namespace Servico.Servicos
{
    public class PessoaServico : IServico<Pessoa>
    {
        private readonly IRepositoryPessoa _repositoryPessoa;

        public PessoaServico(IRepositoryPessoa repositoryPessoa)
        {
            _repositoryPessoa = repositoryPessoa;
        }

        public void Adicionar<TValidator>(Pessoa obj) where TValidator : AbstractValidator<Pessoa>
        {
            _repositoryPessoa.Adicionar(obj);
        }

        public void Atualizar<TValidator>(Pessoa obj) where TValidator : AbstractValidator<Pessoa>
        {
            _repositoryPessoa.Atualizar(obj);
        }

        public Pessoa BuscarPorId(int id)
        {
          return _repositoryPessoa.BuscarPorId(id);
        }

        public IList<Pessoa> BuscarTodos()
        {
            return _repositoryPessoa.BuscarTodos();
        }

        public void Deletar(int id)
        {
            _repositoryPessoa.Deletar(id);
        }
    }
}
