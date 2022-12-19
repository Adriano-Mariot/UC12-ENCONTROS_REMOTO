using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using ENCONTRO_REMOTO_2.interfaces;

namespace ENCONTRO_REMOTO_2.classes
{
    public class PessoaJuridica : Pessoa , IPessoaJuridica
    {
        //Atributos
        public string ?Cnpj {get;set;}

        public string ?RazaoSocial {get;set;}
        public string ?Fantasia {get;set;}

        //metodos
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            //pj1.Cnpj="14.625.806/0001-80"
            if(Regex.IsMatch(cnpj,@"^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$")){
                if(cnpj.Length==18){ //CNPJ com mascara
                    if (cnpj.Substring(11,4)=="0001"){
                        return true;
                    }
                }
                else if(cnpj.Length==14){ // CNPJ sem mascara
                    if (cnpj.Substring(8,4)=="0001"){
                        return true;
                    }
                }
            }          
            return false;
        }
    }
}

