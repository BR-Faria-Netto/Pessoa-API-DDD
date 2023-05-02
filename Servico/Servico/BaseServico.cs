using Dominio.Interfaces;
using Dominio.Modelos;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace Servico.Servicos
{
   public class BaseServico<TEntity> : IBaseServico<TEntity> where TEntity : ObjetoBase
   {
       private readonly IBaseRepositorio<TEntity> _baseRepositorio;

       public BaseServico(IBaseRepositorio<TEntity> baseRepositorio)
       {
            _baseRepositorio = baseRepositorio;
       }

        TEntity IBaseServico<TEntity>.Adicionar(TEntity obj)
        {
            _baseRepositorio.Adicionar(obj);
            return obj;
        }

        TEntity IBaseServico<TEntity>.Atualizar(TEntity obj)
        {
            _baseRepositorio.Atualizar(obj);
            return obj;
        }

        public void Deletar(int id) => _baseRepositorio.Deletar(id);

       public IList<TEntity> BuscarTodos() => _baseRepositorio.BuscarTodos();

       public TEntity BuscarPorId(int id) => _baseRepositorio.BuscarPorId(id);

       private void Validate(TEntity obj, AbstractValidator<TEntity> validator)
       {
           if (obj == null)
               throw new Exception("Registros não encontrados!");

           validator.ValidateAndThrow(obj);
       }

    }
}
