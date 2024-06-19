using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp.poo
{
    public class Pessoa
    {
        private int? anoNascimento; 

        public int? AnoNascimento{
            get{return this.anoNascimento;}
            set{this.anoNascimento = value;}
        }
        private string? nome;
        public string? Nome
        {
            get { return this.nome; }
            set { nome = value.ToUpper(); }
            
             }
             public void Dados(){
            Console.WriteLine($"Nome: {this.nome}"); 
            Console.WriteLine($"Ano de Nascimento: {this.anoNascimento}"); 
            Console.WriteLine($"Idade: {DateTime.Now.Year - this.anoNascimento}");
        }
    }
}