using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ENCONTRO_REMOTO_2.interfaces;

namespace ENCONTRO_REMOTO_2.classes
{
    public class PessoaJuridica : Pessoa , IPessoaJuridica
    {
        //Atributos
        public string ?Cnpj {get;set;}

        public string ?RazaoSocial {get;set;}

        //metodos
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        bool IPessoaJuridica.ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }

        // public bool ValidarCnpj(string cnpj)
        // {
        //     throw new NotImplementedException();
        // }
    }
}