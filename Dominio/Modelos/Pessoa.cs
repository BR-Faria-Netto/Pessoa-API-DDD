
using Dominio.Modelos;
using System;
using System.Collections.Generic;

public class Pessoa : ObjetoBase
{
    public string NomeCompleto { get; set; }
    public DateTime DataNascimento { get; set; }
    public List<Depentente> Dependentes_List { get; set; }

}