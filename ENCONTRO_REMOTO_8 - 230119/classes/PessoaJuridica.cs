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

        public string caminho {get; private set;}="DataBase/Pessoa_Juridica.csv";

        //metodos
        public override float PagarImposto(float rendimento)
        {
             //regras:
            //para rendimentos de até R$5000 - alicota 6%
            //para rendimentos de R$5001 até R$10000 - alicota 8%
            //para rendimentos acima de R$10000 - alicota 10%

            if(rendimento<=5000)
            {
                return rendimento-((rendimento/100)*6);
            }
            else if(rendimento>5000 && rendimento <= 10000)
            {
                return rendimento-((rendimento/100)*8);
            }
            else 
            {
                return rendimento-((rendimento/100)*10);
            }
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

        public void Inserir(PessoaJuridica pj)
        {
            Utils.VerificarPastaArquivo(caminho);
            string [] pjValores={$"{pj.Nome},{pj.Cnpj},{pj.RazaoSocial},{pj.Fantasia},{pj.Endereco.Logradoura}"};

            File.AppendAllLines(caminho, pjValores);
        }

        public List <PessoaJuridica> LerArquivo ()
        {
            List<PessoaJuridica> ListaPj = new List<PessoaJuridica>();

            string [] linhas= File.ReadAllLines(caminho);

            foreach (string cadalinha in linhas)
            {
                string[] atributo = cadalinha.Split(",");

                PessoaJuridica NovoPj = new PessoaJuridica();
                NovoPj.Nome=atributo[0];
                NovoPj.Cnpj=atributo[1];
                NovoPj.RazaoSocial=atributo[2];
                NovoPj.Fantasia=atributo[3];
                // NovoPj.Endereco.Logradoura=atributo[4];

                ListaPj.Add(NovoPj);
            }
            return ListaPj;
        }
    }
}

