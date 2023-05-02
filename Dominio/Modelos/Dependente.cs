
using Dominio.Modelos;
using System;

public class Depentente : ObjetoBase
{
    public string NomeCompleto { get; set; }
    public DateTime DataNascimento { get; set; }
	public TipoDependente GrauPerentesco { get; set; }
}