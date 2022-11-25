using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ENCONTRO_REMOTO_2.interfaces;

namespace ENCONTRO_REMOTO_2.classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica 
    {
        //construtores
        public PessoaFisica(){} //construtor sobrecarga
        public PessoaFisica( string parCpf){ //construtor Com parametros

            this.Cpf= parCpf;
            // Console.WriteLine("\n*****  Nova Pessoa Fisica Criada ******");
        }

        //atributos
        public string ?Cpf {get;set;}

        public DateTime DataNaceimento {get;set;}

        //metodos
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            Console.WriteLine($"Usando Date time : {dataNasc}");
            DateTime dataAtual = DateTime.Today;

            double idade = ((dataAtual-dataNasc).TotalDays)/365;
             if (idade>=18){                  
                    return true;
                }            

            return false;
        }

        public bool ValidarDataNascimento(string dataNasc)
        {
            // Console.WriteLine(dataNasc);
            DateTime dataConvertida;
            if(DateTime.TryParse(dataNasc, out dataConvertida))
            {
                
                DateTime dataAtual = DateTime.Today;
                double idade = ((dataAtual-dataConvertida).TotalDays)/365;  

                // Console.WriteLine(dataConvertida);
                // Console.WriteLine(dataAtual);
                // Console.WriteLine(idade);  

                if (idade>=18){                   
                    return true;
                }             
                              
            }
            return false;
        }

         public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}

/*var date1 = new DateTime(2008, 5, 1, 8, 30, 52); formato de entrada
Console.WriteLine(date1);*/