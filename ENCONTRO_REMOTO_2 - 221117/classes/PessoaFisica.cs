using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ENCONTRO_REMOTO_2.interfaces;

namespace ENCONTRO_REMOTO_2.classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica 
    {

        public string ?cpf {get;set;}

        public DateTime ?dadtaNaceimento {get;set;}

        //metodos
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }

         public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}