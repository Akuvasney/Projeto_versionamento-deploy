using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Itau_1
{
    class Classe_funcionarios
    {
        public string nome;
        public int cargaHoraria;
        public double valorHora;

        public Classe_funcionarios()
        {

        }

        public Classe_funcionarios(string nomeVar, int cargaHorariaVar, double valorHoraVar)
        {
            this.nome = nomeVar;
            this.cargaHoraria = cargaHorariaVar;
            this.valorHora = valorHoraVar;
        }
        public virtual double CalculaSalario()
        {
            return this.valorHora*this.cargaHoraria;
        }

        public virtual void ImprimeDados()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Salario: " + this.CalculaSalario());

        }
    }

    class Classe_terceiro : Classe_funcionarios
    {
        public string EmpresaOrigem { get; set; }
        public double TaxaServico { get; set; }

        public Classe_terceiro(string nome, int cargaHoraria, double valorHora, string empresaOrigem, double taxaServico)
        {
            this.nome = nome;
            this.cargaHoraria = cargaHoraria;
            this.valorHora = valorHora;
            EmpresaOrigem = empresaOrigem;
            TaxaServico = taxaServico;
        }



    public override double CalculaSalario()
        {
            return base.CalculaSalario()* this.TaxaServico;
        }

        public override void ImprimeDados()
        {
            base.ImprimeDados();
            Console.WriteLine("Empresa de origem: " + this.EmpresaOrigem);
        }

    }
}
