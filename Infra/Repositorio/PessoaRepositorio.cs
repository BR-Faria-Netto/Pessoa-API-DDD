using Dominio.Interfaces;
using Dominio.Modelos;
using Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorio
{
    public class PessoaRepositorio : Repositorio<Pessoa>, IRepositoryPessoa
    {
        private readonly BancoContext _context;

        public PessoaRepositorio(BancoContext db) : base(db)
        {
            _context = db;
        }
    }
}
